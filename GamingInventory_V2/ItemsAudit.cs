using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace GamingInventory_V2
{
    public partial class ItemsAudit : Form
    {
        public ItemsAudit()
        {
            InitializeComponent();

            //MySqlCommand SelectItemsCmd = new MySqlCommand("SELECT `ID`, `OWNER`, `TYPE`, `PLATFORM`, `SERIAL`, `DESCRIPTION`, (`LASTCHECKIN` > `LASTCHECKOUT`) AS \'BOUND\' FROM `ITEMS` ORDER BY `ID`;", Form1.MasterConnection);
            MySqlCommand SelectItemsCmd = new MySqlCommand("SELECT `ID`, `OWNER`, `TYPE`, `PLATFORM`, `SERIAL`, `DESCRIPTION`, `LastCheckIn`, `LastCheckOut`, `LogisticState`, `LogisticStateUpdated`, true AS \'BOUND\' FROM `ITEMS` ORDER BY `ID`;", Form1.MasterConnection);
            MySqlDataReader ItemsReader = SelectItemsCmd.ExecuteReader();
            while (ItemsReader.Read())
            {
                itemResultBindingSource.Add(new ItemResult(ItemsReader.GetString("Owner"), ItemsReader.GetDecimal("ID"), ItemsReader.GetString("Type"), ItemsReader.GetString("Platform"), ItemsReader.GetString("Serial"), ItemsReader.GetString("Description"), ItemsReader.GetString("LastCheckIn"), ItemsReader.GetString("LastCheckOut"), ItemsReader.GetString("LogisticState"), ItemsReader.GetMySqlDateTime("LogisticStateUpdated").ToString()));
            }
            ItemsReader.Close();
            dataGridView1.DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void showAuditSpreadSheet()
        {
            var auditExcelApp = new Excel.Application();
            //gamesExcelApp.Visible = true;
            auditExcelApp.Workbooks.Add();
            Excel._Worksheet auditSheet = (Excel._Worksheet)auditExcelApp.ActiveSheet;
            auditSheet.Cells[1, "A"] = "Owner";
            auditSheet.Cells[1, "B"] = "ID";
            auditSheet.Cells[1, "C"] = "Type";
            auditSheet.Cells[1, "D"] = "Platform";
            auditSheet.Cells[1, "E"] = "Serial/Title";
            auditSheet.Cells[1, "F"] = "Description";
            auditSheet.Cells[1, "G"] = "LogisticState";
            auditSheet.Cells[1, "H"] = "LogisticStateUpdated";
            int sheetRowPosition = 2;
            foreach (ItemResult result in itemResultBindingSource)
            {
                auditSheet.Cells[sheetRowPosition, "A"] = result.OwnerValue;
                auditSheet.Cells[sheetRowPosition, "B"] = result.IDValue;
                auditSheet.Cells[sheetRowPosition, "C"] = result.TypeValue;
                auditSheet.Cells[sheetRowPosition, "D"] = result.PlatformValue;
                auditSheet.Cells[sheetRowPosition, "E"] = result.SerialValue;
                auditSheet.Cells[sheetRowPosition, "F"] = result.DescriptionValue;
                auditSheet.Cells[sheetRowPosition, "G"] = result.LogisticState;
                auditSheet.Cells[sheetRowPosition, "H"] = result.LogisticStateUpdated;
                sheetRowPosition++;
            }
            auditSheet.Columns.AutoFit();
            auditExcelApp.ActiveWorkbook.SaveAs(Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\AuditReport");
            auditExcelApp.ActiveWorkbook.Close();
            MessageBox.Show("Saved to " + Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\AuditReport");
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ItemResult r;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("LogisticState"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                r = (itemResultBindingSource[e.RowIndex] as ItemResult);
                DataGridViewComboBoxCell c = (DataGridViewComboBoxCell)dataGridView1[e.ColumnIndex, e.RowIndex];
                switch (c.FormattedValue.ToString())
                {
                    case "Unseen":
                        r.LogisticStateUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE `items` set `LogisticStateUpdated` = now(), `LogisticState` = @LogisticStateParam WHERE `ID` = {r.IDValue};", Form1.MasterConnection);
                        mySqlCommand.Parameters.AddWithValue("@LogisticStateParam", r.LogisticState);
                        mySqlCommand.ExecuteNonQuery();
                        break;
                    case "Arrived":
                        r.LastCheckInValue = r.LogisticStateUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        r.UpsertCheckInOut(Form1.MasterConnection, true, true);
                        break;
                    case "Departed":
                        r.LastCheckOutValue = r.LogisticStateUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        r.UpsertCheckInOut(Form1.MasterConnection, false, true);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAuditSpreadSheet();
        }
    }
}
