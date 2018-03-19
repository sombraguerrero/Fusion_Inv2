using System;
using System.Windows.Forms;
using GamingInventory;
using MySql.Data.MySqlClient;


namespace GamingInventory_V2
{
    public partial class SearchItems : Form
    {

        public SearchItems()
        {
            InitializeComponent();
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
            string query;
            MySqlCommand QueryItems = new MySqlCommand();
            MySqlDataReader ReadSearchedItems = null;
            ItemResult ItemToSelect = new ItemResult();
            ResultPage RPage = new ResultPage(contextMenuStrip1);

            GetValidFields(ItemToSelect);
            query = ItemToSelect.BuildSelectQuery(QueryItems, true, IDSpinner.Enabled, OwnerCombo.Enabled, PlatformCombo.Enabled, SerialText.Enabled, TypeCombo.Enabled, DescriptionText.Enabled, archiveCheck.Checked);
            if (!query.Equals(string.Empty))
            {
                QueryItems.CommandText = query;
                QueryItems.Connection = Form1.MasterConnection;
                ReadSearchedItems = QueryItems.ExecuteReader();
                while (ReadSearchedItems.Read() && ReadSearchedItems != null)
                {
                    RPage.Tableau.MakeRowFromtItemResult(new ItemResult(ReadSearchedItems.GetString("Owner"), ReadSearchedItems.GetInt32("ID"), ReadSearchedItems.GetString("Type"), ReadSearchedItems.GetString("Platform"), ReadSearchedItems.GetString("Serial"), ReadSearchedItems.GetString("Description"), ReadSearchedItems.GetString("LastCheckIn"), ReadSearchedItems.GetString("LastCheckout"), ReadSearchedItems.GetBoolean("Archived"), ReadSearchedItems.GetBoolean("Bound")));
                }
                ReadSearchedItems.Close();
                RPage.AllItemsCheckedIn();
                resultsTabs_ctrl.TabPages.Add(RPage);
                RPage.initColors();
                resultsTabs_ctrl.SelectedIndex = resultsTabs_ctrl.TabPages.Count - 1;
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            TabPage tmp = contextMenuStrip1.SourceControl as TabPage;
            tmp.Text = toolStripTextBox1.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resultsTabs_ctrl.SelectedTab.Dispose();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                contextMenuStrip1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items[0].Text = "Tab Name Here...";
        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = string.Empty;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
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
    }
}
