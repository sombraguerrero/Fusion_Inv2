using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GamingInventory_V2
{
    public partial class SearchOwners : Form
    {

        public SearchOwners()
        {
            InitializeComponent();
            HScroll = true;
            ownerSelection_box.SelectedIndex = 0;
            populateOwnersBox();
        }

        private void populateOwnersBox()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Name` from `gaminginv`.`owner`;", Form1.MasterConnection);
            MySqlDataReader ComboReader = selectItems.ExecuteReader();
            while (ComboReader.Read())
            {
                ownerSelection_box.Items.Add(ComboReader.GetString(0));
                ownerSelection_box.Update();
            }
            ComboReader.Close();
        }

        private void ownerSelection_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerResultBindingSource.Clear();
            OwnerResult SelectedOwner = new OwnerResult();
            SelectedOwner.IDName = ownerSelection_box.SelectedItem.ToString();
            MySqlCommand QueryOwner = new MySqlCommand("select * from `gaminginv`.`owner` where `Name` = @NameParam" + ';', Form1.MasterConnection);
            QueryOwner.Parameters.AddWithValue("@NameParam", SelectedOwner.IDName);
            MySqlDataReader OwnerReader = QueryOwner.ExecuteReader();
            if (OwnerReader.Read())
            {
                SelectedOwner.BadgeName = OwnerReader.GetString("BadgeName");
                SelectedOwner.EmailAddress = OwnerReader.GetString("Email");
                SelectedOwner.ItemQty = OwnerReader.GetInt32("ItemCount");
                SelectedOwner.OwnerID = OwnerReader.GetInt32("ID");
                SelectedOwner.PhoneNumber = OwnerReader.GetString("Phone");
                ownerResultBindingSource.Add(SelectedOwner);
            }
            OwnerReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
