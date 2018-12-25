using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace GamingInventory_V2
{
    public partial class ImportCSV : Form
    {
        public ImportCSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                progressBar1.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((!(radioButton1.Checked || radioButton2.Checked)) || textBox1.Text == string.Empty)
            {
                MessageBox.Show("Destination table and file path must be specified.", "Action Required");
            }
            else if (radioButton1.Checked)
            {
                ImportOwners();
            }
            else
            {
                ImportItems();
            }
        }

        private void ImportOwners()
        {
            List<OwnerResult> owners = new List<OwnerResult>();
            using(StreamReader ownerReader = new StreamReader(openFileDialog1.FileName))
            {
                string[] parts = ownerReader.ReadLine().Split(',');
                if (ValidateOwnerCSV(parts))
                {
                    while (!ownerReader.EndOfStream)
                    {
                        parts = ownerReader.ReadLine().Split(',');
                        owners.Add(new OwnerResult(decimal.Parse(parts[0]), parts[4], parts[3], parts[2], parts[1], 0));
                    }
                    progressBar1.Maximum = owners.Count;
                }
                else
                {
                    MessageBox.Show("CSV headers do not mach expected order! (ID, Name, Phone, Email, BadgeName)", "Warning");
                }
            }
            if (owners.Count > 0)
            {
                foreach (OwnerResult owner in owners)
                {
                    owner.Insert(Form1.MasterConnection);
                    progressBar1.PerformStep();
                }
            }
        }

        private void ImportItems()
        {
            List<ItemResult> items = new List<ItemResult>();
            using (StreamReader itemReader = new StreamReader(openFileDialog1.FileName))
            {
                string[] parts = itemReader.ReadLine().Split(',');
                if (ValidateItemCSV(parts))
                {
                    while (!itemReader.EndOfStream)
                    {
                        parts = itemReader.ReadLine().Split(',');
                        items.Add(new ItemResult(parts[0], decimal.Parse(parts[1]), parts[2], parts[3], parts[4], parts[5], string.Empty));
                    }
                    progressBar1.Maximum = items.Count;
                }
                else
                {
                    MessageBox.Show("CSV headers do not mach expected order! (Owner, ID, Type, Platform, Serial, Description)", "Warning");
                }
            }
            if (items.Count > 0)
            {
                foreach (ItemResult item in items)
                {
                    item.Insert(Form1.MasterConnection);
                    progressBar1.PerformStep();
                }
            }
        }

        private bool ValidateOwnerCSV(string[] s)
        {
            string[] headers = { "ID".ToUpper(), "Name".ToUpper(), "Phone".ToUpper(), "Email".ToUpper(), "BadgeName".ToUpper() };
            return s[0].ToUpper() == headers[0] && s[1].ToUpper() == headers[1] && s[2].ToUpper() == headers[2] && s[3].ToUpper() == headers[3] && s[4].ToUpper() == headers[4];
        }

        private bool ValidateItemCSV(string[] s)
        {
            string[] headers = { "Owner".ToUpper(), "ID".ToUpper(), "Type".ToUpper(), "Platform".ToUpper(), "Serial".ToUpper(), "Description".ToUpper() };
            return s[0].ToUpper() == headers[0] && s[1].ToUpper() == headers[1] && s[2].ToUpper() == headers[2] && s[3].ToUpper() == headers[3] && s[4].ToUpper() == headers[4] && s[5].ToUpper() == headers[5];
        }
    }
}
