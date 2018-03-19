using System;
using System.Windows.Forms;
using GamingInventory;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

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
            foreach (ItemResult result in itemResultBindingSource)
            {
                gamesSheet.Cells[sheetRowPosition, "A"] = result.PlatformValue;
                gamesSheet.Cells[sheetRowPosition, "B"] = result.SerialValue;
                gamesSheet.Cells[sheetRowPosition, "C"] = result.DescriptionValue;
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

            MySqlCommand SelectGamesByPlatformCmd = new MySqlCommand("SELECT `PLATFORM`, `SERIAL`, `DESCRIPTION`, (`LastCheckOut` < `LastCheckIn`) as \'Bound\'  FROM `ITEMS` WHERE `TYPE` = \'GAME\' ORDER BY `PLATFORM`;", Form1.MasterConnection);
            MySqlDataReader ReadGames = SelectGamesByPlatformCmd.ExecuteReader();
            while (ReadGames.Read())
            {
                itemResultBindingSource.Add(new ItemResult(ReadGames.GetString("Platform"), ReadGames.GetString("Serial"), ReadGames.GetString("Description"), ReadGames.GetBoolean("Bound")));
            }
            ReadGames.Close();
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
