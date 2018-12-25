﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Collections;

namespace GamingInventory_V2
{
    public partial class UpdateItemsChild : Form
    {
        ArrayList dirtyRows;

        public UpdateItemsChild()
        {
            InitializeComponent();
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
            string query;
            MySqlCommand SelectItemsToUpdate = new MySqlCommand();
            MySqlDataReader ReadItemsToUpdate = null;

            dirtyRows.Clear();
            itemResultBindingSource.Clear();
            ItemResult ItemToSelect = new ItemResult();
            GetValidFields(ItemToSelect);
            query = ItemToSelect.BuildSelectQuery(SelectItemsToUpdate, false, IDSpinner.Enabled, OwnerCombo.Enabled, PlatformCombo.Enabled, SerialText.Enabled, TypeCombo.Enabled, DescriptionText.Enabled);
            if (!query.Equals(string.Empty))
            {
                SelectItemsToUpdate.CommandText = query;
                SelectItemsToUpdate.Connection = Form1.MasterConnection;
                ReadItemsToUpdate = SelectItemsToUpdate.ExecuteReader();
                while (ReadItemsToUpdate.Read() && ReadItemsToUpdate != null)
                {
                    itemResultBindingSource.Add(new ItemResult(ReadItemsToUpdate.GetString("Owner"), ReadItemsToUpdate.GetInt32("ID"), ReadItemsToUpdate.GetString("Type"), ReadItemsToUpdate.GetString("Platform"), ReadItemsToUpdate.GetString("Serial"), ReadItemsToUpdate.GetString("Description"), ReadItemsToUpdate.GetString("LastCheckIn"), ReadItemsToUpdate.GetString("LastCheckout"), false));
                }
                ReadItemsToUpdate.Close();
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
                UpdateItem = itemResultBindingSource[r] as ItemResult;
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
