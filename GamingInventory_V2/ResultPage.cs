using System;
using System.Windows.Forms;
using System.Data;
using System.Text;
using GamingInventory;
using MySql.Data.MySqlClient;

namespace GamingInventory_V2
{
    class ResultPage : TabPage
    {
        SearchTable ResultTable;
        DataGridView ResultGrid;
        Panel SelectAllPanel;
        CheckBox SelectAllBox;
        Label SelectAllLabel;
        bool RaiseValueChanged = true;

        public SearchTable Tableau { get { return ResultTable; } }
        public ResultPage(ContextMenuStrip strip)
        {
            Text = "Name Me!";
            ResultGrid = new DataGridView();
            SelectAllBox = new CheckBox
            {
                Checked = true
            };
            SelectAllLabel = new Label();
            SelectAllPanel = new Panel
            {
                Location = new System.Drawing.Point(990, 2),
                Size = new System.Drawing.Size(100, 47)
            };
            SelectAllLabel.Text = "Check-In/Out All";
            SelectAllPanel.Controls.Add(SelectAllLabel);
            SelectAllBox.Location = new System.Drawing.Point(SelectAllLabel.Location.X, SelectAllLabel.Location.Y + 20);
            SelectAllBox.Click += SelectAllBox_Click;
            SelectAllPanel.Controls.Add(SelectAllBox);
            Controls.Add(SelectAllPanel);
            ResultGrid.CurrentCellDirtyStateChanged += ResultGrid_CurrentCellDirtyStateChanged;
            ResultGrid.CellValueChanged += ResultGrid_CellValueChanged;
            ResultGrid.Size = new System.Drawing.Size(1152, 260);
            ResultTable = new SearchTable();
            ContextMenuStrip = strip;
            ResultGrid.DataSource = ResultTable;
            ResultGrid.AllowUserToAddRows = false;
            Controls.Add(ResultGrid);
            HScroll = VScroll = true;
        }

        public void initColors()
        {
            DataGridViewCheckBoxCell cc;
            foreach (DataGridViewRow dgr in ResultGrid.Rows)
            {
                cc = dgr.Cells["CheckedIn"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cc.Value))
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                else
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
            }
        }

        public void AllItemsCheckedIn()
        {
            foreach (DataRow r in ResultTable.Rows)
            {
                if (!(bool)r["CheckedIn"])
                    SelectAllBox.Checked = false;
                return;
            }
        }

        private string BuildSelectAllUpdateQuery(bool checkIn)
        {
            StringBuilder ListBuilder = new StringBuilder();
            for (int i = 0; i < ResultTable.Rows.Count - 1; i++)
            {
                ListBuilder.AppendFormat("{0},", ResultTable.Rows[i]["ItemID"].ToString());
            }
            ListBuilder.Append(ResultTable.Rows[ResultTable.Rows.Count - 1]["ItemID"].ToString());
            StringBuilder selectAllBuilder = new StringBuilder("UPDATE `GAMINGINV`.`ITEMS` SET ");
            if (checkIn)
            {
                selectAllBuilder.AppendFormat("LastCheckIn = now() WHERE `ID` IN ({0});", ListBuilder.ToString());
            }
            else
            {
                selectAllBuilder.AppendFormat("LastCheckOut = now() WHERE `ID` IN ({0});", ListBuilder.ToString());
            }
            return selectAllBuilder.ToString();
        }

        private string BuildSelectAllInserteQuery(bool checkIn)
        {
            StringBuilder selectAllBuilder = new StringBuilder("INSERT INTO `GAMINGINV`.`CHECKINGINOUT` (`ITEMID`, `DIRECTION`, `CHECK`, `DURATION`) VALUES ");
            TimeSpan CheckDuration = new TimeSpan();

            if (checkIn)
            {
                for  (int i = 0; i < ResultTable.Rows.Count - 1; i++)
                {
                    CheckDuration = DateTime.Now - DateTime.Parse(ResultTable.Rows[i]["LastCheckOut"].ToString());
                    selectAllBuilder.AppendFormat("({0}, \'IN\', now(), {1}), ", ResultTable.Rows[i]["ItemID"], CheckDuration.TotalMinutes);
                }
                CheckDuration = DateTime.Now - DateTime.Parse(ResultTable.Rows[ResultTable.Rows.Count - 1]["LastCheckOut"].ToString());
                selectAllBuilder.AppendFormat("({0}, \'IN\', now(), {1});", ResultTable.Rows[ResultTable.Rows.Count - 1]["ItemID"], CheckDuration.TotalMinutes);
            }
            else
            {
                for (int i = 0; i < ResultTable.Rows.Count - 1; i++)
                {
                    selectAllBuilder.AppendFormat("({0}, \'OUT\', now(), 0), ", ResultTable.Rows[i]["ItemID"]);
                }
                selectAllBuilder.AppendFormat("({0}, \'OUT\', now(), 0);", ResultTable.Rows[ResultTable.Rows.Count - 1]["ItemID"]);
            }
            return selectAllBuilder.ToString();
        }

        private void SelectAllBox_Click(object sender, EventArgs e)
        {
            RaiseValueChanged = false;
            DataGridViewCheckBoxCell cc;
            MySqlCommand UpsertAllCmd = new MySqlCommand();
            UpsertAllCmd.Connection = Form1.MasterConnection;

            if (SelectAllBox.Checked)
            {
                foreach (DataGridViewRow dgr in ResultGrid.Rows)
                {
                    cc = dgr.Cells["CheckedIn"] as DataGridViewCheckBoxCell;
                    cc.Value = true;
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    (dgr.Cells["LastCheckIn"] as DataGridViewTextBoxCell).Value = DateTime.Now.ToString();
                }
                UpsertAllCmd.CommandText = BuildSelectAllUpdateQuery(true);
                UpsertAllCmd.ExecuteNonQuery();

                //Write checkin and checkout records only when con is live
                if (Form1.LiveCon)
                {
                    UpsertAllCmd.CommandText = BuildSelectAllInserteQuery(true);
                    UpsertAllCmd.ExecuteNonQuery();
                }
            }
            else
            {
                foreach (DataGridViewRow dgr in ResultGrid.Rows)
                {
                    cc = dgr.Cells["CheckedIn"] as DataGridViewCheckBoxCell;
                    cc.Value = false;
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                    (dgr.Cells["LastCheckOut"] as DataGridViewTextBoxCell).Value = DateTime.Now.ToString();
                }
                UpsertAllCmd.CommandText = BuildSelectAllUpdateQuery(false);
                UpsertAllCmd.ExecuteNonQuery();

                //Write checkin and checkout records only when con is live
                if (Form1.LiveCon)
                {
                    UpsertAllCmd.CommandText = BuildSelectAllInserteQuery(false);
                    UpsertAllCmd.ExecuteNonQuery();
                }
            }
            RaiseValueChanged = true;
        }

        private ItemResult GenerateItemResult(int r)
        {
            //ItemChanged = new ItemResult(r["OwnerName"], r["ItemID"], r["ItemType"], r["ItemPlatform"], r["ItemSerial"], r["ItemDescription"], r["LastCheckIn"], r["LastCheckOut"], false, r["isCheckedIn"]);
            DataRow row = ResultTable.Rows[r];
            return new ItemResult(row["OwnerName"].ToString(), decimal.Parse(row["ItemID"].ToString()), row["ItemType"].ToString(), row["ItemPlatform"].ToString(), row["ItemSerial_Title"].ToString(), row["ItemDescription"].ToString(), row["LastCheckIn"].ToString(), row["LastCheckOut"].ToString(), false, bool.Parse(row["CheckedIn"].ToString()));
        }

        private void ResultGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (RaiseValueChanged)
            {
                DataGridViewCheckBoxCell cc;
                ItemResult ItemChanged;

                if (ResultGrid.Columns[e.ColumnIndex].Name.Equals("CheckedIn"))
                {
                    cc = ResultGrid[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                    ItemChanged = GenerateItemResult(e.RowIndex);
                    if ((bool)cc.Value)
                    {
                        ItemChanged.LastCheckInValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        (ResultGrid["LastCheckIn", e.RowIndex] as DataGridViewTextBoxCell).Value = ItemChanged.LastCheckInValue;
                        ItemChanged.UpsertCheckInOut(Form1.MasterConnection, true, Form1.LiveCon);
                        ResultGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        //Cursor.Current = Cursors.WaitCursor;
                    }
                    else
                    {
                        ItemChanged.LastCheckOutValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        (ResultGrid["LastCheckOut", e.RowIndex] as DataGridViewTextBoxCell).Value = ItemChanged.LastCheckOutValue;
                        ItemChanged.UpsertCheckInOut(Form1.MasterConnection, false, Form1.LiveCon);
                        ResultGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                        //Cursor.Current = Cursors.WaitCursor;
                    }
                }
            }
        }

        private void ResultGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ResultGrid.IsCurrentCellDirty)
                ResultGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
