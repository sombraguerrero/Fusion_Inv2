using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;


namespace GamingInventory_V2
{
    public partial class SearchItems : Form
    {
        bool RaiseValueChanged = true;
        BindingSource binding;

        public SearchItems()
        {
            InitializeComponent();

            binding = new BindingSource();
            dataGridView1.DataSource = binding;
            HScroll = true;
            VScroll = true;
            
            populateOwnersBox();
            populatePlatforms();
        }

        private void populatePlatforms()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Platforms` from `configs`;", Form1.MasterConnection);
            string s = selectItems.ExecuteScalar().ToString();
            PlatformCombo.Items.AddRange(s.Split(','));
        }

        private void populateOwnersBox()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Name` from `gaminginv`.`owner`;", Form1.MasterConnection);
            MySqlDataReader ComboReader = selectItems.ExecuteReader();
            while (ComboReader.Read())
            {
                OwnerCombo.Items.Add(ComboReader.GetString(0));
            }
            ComboReader.Close();
        }

        private void GetValidFields(ItemResult r)
        {
            if (IDSpinner.Enabled && IDSpinner.Value > 0 && !IDSpinner.Controls[1].Text.Equals(string.Empty))
                r.IDValue = IDSpinner.Value;
            if (OwnerCombo.Enabled && OwnerCombo.SelectedIndex >= 0)
                r.OwnerValue = OwnerCombo.SelectedItem.ToString();
            if (TypeCombo.Enabled && TypeCombo.SelectedIndex >= 0)
                r.TypeValue = TypeCombo.SelectedItem.ToString();
            if (SerialText.Enabled && !SerialText.Text.Equals(string.Empty))
                r.SerialValue = SerialText.Text;
            if (PlatformCombo.Enabled && PlatformCombo.SelectedIndex >= 0)
                r.PlatformValue = PlatformCombo.SelectedItem.ToString();
            if (DescriptionText.Enabled && !DescriptionText.Equals(string.Empty))
                r.DescriptionValue = DescriptionText.Text;
        }

        private void itemSearch()
        {
            searchDS.Clear();
            string query;
            MySqlCommand QueryItems = new MySqlCommand();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            ItemResult ItemToSelect = new ItemResult();

            GetValidFields(ItemToSelect);
            query = ItemToSelect.BuildSelectQuery(QueryItems, IDSpinner.Enabled, OwnerCombo.Enabled, PlatformCombo.Enabled, SerialText.Enabled, TypeCombo.Enabled, DescriptionText.Enabled);
            if (!query.Equals(string.Empty))
            {
                QueryItems.CommandText = query;
                QueryItems.Connection = Form1.MasterConnection;
                mySqlDataAdapter.SelectCommand = QueryItems;
                mySqlDataAdapter.Fill(searchDS);
                if (searchDS.Tables[0].Columns["CheckedIn"] == null)
                    searchDS.Tables[0].Columns.Add("CheckedIn", Type.GetType("System.Boolean"));
                initChecks();
                binding.DataSource = searchDS.Tables[0];
                AllItemsCheckedIn();
                initColors();
            }
        }

        private void initChecks()
        {
            DateTime cin;
            DateTime cout;
            foreach (DataRow item in searchDS.Tables[0].Rows)
            {
                //MessageBox.Show(item["LastCheckIn"].ToString());
                //MessageBox.Show(item["LastCheckOut"].ToString());
                cin = DateTime.Parse(item["LastCheckIn"].ToString());
                cout = DateTime.Parse(item["LastCheckOut"].ToString());
                item["CheckedIn"] = cin >= cout;
            }
        }

        private void findItems_btn_Click(object sender, EventArgs e)
        {
            itemSearch();
        }

        private void IDCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!IDCheck.Checked)
                IDSpinner.Enabled = false;
            else
                IDSpinner.Enabled = true;
        }

        private void OwnerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!OwnerCheck.Checked)
                OwnerCombo.Enabled = false;
            else
                OwnerCombo.Enabled = true;
        }

        private void TypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!TypeCheck.Checked)
                TypeCombo.Enabled = false;
            else
                TypeCombo.Enabled = true;
        }

        private void PlatformCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!PlatformCheck.Checked)
                PlatformCombo.Enabled = false;
            else
                PlatformCombo.Enabled = true;
        }

        private void SerialCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!SerialCheck.Checked)
                SerialText.Enabled = false;
            else
                SerialText.Enabled = true;
        }

        private void DescriptionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!DescriptionCheck.Checked)
                DescriptionText.Enabled = false;
            else
                DescriptionText.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SerialText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                itemSearch();
        }

        private void DescriptionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                itemSearch();
        }

        private void IDSpinner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                itemSearch();
        }

        public void initColors()
        {
            DataGridViewCheckBoxCell cc;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
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
            foreach (DataRow r in searchDS.Tables[0].Rows)
            {
                bool tmp = Convert.ToBoolean(r["CheckedIn"]);
                if (!tmp)
                    SelectAllBox.Checked = false;
                return;
            }
        }

        private string BuildSelectAllUpdateQuery(bool checkIn)
        {
            StringBuilder ListBuilder = new StringBuilder();
            for (int i = 0; i < searchDS.Tables[0].Rows.Count - 1; i++)
            {
                ListBuilder.AppendFormat("{0},", searchDS.Tables[0].Rows[i]["ID"].ToString());
            }
            ListBuilder.Append(searchDS.Tables[0].Rows[searchDS.Tables[0].Rows.Count - 1]["ID"].ToString());
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
                for (int i = 0; i < searchDS.Tables[0].Rows.Count - 1; i++)
                {
                    CheckDuration = DateTime.Now - DateTime.Parse(searchDS.Tables[0].Rows[i]["LastCheckOut"].ToString());
                    selectAllBuilder.AppendFormat("({0}, \'IN\', now(), {1}), ", searchDS.Tables[0].Rows[i]["ID"], CheckDuration.TotalMinutes);
                }
                CheckDuration = DateTime.Now - DateTime.Parse(searchDS.Tables[0].Rows[searchDS.Tables[0].Rows.Count - 1]["LastCheckOut"].ToString());
                selectAllBuilder.AppendFormat("({0}, \'IN\', now(), {1});", searchDS.Tables[0].Rows[searchDS.Tables[0].Rows.Count - 1]["ID"], CheckDuration.TotalMinutes);
            }
            else
            {
                for (int i = 0; i < searchDS.Tables[0].Rows.Count - 1; i++)
                {
                    selectAllBuilder.AppendFormat("({0}, \'OUT\', now(), 0), ", searchDS.Tables[0].Rows[i]["ID"]);
                }
                selectAllBuilder.AppendFormat("({0}, \'OUT\', now(), 0);", searchDS.Tables[0].Rows[searchDS.Tables[0].Rows.Count - 1]["ID"]);
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
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    cc = dgr.Cells["CheckedIn"] as DataGridViewCheckBoxCell;
                    cc.Value = true;
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    (dgr.Cells["LastCheckIn"] as DataGridViewTextBoxCell).Value = DateTime.Now.ToString();
                }
                UpsertAllCmd.CommandText = BuildSelectAllUpdateQuery(true);
                UpsertAllCmd.ExecuteNonQuery();

                //Write checkin and checkout records
                UpsertAllCmd.CommandText = BuildSelectAllInserteQuery(true);
                UpsertAllCmd.ExecuteNonQuery();
            }
            else
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    cc = dgr.Cells["CheckedIn"] as DataGridViewCheckBoxCell;
                    cc.Value = false;
                    dgr.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                    (dgr.Cells["LastCheckOut"] as DataGridViewTextBoxCell).Value = DateTime.Now.ToString();
                }
                UpsertAllCmd.CommandText = BuildSelectAllUpdateQuery(false);
                UpsertAllCmd.ExecuteNonQuery();

                //Write checkin and checkout records
                UpsertAllCmd.CommandText = BuildSelectAllInserteQuery(false);
                UpsertAllCmd.ExecuteNonQuery();
            }
            RaiseValueChanged = true;
        }

        private ItemResult GenerateItemResult(int r)
        {
            //ItemChanged = new ItemResult(r["OwnerName"], r["ItemID"], r["ItemType"], r["ItemPlatform"], r["ItemSerial"], r["ItemDescription"], r["LastCheckIn"], r["LastCheckOut"], false, r["isCheckedIn"]);
            DataRow row = searchDS.Tables[0].Rows[r];
            return new ItemResult(row["Owner"].ToString(), Convert.ToDecimal(row["ID"]), row["Type"].ToString(), row["Platform"].ToString(), row["Serial"].ToString(), row["Description"].ToString(), row["LastCheckIn"].ToString(), row["LastCheckOut"].ToString(), Convert.ToBoolean(row["CheckedIn"]));
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (RaiseValueChanged)
            {
                DataGridViewCheckBoxCell cc;
                ItemResult ItemChanged;

                if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("CheckedIn"))
                {
                    cc = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                    ItemChanged = GenerateItemResult(e.RowIndex);
                    if ((bool)cc.Value)
                    {
                        ItemChanged.LastCheckInValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        (dataGridView1["LastCheckIn", e.RowIndex] as DataGridViewTextBoxCell).Value = ItemChanged.LastCheckInValue;
                        ItemChanged.UpsertCheckInOut(Form1.MasterConnection, true);
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        //Cursor.Current = Cursors.WaitCursor;
                    }
                    else
                    {
                        ItemChanged.LastCheckOutValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        (dataGridView1["LastCheckOut", e.RowIndex] as DataGridViewTextBoxCell).Value = ItemChanged.LastCheckOutValue;
                        ItemChanged.UpsertCheckInOut(Form1.MasterConnection, false);
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                        //Cursor.Current = Cursors.WaitCursor;
                    }
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
