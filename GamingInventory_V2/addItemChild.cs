using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GamingInventory_V2
{
    public partial class addItemChild : Form
    {
        decimal initOwnerID;
        int currentPos = 0;
        int[] QtyMin = new int[5];
        int[] QtyMax = new int[5];
        int[] counters = { 0, 0, 0, 0, 0 };
        List<decimal> maxIDs = new List<decimal>();

        public addItemChild()
        {
            InitializeComponent();
            HScroll = true;
            addItemResults_label.ForeColor = Color.Green;
            populateOwnersBox();
            populatePlatforms();
            populateQtys();
        }

        private void populateQtys()
        {
            MySqlCommand minsCommand = new MySqlCommand("SELECT QtyMin, QtyMax from itemtypes", Form1.MasterConnection);
            MySqlDataReader mySqlDataReader = minsCommand.ExecuteReader();
            int i = 0;
            while (mySqlDataReader.Read())
            {
                QtyMin[i] = mySqlDataReader.GetInt32(0);
                QtyMax[i] = mySqlDataReader.GetInt32(1);
                i++;
            }
            mySqlDataReader.Close();
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
            RefreshMaximums();
        }

        private void closeAddItem_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ownerBox_unbound_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!submitaddedItems_btn.Enabled)
                submitaddedItems_btn.Enabled = true;
            RefreshMaximums();
        }

        private void RefreshMaximums()
        {
            itemResultBindingSource.Clear();
            initOwnerID = 0;
            currentPos = 0;
            for (int i = 0; i < counters.Length; i++)
                counters[i] = 0;
            if (maxIDs.Count > 0)
                maxIDs.Clear();
            string chosenOwner = ownerBox_unbound.SelectedItem.ToString();
            MySqlCommand GetOwnerInfo = new MySqlCommand
            {
                Connection = Form1.MasterConnection
            };
            GetOwnerInfo.Parameters.AddWithValue("@NameParam", chosenOwner);
            GetOwnerInfo.CommandText = "SELECT ID FROM `OWNER` WHERE `NAME` = @NameParam";
            //object testObject = GetOwnerInfo.ExecuteScalar();
            initOwnerID = (uint)GetOwnerInfo.ExecuteScalar();
            GetOwnerInfo.CommandText = $"SELECT COALESCE(MAX(ID), {initOwnerID + QtyMin[0]}) FROM ITEMS WHERE `OWNER` = @NameParam AND `Type` = 'Console'";
            maxIDs.Add((decimal)GetOwnerInfo.ExecuteScalar());
            GetOwnerInfo.CommandText = $"SELECT COALESCE(MAX(ID), {initOwnerID + QtyMin[1]}) FROM ITEMS WHERE `OWNER` = @NameParam AND `Type` = 'Controller'";
            maxIDs.Add((decimal)GetOwnerInfo.ExecuteScalar());
            GetOwnerInfo.CommandText = $"SELECT COALESCE(MAX(ID), {initOwnerID + QtyMin[2]}) FROM ITEMS WHERE `OWNER` = @NameParam AND `Type` = 'Peripheral'";
            maxIDs.Add((decimal)GetOwnerInfo.ExecuteScalar());
            GetOwnerInfo.CommandText = $"SELECT COALESCE(MAX(ID), {initOwnerID + QtyMin[3]}) FROM ITEMS WHERE `OWNER` = @NameParam AND `Type` = 'Cable'";
            maxIDs.Add((decimal)GetOwnerInfo.ExecuteScalar());
            GetOwnerInfo.CommandText = $"SELECT COALESCE(MAX(ID), {initOwnerID + QtyMin[4]}) FROM ITEMS WHERE `OWNER` = @NameParam AND `Type` = 'Game'";
            maxIDs.Add((decimal)GetOwnerInfo.ExecuteScalar());
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string[] typeNames = { "Console", "Controller", "Peripheral", "Cable", "Game" };
            if (ownerBox_unbound.SelectedItem != null && dataGridView1[0, e.RowIndex].Value == null && e.RowIndex >= currentPos)
            {
                ItemResult temp = (ItemResult)itemResultBindingSource.Current;
                for (int i = 0; i < typeNames.Length; i++)
                {
                    if (temp.TypeValue.Equals(typeNames[i]))
                    {
                        if ((maxIDs[i] + counters[i]) - initOwnerID > QtyMax[i])
                            MessageBox.Show($"This owner has exceeded the allowed number of {typeNames[i]}s!", "WARNING");
                        else if (maxIDs[i] + counters[i] == initOwnerID)
                        {
                            dataGridView1[0, e.RowIndex].Value = maxIDs[i];
                            counters[i]++;
                        }
                        else
                        {
                            dataGridView1[0, e.RowIndex].Value = maxIDs[i] + counters[i];
                            counters[i]++;
                        }
                        break;
                    }
                }
                currentPos++;
            }
            else if (e.RowIndex < currentPos)
            {
                currentPos = e.RowIndex;
            }
        }
    }
}
