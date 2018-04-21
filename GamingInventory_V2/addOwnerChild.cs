using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamingInventory_V2
{
    public partial class addOwnerChild : Form
    {

        public addOwnerChild()
        {
            InitializeComponent();
            HScroll = true;
            addResults_label.ForeColor = Color.Green;
        }

        private void ownerCommit_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach  (OwnerResult r in ownerResultBindingSource.List)
            {
                r.Insert(Form1.MasterConnection);
                count++;
            }
            addResults_label.Text = count + " owners added successfully!";
            addResults_label.Show();
        }

        private void addOwnerClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
