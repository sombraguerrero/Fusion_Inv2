namespace GamingInventory_V2
{
    partial class addOwnerChild
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOwnerChild));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badgeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerCommit_btn = new System.Windows.Forms.Button();
            this.addOwnerClose = new System.Windows.Forms.Button();
            this.addResults_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.badgeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownerResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDNameDataGridViewTextBoxColumn
            // 
            this.iDNameDataGridViewTextBoxColumn.DataPropertyName = "IDName";
            this.iDNameDataGridViewTextBoxColumn.HeaderText = "Owner Name";
            this.iDNameDataGridViewTextBoxColumn.Name = "iDNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // badgeNameDataGridViewTextBoxColumn
            // 
            this.badgeNameDataGridViewTextBoxColumn.DataPropertyName = "BadgeName";
            this.badgeNameDataGridViewTextBoxColumn.HeaderText = "Badge Name";
            this.badgeNameDataGridViewTextBoxColumn.Name = "badgeNameDataGridViewTextBoxColumn";
            // 
            // ownerResultBindingSource
            // 
            this.ownerResultBindingSource.AllowNew = true;
            this.ownerResultBindingSource.DataSource = typeof(GamingInventory.OwnerResult);
            // 
            // ownerCommit_btn
            // 
            this.ownerCommit_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerCommit_btn.Location = new System.Drawing.Point(336, 268);
            this.ownerCommit_btn.Name = "ownerCommit_btn";
            this.ownerCommit_btn.Size = new System.Drawing.Size(236, 35);
            this.ownerCommit_btn.TabIndex = 1;
            this.ownerCommit_btn.Text = "Submit";
            this.ownerCommit_btn.UseVisualStyleBackColor = true;
            this.ownerCommit_btn.Click += new System.EventHandler(this.ownerCommit_btn_Click);
            // 
            // addOwnerClose
            // 
            this.addOwnerClose.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOwnerClose.Location = new System.Drawing.Point(578, 268);
            this.addOwnerClose.Name = "addOwnerClose";
            this.addOwnerClose.Size = new System.Drawing.Size(236, 35);
            this.addOwnerClose.TabIndex = 2;
            this.addOwnerClose.Text = "Close";
            this.addOwnerClose.UseVisualStyleBackColor = true;
            this.addOwnerClose.Click += new System.EventHandler(this.addOwnerClose_Click);
            // 
            // addResults_label
            // 
            this.addResults_label.AutoSize = true;
            this.addResults_label.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResults_label.Location = new System.Drawing.Point(12, 268);
            this.addResults_label.Name = "addResults_label";
            this.addResults_label.Size = new System.Drawing.Size(64, 23);
            this.addResults_label.TabIndex = 3;
            this.addResults_label.Text = "label1";
            this.addResults_label.Visible = false;
            // 
            // addOwnerChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 315);
            this.Controls.Add(this.addResults_label);
            this.Controls.Add(this.addOwnerClose);
            this.Controls.Add(this.ownerCommit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addOwnerChild";
            this.Text = "Add Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ownerResultBindingSource;
        private System.Windows.Forms.Button ownerCommit_btn;
        private System.Windows.Forms.Button addOwnerClose;
        private System.Windows.Forms.Label addResults_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badgeNameDataGridViewTextBoxColumn;
    }
}