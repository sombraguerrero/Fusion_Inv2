using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace GamingInventory_V2
{
    public partial class GamesByPlatform : Form
    {

        private void showGamesSpreadSheet()
        {
            var gamesExcelApp = new Excel.Application();
            //gamesExcelApp.Visible = true;
            gamesExcelApp.Workbooks.Add();
            Excel._Worksheet gamesSheet = (Excel._Worksheet)gamesExcelApp.ActiveSheet;
            gamesSheet.Cells[1, "A"] = "Platform";
            gamesSheet.Cells[1, "B"] = "Serial/Title";
            gamesSheet.Cells[1, "C"] = "Description";
            int sheetRowPosition = 2;
            foreach (DataRow result in gamesDS.Tables[0].Rows)
            {
                gamesSheet.Cells[sheetRowPosition, "A"] = result["Platform"];
                gamesSheet.Cells[sheetRowPosition, "B"] = result["Serial"];
                gamesSheet.Cells[sheetRowPosition, "C"] = result["Description"];
                sheetRowPosition++;
            }
            gamesSheet.Columns[1].AutoFit();
            gamesSheet.Columns[2].AutoFit();
            gamesSheet.Columns[3].AutoFit();
            gamesExcelApp.ActiveWorkbook.SaveAs(Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\GamesList");
            gamesExcelApp.ActiveWorkbook.Close();
            MessageBox.Show("Saved to " + Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\GamesList");
        }

        public GamesByPlatform()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource1;
            MySqlCommand SelectGamesByPlatformCmd = new MySqlCommand("SELECT `PLATFORM`, `SERIAL`, `DESCRIPTION` FROM `ITEMS` WHERE `TYPE` = \'GAME\' ORDER BY `PLATFORM`;", Form1.MasterConnection);
            MySqlDataAdapter ReadGames = new MySqlDataAdapter(SelectGamesByPlatformCmd);
            ReadGames.Fill(gamesDS);
            bindingSource1.DataSource = gamesDS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showGamesSpreadSheet();
        }
    }
}
