namespace GamingInventory_V2
{
    partial class UpdateOwnerChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOwnerChild));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badgeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateOwnerClose_btn = new System.Windows.Forms.Button();
            this.submitUpdateOwner_btn = new System.Windows.Forms.Button();
            this.updateSuccess_label = new System.Windows.Forms.Label();
            this.updateOwnerBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner to Update";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 56);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDNameDataGridViewTextBoxColumn
            // 
            this.iDNameDataGridViewTextBoxColumn.DataPropertyName = "IDName";
            this.iDNameDataGridViewTextBoxColumn.HeaderText = "IDName";
            this.iDNameDataGridViewTextBoxColumn.Name = "iDNameDataGridViewTextBoxColumn";
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // badgeNameDataGridViewTextBoxColumn
            // 
            this.badgeNameDataGridViewTextBoxColumn.DataPropertyName = "BadgeName";
            this.badgeNameDataGridViewTextBoxColumn.HeaderText = "BadgeName";
            this.badgeNameDataGridViewTextBoxColumn.Name = "badgeNameDataGridViewTextBoxColumn";
            // 
            // itemQtyDataGridViewTextBoxColumn
            // 
            this.itemQtyDataGridViewTextBoxColumn.DataPropertyName = "ItemQty";
            this.itemQtyDataGridViewTextBoxColumn.HeaderText = "ItemQty";
            this.itemQtyDataGridViewTextBoxColumn.Name = "itemQtyDataGridViewTextBoxColumn";
            // 
            // ownerResultBindingSource
            // 
            this.ownerResultBindingSource.AllowNew = false;
            this.ownerResultBindingSource.DataSource = typeof(GamingInventory.OwnerResult);
            // 
            // updateOwnerClose_btn
            // 
            this.updateOwnerClose_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOwnerClose_btn.Location = new System.Drawing.Point(610, 107);
            this.updateOwnerClose_btn.Name = "updateOwnerClose_btn";
            this.updateOwnerClose_btn.Size = new System.Drawing.Size(152, 39);
            this.updateOwnerClose_btn.TabIndex = 3;
            this.updateOwnerClose_btn.Text = "Close";
            this.updateOwnerClose_btn.UseVisualStyleBackColor = true;
            this.updateOwnerClose_btn.Click += new System.EventHandler(this.updateOwnerClose_btn_Click);
            // 
            // submitUpdateOwner_btn
            // 
            this.submitUpdateOwner_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdateOwner_btn.Location = new System.Drawing.Point(452, 107);
            this.submitUpdateOwner_btn.Name = "submitUpdateOwner_btn";
            this.submitUpdateOwner_btn.Size = new System.Drawing.Size(152, 39);
            this.submitUpdateOwner_btn.TabIndex = 4;
            this.submitUpdateOwner_btn.Text = "Submit";
            this.submitUpdateOwner_btn.UseVisualStyleBackColor = true;
            this.submitUpdateOwner_btn.Click += new System.EventHandler(this.submitUpdateOwner_btn_Click);
            // 
            // updateSuccess_label
            // 
            this.updateSuccess_label.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSuccess_label.Location = new System.Drawing.Point(12, 107);
            this.updateSuccess_label.Name = "updateSuccess_label";
            this.updateSuccess_label.Size = new System.Drawing.Size(434, 39);
            this.updateSuccess_label.TabIndex = 5;
            this.updateSuccess_label.Text = "label2";
            this.updateSuccess_label.Visible = false;
            // 
            // updateOwnerBox
            // 
            this.updateOwnerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateOwnerBox.FormattingEnabled = true;
            this.updateOwnerBox.Location = new System.Drawing.Point(106, 6);
            this.updateOwnerBox.Name = "updateOwnerBox";
            this.updateOwnerBox.Size = new System.Drawing.Size(121, 21);
            this.updateOwnerBox.TabIndex = 6;
            this.updateOwnerBox.SelectedIndexChanged += new System.EventHandler(this.updateOwnerBox_SelectedIndexChanged);
            // 
            // UpdateOwnerChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 158);
            this.Controls.Add(this.updateOwnerBox);
            this.Controls.Add(this.updateSuccess_label);
            this.Controls.Add(this.submitUpdateOwner_btn);
            this.Controls.Add(this.updateOwnerClose_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateOwnerChild";
            this.Text = "Update Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox updateOwnerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ownerResultBindingSource;
        private System.Windows.Forms.Button updateOwnerClose_btn;
        private System.Windows.Forms.Button submitUpdateOwner_btn;
        private System.Windows.Forms.Label updateSuccess_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badgeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQtyDataGridViewTextBoxColumn;
    }
}