using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Collections;

namespace GamingInventory_V2
{
    public partial class UpdateItemsChild : Form
    {
        ArrayList dirtyRows;
        BindingSource binding;

        public UpdateItemsChild()
        {
            InitializeComponent();
            binding = new BindingSource();
            dataGridView1.DataSource = binding;
            dirtyRows = new ArrayList();
            HScroll = true;
            updateResults_label.ForeColor = Color.Green;
            populateOwnersBox();
            populatePlatforms();
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

        private void populatePlatforms()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Platforms` from `configs`;", Form1.MasterConnection);
            string s = selectItems.ExecuteScalar().ToString();
            PlatformCombo.Items.AddRange(s.Split(','));
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
                binding.DataSource = searchDS.Tables[0];
            }
        }

        private void findItems_btn_Click(object sender, EventArgs e)
        {
            itemSearch();
        }

        private void updateItemsClose_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitItemUpdates_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            ItemResult UpdateItem;
            foreach (int r in dirtyRows)
            {
                UpdateItem = GenerateItemResult(r);
                if (UpdateItem.DescriptionValue == null)
                    UpdateItem.DescriptionValue = string.Empty;
                else if (UpdateItem.SerialValue == null)
                    UpdateItem.SerialValue = string.Empty;
                UpdateItem.Update(Form1.MasterConnection);
                count++;
            }
            updateResults_label.Text = count + " items updated successfully!";
            updateResults_label.Show();
            dirtyRows.Clear();
        }

        private ItemResult GenerateItemResult(int r)
        {
            //ItemChanged = new ItemResult(r["OwnerName"], r["ItemID"], r["ItemType"], r["ItemPlatform"], r["ItemSerial"], r["ItemDescription"], r["LastCheckIn"], r["LastCheckOut"], false, r["isCheckedIn"]);
            DataRow row = searchDS.Tables[0].Rows[r];
            return new ItemResult(row["Platform"].ToString(), row["Serial"].ToString(), row["Description"].ToString(), row["Type"].ToString());
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dirtyRows != null && !dirtyRows.Contains(e.RowIndex))
            {
                dirtyRows.Add(e.RowIndex);
            }
        }

        private void SerialText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
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
