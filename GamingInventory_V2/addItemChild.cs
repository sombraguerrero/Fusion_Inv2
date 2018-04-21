using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GamingInventory_V2
{
    public partial class addItemChild : Form
    {
        uint idToStart = 0;
        int currentPos = 0;

        public addItemChild()
        {
            InitializeComponent();
            HScroll = true;
            addItemResults_label.ForeColor = Color.Green;
            populateOwnersBox();
            populatePlatforms();
        }

        private void populatePlatforms()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Platforms` from `configs`;", Form1.MasterConnection);
            string s = selectItems.ExecuteScalar().ToString();
            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["platformValueDataGridViewComboBoxColumn"];
            theColumn.Items.AddRange(s.Split(','));
        }

        private void populateOwnersBox()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Name` from `gaminginv`.`owner`;", Form1.MasterConnection);
            MySqlDataReader ComboReader = selectItems.ExecuteReader();
            while (ComboReader.Read())
            {
                ownerBox_unbound.Items.Add(ComboReader.GetString(0));
            }
            ComboReader.Close();
        }

        private void submitaddedItems_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ItemResult r in itemResultBindingSource)
            {
                r.OwnerValue = ownerBox_unbound.SelectedItem.ToString();
                r.Insert(Form1.MasterConnection);
                count++;
            }
            addItemResults_label.Text = count + " items added successfully!";
            addItemResults_label.Show();
        }

        private void closeAddItem_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ownerBox_unbound_SelectionChangeCommitted(object sender, EventArgs e)
        {
            itemResultBindingSource.Clear();
            currentPos = 0;
            MySqlCommand GetOwnerInfo = new MySqlCommand("select max(id) from `gaminginv`.`items` where `Owner` = @NameParam" + ';', Form1.MasterConnection);
            GetOwnerInfo.Parameters.AddWithValue("@NameParam", ownerBox_unbound.SelectedItem.ToString());
            //Console.Write(GetOwnerInfo.ExecuteScalar());
            if (GetOwnerInfo.ExecuteScalar() != DBNull.Value)
                idToStart = (uint)GetOwnerInfo.ExecuteScalar();
            else
            {
                GetOwnerInfo.CommandText = "SELECT MAX(ID) from owner";
                idToStart = (uint)GetOwnerInfo.ExecuteScalar();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ownerBox_unbound.SelectedItem != null && dataGridView1[0, e.RowIndex].Value == null && e.RowIndex >= currentPos)
            {
                dataGridView1[0, e.RowIndex].Value = (int)++idToStart;
                currentPos++;
            }
            else if (e.RowIndex < currentPos)
            {
                currentPos = e.RowIndex;
            }
        }
    }
}
