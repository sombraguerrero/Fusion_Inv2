using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
namespace GamingInventory_V2
{
    public partial class UsageChild : Form
    {
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
            foreach (DataRow r in usageDS.Tables[0].Rows)
            {
                usageSheet.Cells[sheetRowPosition, "A"] = r["Owner"];
                usageSheet.Cells[sheetRowPosition, "B"] = r["ItemID"];
                usageSheet.Cells[sheetRowPosition, "C"] = r["Type"];
                usageSheet.Cells[sheetRowPosition, "D"] = r["Platform"];
                usageSheet.Cells[sheetRowPosition, "E"] = r["Serial"];
                usageSheet.Cells[sheetRowPosition, "F"] = r["Description"];
                usageSheet.Cells[sheetRowPosition, "G"] = r["Check"];
                usageSheet.Cells[sheetRowPosition, "H"] = r["Direction"];
                usageSheet.Cells[sheetRowPosition, "I"] = r["Duration"];

                sheetRowPosition++;
            }
            usageSheet.Columns.AutoFit();
            usageExcelApp.ActiveWorkbook.SaveAs(Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\UsageReport");
            usageExcelApp.ActiveWorkbook.Close();
            MessageBox.Show("Saved to " + Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\UsageReport");
        }

        public UsageChild()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource1;
            MySqlCommand DurationCmd = new MySqlCommand("select checkinginout.`Check`, checkinginout.Direction, checkinginout.Duration, checkinginout.ItemID, items.`Owner`, items.`Type`, items.Platform, items.`Serial`, items.Description from checkinginout left join items on items.ID=checkinginout.itemID order by Duration desc;", Form1.MasterConnection);
            MySqlDataAdapter DurationReader = new MySqlDataAdapter(DurationCmd);
            DurationReader.Fill(usageDS);
            bindingSource1.DataSource = usageDS.Tables[0];
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
