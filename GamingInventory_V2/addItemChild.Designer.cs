namespace GamingInventory_V2
{
    partial class addItemChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItemChild));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.platformValueDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeAddItem_btn = new System.Windows.Forms.Button();
            this.submitaddedItems_btn = new System.Windows.Forms.Button();
            this.addItemResults_label = new System.Windows.Forms.Label();
            this.ownerBox_unbound = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.platformValueDataGridViewComboBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.itemResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1203, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // ID
            // 
            this.ID.HeaderText = "New ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDValue";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDValue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeValue";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeValue";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Console",
            "Game",
            "Peripheral",
            "Controller",
            "Cable"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // platformValueDataGridViewComboBoxColumn
            // 
            this.platformValueDataGridViewComboBoxColumn.DataPropertyName = "PlatformValue";
            this.platformValueDataGridViewComboBoxColumn.HeaderText = "PlatformValue";
            this.platformValueDataGridViewComboBoxColumn.Name = "platformValueDataGridViewComboBoxColumn";
            this.platformValueDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.platformValueDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SerialValue";
            this.dataGridViewTextBoxColumn5.HeaderText = "SerialValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DescriptionValue";
            this.dataGridViewTextBoxColumn6.HeaderText = "DescriptionValue";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // itemResultBindingSource
            // 
            this.itemResultBindingSource.AllowNew = true;
            this.itemResultBindingSource.DataSource = typeof(GamingInventory_V2.ItemResult);
            // 
            // closeAddItem_btn
            // 
            this.closeAddItem_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeAddItem_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAddItem_btn.Location = new System.Drawing.Point(1048, 342);
            this.closeAddItem_btn.Name = "closeAddItem_btn";
            this.closeAddItem_btn.Size = new System.Drawing.Size(185, 40);
            this.closeAddItem_btn.TabIndex = 1;
            this.closeAddItem_btn.Text = "Close";
            this.closeAddItem_btn.UseVisualStyleBackColor = true;
            this.closeAddItem_btn.Click += new System.EventHandler(this.closeAddItem_btn_Click);
            // 
            // submitaddedItems_btn
            // 
            this.submitaddedItems_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitaddedItems_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitaddedItems_btn.Location = new System.Drawing.Point(857, 342);
            this.submitaddedItems_btn.Name = "submitaddedItems_btn";
            this.submitaddedItems_btn.Size = new System.Drawing.Size(185, 40);
            this.submitaddedItems_btn.TabIndex = 2;
            this.submitaddedItems_btn.Text = "Submit";
            this.submitaddedItems_btn.UseVisualStyleBackColor = true;
            this.submitaddedItems_btn.Click += new System.EventHandler(this.submitaddedItems_btn_Click);
            // 
            // addItemResults_label
            // 
            this.addItemResults_label.AutoSize = true;
            this.addItemResults_label.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemResults_label.Location = new System.Drawing.Point(7, 359);
            this.addItemResults_label.Name = "addItemResults_label";
            this.addItemResults_label.Size = new System.Drawing.Size(83, 30);
            this.addItemResults_label.TabIndex = 3;
            this.addItemResults_label.Text = "label1";
            this.addItemResults_label.Visible = false;
            // 
            // ownerBox_unbound
            // 
            this.ownerBox_unbound.FormattingEnabled = true;
            this.ownerBox_unbound.Location = new System.Drawing.Point(303, 34);
            this.ownerBox_unbound.Name = "ownerBox_unbound";
            this.ownerBox_unbound.Size = new System.Drawing.Size(197, 21);
            this.ownerBox_unbound.TabIndex = 4;
            this.ownerBox_unbound.SelectionChangeCommitted += new System.EventHandler(this.ownerBox_unbound_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(360, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Owner";
            // 
            // addItemChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1326, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ownerBox_unbound);
            this.Controls.Add(this.addItemResults_label);
            this.Controls.Add(this.submitaddedItems_btn);
            this.Controls.Add(this.closeAddItem_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addItemChild";
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemResultBindingSource;
        private System.Windows.Forms.Button closeAddItem_btn;
        private System.Windows.Forms.Button submitaddedItems_btn;
        private System.Windows.Forms.Label addItemResults_label;
        private System.Windows.Forms.ComboBox ownerBox_unbound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn platformValueDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}