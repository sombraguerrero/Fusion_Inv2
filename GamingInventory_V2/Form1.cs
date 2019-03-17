﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.IO;

namespace GamingInventory_V2
{
    public partial class Form1 : Form
    {
        public static MySqlConnection MasterConnection { get; } = new MySqlConnection();

        public Form1()
        {
            InitializeComponent();
            //EncryptConnectionString();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text += $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

            MasterConnection.ConnectionString = DecryptConnectionString();
            if (!MasterConnection.ConnectionString.Contains("localhost"))
            {
                exportBtn.Enabled = false;
                importBtn.Enabled = false;
            }
            try
            {
                MasterConnection.Open();
                MySqlCommand initFlag = new MySqlCommand("select count(*) from configs", MasterConnection);
                object o = initFlag.ExecuteScalar();
                if (o == null || (long)o == 0)
                {
                    initFlag.CommandText = "insert into configs values ();";
                    initFlag.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(string.Format("Error Code: {0}; Source {1}; Message: {2}", ex.ErrorCode, ex.Source, ex.Message));
            }
        }

        static string DecryptConnectionString()
        {
            byte[] encConnString = File.ReadAllBytes(@"enc\conn.dat");
            using (Aes FusionAES = Aes.Create())
            {
                FusionAES.Key = File.ReadAllBytes(@"enc\key.dat");
                FusionAES.IV = File.ReadAllBytes(@"enc\iv.dat");
                return DecryptStringFromBytes_Aes(encConnString, FusionAES.Key, FusionAES.IV);
            }
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        /***
        private void EncryptConnectionString()
        {
            Configuration configuration = null;
            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                configuration = ConfigurationManager.OpenExeConfiguration("Fusion_Inventory.exe");
                ConnectionStringsSection configSection =
                configuration.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(configSection.ElementInformation.IsLocked)) &&
                    (!(configSection.SectionInformation.IsLocked)))
                {
                    if (!configSection.SectionInformation.IsProtected)
                    {
                        //this line will encrypt the file
                        configSection.SectionInformation.ProtectSection(string.Empty);
                    }
                    //re-save the configuration file section
                    configSection.SectionInformation.ForceSave = true;
                    // Save the current configuration
                    configuration.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Error");
            }
        }
        ***/

        private void addOwner_btn_Click(object sender, EventArgs e)
        {
            addOwnerChild AddingOwner = new addOwnerChild();
            AddingOwner.Show();
        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {
            addItemChild AddingItems = new addItemChild();
            AddingItems.Show();
        }

        private void updateOwner_btn_Click(object sender, EventArgs e)
        {
            UpdateOwnerChild UpdatingOwner = new UpdateOwnerChild();
            UpdatingOwner.Show();
        }

        private void updateOwner_btn_Click_1(object sender, EventArgs e)
        {
            UpdateOwnerChild UpdatingOwner;
            UpdatingOwner = new UpdateOwnerChild();
            UpdatingOwner.Show();
        }

        private void updateItem_btn_Click(object sender, EventArgs e)
        {
            UpdateItemsChild UpdatingItems = new UpdateItemsChild();
            UpdatingItems.Show();
        }

        private void searchOwner_btn_Click(object sender, EventArgs e)
        {
            SearchOwners OwnerSearch = new SearchOwners();
            OwnerSearch.Show();
        }

        private void addOwner_btn_Click_1(object sender, EventArgs e)
        {
            addOwnerChild AddingOwner = new addOwnerChild();
            AddingOwner.Show();
        }

        private void addItem_btn_Click_1(object sender, EventArgs e)
        {
            addItemChild AddingItems = new addItemChild();
            AddingItems.Show();
        }

        private void searchItems_btn_Click(object sender, EventArgs e)
        {
            SearchItems SearchingItems = new SearchItems();
            SearchingItems.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsageChild MyReports = new UsageChild();
            MyReports.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GamesByPlatform GamesReport = new GamesByPlatform();
            GamesReport.Show();
        }

        private void itemsAudit_btn_Click(object sender, EventArgs e)
        {
            ItemsAudit AuditItems = new ItemsAudit();
            AuditItems.Show();
        }

        private void exportBtn_Click_2(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Process Dump = new Process();
                Dump.StartInfo.WorkingDirectory = "MariaDB\\bin\\";
                Dump.StartInfo.FileName = "mysqldump";
                string dest = saveFileDialog1.FileName;
                Dump.StartInfo.Arguments = string.Format("--add-drop-database --routines --result-file=\"{0}\" -ufusion -p gaminginv", dest);
                Dump.Start();
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will OVERWRITE the currently active database! Please confirm.", "Confirm Action", MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Process Import = new Process();
                    Import.StartInfo.WorkingDirectory = "MariaDB\\bin\\";
                    Import.StartInfo.FileName = "mysql";
                    string dest = openFileDialog1.FileName;
                    Import.StartInfo.Arguments = string.Format("-ufusion -p gaminginv -e \"\\. {0}\"", dest);
                    Import.Start();
                }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MasterConnection.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = MasterConnection;
            string s = Microsoft.VisualBasic.Interaction.InputBox("Platform to add (multiples separated with commas):", "Add a Platform");
            if (!s.Equals(string.Empty))
            {
                s = s.Insert(0, ",");
                mySqlCommand.CommandText = "UPDATE configs set Platforms = concat(Platforms, @added_platform);";
                mySqlCommand.Parameters.AddWithValue("@added_platform", s);
                mySqlCommand.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportCSV importCSVForm = new ImportCSV();
            importCSVForm.Show();
        }
    }
}
