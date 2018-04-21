using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GamingInventory_V2
{
    public partial class UpdateOwnerChild : Form
    {

        public UpdateOwnerChild()
        {
            InitializeComponent();
            updateSuccess_label.ForeColor = Color.Green;
            populateOwnersBox();
        }

        private void populateOwnersBox()
        {
            MySqlCommand selectItems = new MySqlCommand("select `Name` from `gaminginv`.`owner`;", Form1.MasterConnection);
            MySqlDataReader ComboReader = selectItems.ExecuteReader();
            while (ComboReader.Read())
            {
                updateOwnerBox.Items.Add(ComboReader.GetString(0));
                updateOwnerBox.Update();
            }
            ComboReader.Close();
        }

        private void updateOwnerClose_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitUpdateOwner_btn_Click(object sender, EventArgs e)
        {
            ownerResultBindingSource.Position = 0;
            OwnerResult OwnerToUpdate = (OwnerResult)ownerResultBindingSource.Current;
            OwnerToUpdate.Update(Form1.MasterConnection);
            updateSuccess_label.Text = "Owner Updated Successfully!";
            updateSuccess_label.Show();
        }

        private void updateOwnerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerResultBindingSource.Clear();
            OwnerResult SelectedOwner = new OwnerResult();
            SelectedOwner.IDName = updateOwnerBox.SelectedItem.ToString();
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
    }
}
