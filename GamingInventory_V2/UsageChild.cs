using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
namespace GamingInventory_V2
{
    public partial class UsageChild : Form
    {
        UsageTable DurationTable;

        private void showUsageSpreadSheet()
        {
            var usageExcelApp = new Excel.Application();
            //gamesExcelApp.Visible = true;
            usageExcelApp.Workbooks.Add();
            Excel._Worksheet usageSheet = (Excel._Worksheet)usageExcelApp.ActiveSheet;
            usageSheet.Cells[1, "A"] = "Owner";
            usageSheet.Cells[1, "B"] = "ID";
            usageSheet.Cells[1, "C"] = "Type";
            usageSheet.Cells[1, "D"] = "Platform";
            usageSheet.Cells[1, "E"] = "Serial/Title";
            usageSheet.Cells[1, "F"] = "Description";
            usageSheet.Cells[1, "G"] = "Checked";
            usageSheet.Cells[1, "H"] = "Direction";
            usageSheet.Cells[1, "I"] = "Duration";
            int sheetRowPosition = 2;
            foreach (DataRow r in DurationTable.Rows)
            {
                usageSheet.Cells[sheetRowPosition, "A"] = r["OwnerName"];
                usageSheet.Cells[sheetRowPosition, "B"] = r["ItemID"];
                usageSheet.Cells[sheetRowPosition, "C"] = r["ItemType"];
                usageSheet.Cells[sheetRowPosition, "D"] = r["ItemPlatform"];
                usageSheet.Cells[sheetRowPosition, "E"] = r["ItemSerial_Title"];
                usageSheet.Cells[sheetRowPosition, "F"] = r["ItemDescription"];
                usageSheet.Cells[sheetRowPosition, "G"] = r["Check"];
                usageSheet.Cells[sheetRowPosition, "H"] = r["Direction"];
                usageSheet.Cells[sheetRowPosition, "I"] = r["Duration(mins)"];

                sheetRowPosition++;
            }
            usageSheet.Columns[1].AutoFit();
            usageSheet.Columns[2].AutoFit();
            usageSheet.Columns[3].AutoFit();
            usageSheet.Columns[4].AutoFit();
            usageSheet.Columns[5].AutoFit();
            usageSheet.Columns[6].AutoFit();
            usageSheet.Columns[7].AutoFit();
            usageSheet.Columns[8].AutoFit();
            usageSheet.Columns[9].AutoFit();
            usageExcelApp.ActiveWorkbook.SaveAs(Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\UsageReport");
            usageExcelApp.ActiveWorkbook.Close();
            MessageBox.Show("Saved to " + Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\UsageReport");
        }

        public UsageChild()
        {
            InitializeComponent();
            DurationTable = new UsageTable();
            MySqlCommand DurationCmd = new MySqlCommand("select checkinginout.`Check`, checkinginout.Direction, checkinginout.Duration, checkinginout.ItemID, items.`Owner`, items.`Type`, items.Platform, items.`Serial`, items.Description from checkinginout left join items on items.ID=checkinginout.itemID order by Duration desc;", Form1.MasterConnection);
            MySqlDataReader DurationReader = DurationCmd.ExecuteReader();
            while (DurationReader.Read())
            {
                DurationTable.MakeRow(DurationReader.GetDecimal("ItemID"), DurationReader.GetString("Owner"), DurationReader.GetString("Platform"), DurationReader.GetString("Serial"), DurationReader.GetString("Description"), DurationReader.GetString("Type"), DurationReader.GetString("Direction"), DurationReader.GetString("Check"), DurationReader.GetInt32("Duration"));
            }
            DurationReader.Close();
            dataGridView1.DataSource = DurationTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reportPrinter.PrintDataGridView(dataGridView1);
            showUsageSpreadSheet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
