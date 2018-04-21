namespace GamingInventory_V2
{
    partial class SearchOwners
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOwners));
            this.ownerSelection_box = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badgeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerSelection_box
            // 
            this.ownerSelection_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerSelection_box.FormattingEnabled = true;
            this.ownerSelection_box.Items.AddRange(new object[] {
            "Select an Owner"});
            this.ownerSelection_box.Location = new System.Drawing.Point(342, 12);
            this.ownerSelection_box.Name = "ownerSelection_box";
            this.ownerSelection_box.Size = new System.Drawing.Size(161, 21);
            this.ownerSelection_box.TabIndex = 0;
            this.ownerSelection_box.SelectedIndexChanged += new System.EventHandler(this.ownerSelection_box_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNameDataGridViewTextBoxColumn,
            this.ownerIDDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.badgeNameDataGridViewTextBoxColumn,
            this.itemQtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownerResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 59);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDNameDataGridViewTextBoxColumn
            // 
            this.iDNameDataGridViewTextBoxColumn.DataPropertyName = "IDName";
            this.iDNameDataGridViewTextBoxColumn.HeaderText = "IDName";
            this.iDNameDataGridViewTextBoxColumn.Name = "iDNameDataGridViewTextBoxColumn";
            this.iDNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // badgeNameDataGridViewTextBoxColumn
            // 
            this.badgeNameDataGridViewTextBoxColumn.DataPropertyName = "BadgeName";
            this.badgeNameDataGridViewTextBoxColumn.HeaderText = "BadgeName";
            this.badgeNameDataGridViewTextBoxColumn.Name = "badgeNameDataGridViewTextBoxColumn";
            this.badgeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemQtyDataGridViewTextBoxColumn
            // 
            this.itemQtyDataGridViewTextBoxColumn.DataPropertyName = "ItemQty";
            this.itemQtyDataGridViewTextBoxColumn.HeaderText = "ItemQty";
            this.itemQtyDataGridViewTextBoxColumn.Name = "itemQtyDataGridViewTextBoxColumn";
            this.itemQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerResultBindingSource
            // 
            this.ownerResultBindingSource.AllowNew = false;
            this.ownerResultBindingSource.DataSource = typeof(GamingInventory_V2.OwnerResult);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ownerSelection_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchOwners";
            this.Text = "Search Owners";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ownerSelection_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ownerResultBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badgeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQtyDataGridViewTextBoxColumn;
    }
}