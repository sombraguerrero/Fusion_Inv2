namespace GamingInventory_V2
{
    partial class UpdateItemsChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemsChild));
            this.OwnerCheck = new System.Windows.Forms.CheckBox();
            this.OwnerCombo = new System.Windows.Forms.ComboBox();
            this.IDCheck = new System.Windows.Forms.CheckBox();
            this.IDSpinner = new System.Windows.Forms.NumericUpDown();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.TypeCheck = new System.Windows.Forms.CheckBox();
            this.PlatformCombo = new System.Windows.Forms.ComboBox();
            this.PlatformCheck = new System.Windows.Forms.CheckBox();
            this.SerialText = new System.Windows.Forms.TextBox();
            this.SerialCheck = new System.Windows.Forms.CheckBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.DescriptionCheck = new System.Windows.Forms.CheckBox();
            this.findItems_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ownerValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckInValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckOutValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivedValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateItemsClose_btn = new System.Windows.Forms.Button();
            this.submitItemUpdates_btn = new System.Windows.Forms.Button();
            this.updateResults_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerCheck
            // 
            this.OwnerCheck.AutoSize = true;
            this.OwnerCheck.Checked = true;
            this.OwnerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OwnerCheck.Location = new System.Drawing.Point(163, 22);
            this.OwnerCheck.Name = "OwnerCheck";
            this.OwnerCheck.Size = new System.Drawing.Size(57, 17);
            this.OwnerCheck.TabIndex = 0;
            this.OwnerCheck.Text = "Owner";
            this.OwnerCheck.UseVisualStyleBackColor = true;
            this.OwnerCheck.CheckedChanged += new System.EventHandler(this.OwnerCheck_CheckedChanged);
            // 
            // OwnerCombo
            // 
            this.OwnerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerCombo.FormattingEnabled = true;
            this.OwnerCombo.Location = new System.Drawing.Point(162, 44);
            this.OwnerCombo.Name = "OwnerCombo";
            this.OwnerCombo.Size = new System.Drawing.Size(121, 21);
            this.OwnerCombo.TabIndex = 1;
            // 
            // IDCheck
            // 
            this.IDCheck.AutoSize = true;
            this.IDCheck.Checked = true;
            this.IDCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IDCheck.Location = new System.Drawing.Point(36, 22);
            this.IDCheck.Name = "IDCheck";
            this.IDCheck.Size = new System.Drawing.Size(37, 17);
            this.IDCheck.TabIndex = 2;
            this.IDCheck.Text = "ID";
            this.IDCheck.UseVisualStyleBackColor = true;
            this.IDCheck.CheckedChanged += new System.EventHandler(this.IDCheck_CheckedChanged);
            // 
            // IDSpinner
            // 
            this.IDSpinner.Location = new System.Drawing.Point(36, 45);
            this.IDSpinner.Maximum = new decimal(new int[] {
            99000,
            0,
            0,
            0});
            this.IDSpinner.Name = "IDSpinner";
            this.IDSpinner.Size = new System.Drawing.Size(120, 20);
            this.IDSpinner.TabIndex = 3;
            this.IDSpinner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDSpinner_KeyPress);
            // 
            // TypeCombo
            // 
            this.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Console",
            "Game",
            "Peripheral",
            "Controller",
            "Cable"});
            this.TypeCombo.Location = new System.Drawing.Point(289, 44);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 4;
            // 
            // TypeCheck
            // 
            this.TypeCheck.AutoSize = true;
            this.TypeCheck.Checked = true;
            this.TypeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeCheck.Location = new System.Drawing.Point(289, 22);
            this.TypeCheck.Name = "TypeCheck";
            this.TypeCheck.Size = new System.Drawing.Size(50, 17);
            this.TypeCheck.TabIndex = 5;
            this.TypeCheck.Text = "Type";
            this.TypeCheck.UseVisualStyleBackColor = true;
            this.TypeCheck.CheckedChanged += new System.EventHandler(this.TypeCheck_CheckedChanged);
            // 
            // PlatformCombo
            // 
            this.PlatformCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlatformCombo.FormattingEnabled = true;
            this.PlatformCombo.Location = new System.Drawing.Point(416, 44);
            this.PlatformCombo.Name = "PlatformCombo";
            this.PlatformCombo.Size = new System.Drawing.Size(121, 21);
            this.PlatformCombo.TabIndex = 6;
            // 
            // PlatformCheck
            // 
            this.PlatformCheck.AutoSize = true;
            this.PlatformCheck.Checked = true;
            this.PlatformCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlatformCheck.Location = new System.Drawing.Point(416, 22);
            this.PlatformCheck.Name = "PlatformCheck";
            this.PlatformCheck.Size = new System.Drawing.Size(64, 17);
            this.PlatformCheck.TabIndex = 7;
            this.PlatformCheck.Text = "Platform";
            this.PlatformCheck.UseVisualStyleBackColor = true;
            this.PlatformCheck.CheckedChanged += new System.EventHandler(this.PlatformCheck_CheckedChanged);
            // 
            // SerialText
            // 
            this.SerialText.Location = new System.Drawing.Point(543, 44);
            this.SerialText.Name = "SerialText";
            this.SerialText.Size = new System.Drawing.Size(160, 20);
            this.SerialText.TabIndex = 8;
            this.SerialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialText_KeyPress);
            // 
            // SerialCheck
            // 
            this.SerialCheck.AutoSize = true;
            this.SerialCheck.Checked = true;
            this.SerialCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SerialCheck.Location = new System.Drawing.Point(543, 22);
            this.SerialCheck.Name = "SerialCheck";
            this.SerialCheck.Size = new System.Drawing.Size(77, 17);
            this.SerialCheck.TabIndex = 9;
            this.SerialCheck.Text = "Serial/Title";
            this.SerialCheck.UseVisualStyleBackColor = true;
            this.SerialCheck.CheckedChanged += new System.EventHandler(this.SerialCheck_CheckedChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(709, 44);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(160, 20);
            this.DescriptionText.TabIndex = 10;
            this.DescriptionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionText_KeyPress);
            // 
            // DescriptionCheck
            // 
            this.DescriptionCheck.AutoSize = true;
            this.DescriptionCheck.Checked = true;
            this.DescriptionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DescriptionCheck.Location = new System.Drawing.Point(709, 22);
            this.DescriptionCheck.Name = "DescriptionCheck";
            this.DescriptionCheck.Size = new System.Drawing.Size(79, 17);
            this.DescriptionCheck.TabIndex = 11;
            this.DescriptionCheck.Text = "Description";
            this.DescriptionCheck.UseVisualStyleBackColor = true;
            this.DescriptionCheck.CheckedChanged += new System.EventHandler(this.DescriptionCheck_CheckedChanged);
            // 
            // findItems_btn
            // 
            this.findItems_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findItems_btn.Location = new System.Drawing.Point(875, 22);
            this.findItems_btn.Name = "findItems_btn";
            this.findItems_btn.Size = new System.Drawing.Size(187, 42);
            this.findItems_btn.TabIndex = 12;
            this.findItems_btn.Text = "Lookup Items";
            this.findItems_btn.UseVisualStyleBackColor = true;
            this.findItems_btn.Click += new System.EventHandler(this.findItems_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerValueDataGridViewTextBoxColumn,
            this.iDValueDataGridViewTextBoxColumn,
            this.typeValueDataGridViewTextBoxColumn,
            this.platformValueDataGridViewTextBoxColumn,
            this.serialValueDataGridViewTextBoxColumn,
            this.descriptionValueDataGridViewTextBoxColumn,
            this.lastCheckInValueDataGridViewTextBoxColumn,
            this.lastCheckOutValueDataGridViewTextBoxColumn,
            this.archivedValueDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.itemResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 309);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ownerValueDataGridViewTextBoxColumn
            // 
            this.ownerValueDataGridViewTextBoxColumn.DataPropertyName = "OwnerValue";
            this.ownerValueDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerValueDataGridViewTextBoxColumn.Name = "ownerValueDataGridViewTextBoxColumn";
            this.ownerValueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ownerValueDataGridViewTextBoxColumn.Width = 112;
            // 
            // iDValueDataGridViewTextBoxColumn
            // 
            this.iDValueDataGridViewTextBoxColumn.DataPropertyName = "IDValue";
            this.iDValueDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDValueDataGridViewTextBoxColumn.Name = "iDValueDataGridViewTextBoxColumn";
            this.iDValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDValueDataGridViewTextBoxColumn.Width = 111;
            // 
            // typeValueDataGridViewTextBoxColumn
            // 
            this.typeValueDataGridViewTextBoxColumn.DataPropertyName = "TypeValue";
            this.typeValueDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeValueDataGridViewTextBoxColumn.Name = "typeValueDataGridViewTextBoxColumn";
            this.typeValueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeValueDataGridViewTextBoxColumn.Width = 112;
            // 
            // platformValueDataGridViewTextBoxColumn
            // 
            this.platformValueDataGridViewTextBoxColumn.DataPropertyName = "PlatformValue";
            this.platformValueDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformValueDataGridViewTextBoxColumn.Name = "platformValueDataGridViewTextBoxColumn";
            this.platformValueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.platformValueDataGridViewTextBoxColumn.Width = 111;
            // 
            // serialValueDataGridViewTextBoxColumn
            // 
            this.serialValueDataGridViewTextBoxColumn.DataPropertyName = "SerialValue";
            this.serialValueDataGridViewTextBoxColumn.HeaderText = "Serial/Title";
            this.serialValueDataGridViewTextBoxColumn.Name = "serialValueDataGridViewTextBoxColumn";
            this.serialValueDataGridViewTextBoxColumn.Width = 112;
            // 
            // descriptionValueDataGridViewTextBoxColumn
            // 
            this.descriptionValueDataGridViewTextBoxColumn.DataPropertyName = "DescriptionValue";
            this.descriptionValueDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionValueDataGridViewTextBoxColumn.Name = "descriptionValueDataGridViewTextBoxColumn";
            this.descriptionValueDataGridViewTextBoxColumn.Width = 111;
            // 
            // lastCheckInValueDataGridViewTextBoxColumn
            // 
            this.lastCheckInValueDataGridViewTextBoxColumn.DataPropertyName = "LastCheckInValue";
            this.lastCheckInValueDataGridViewTextBoxColumn.HeaderText = "LastCheckIn";
            this.lastCheckInValueDataGridViewTextBoxColumn.Name = "lastCheckInValueDataGridViewTextBoxColumn";
            this.lastCheckInValueDataGridViewTextBoxColumn.Width = 112;
            // 
            // lastCheckOutValueDataGridViewTextBoxColumn
            // 
            this.lastCheckOutValueDataGridViewTextBoxColumn.DataPropertyName = "LastCheckOutValue";
            this.lastCheckOutValueDataGridViewTextBoxColumn.HeaderText = "LastCheckOut";
            this.lastCheckOutValueDataGridViewTextBoxColumn.Name = "lastCheckOutValueDataGridViewTextBoxColumn";
            this.lastCheckOutValueDataGridViewTextBoxColumn.Width = 111;
            // 
            // archivedValueDataGridViewCheckBoxColumn
            // 
            this.archivedValueDataGridViewCheckBoxColumn.DataPropertyName = "ArchivedValue";
            this.archivedValueDataGridViewCheckBoxColumn.HeaderText = "Archived";
            this.archivedValueDataGridViewCheckBoxColumn.Name = "archivedValueDataGridViewCheckBoxColumn";
            this.archivedValueDataGridViewCheckBoxColumn.Width = 112;
            // 
            // itemResultBindingSource
            // 
            this.itemResultBindingSource.DataSource = typeof(GamingInventory_V2.ItemResult);
            // 
            // updateItemsClose_btn
            // 
            this.updateItemsClose_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemsClose_btn.Location = new System.Drawing.Point(709, 394);
            this.updateItemsClose_btn.Name = "updateItemsClose_btn";
            this.updateItemsClose_btn.Size = new System.Drawing.Size(187, 42);
            this.updateItemsClose_btn.TabIndex = 14;
            this.updateItemsClose_btn.Text = "Close";
            this.updateItemsClose_btn.UseVisualStyleBackColor = true;
            this.updateItemsClose_btn.Click += new System.EventHandler(this.updateItemsClose_btn_Click);
            // 
            // submitItemUpdates_btn
            // 
            this.submitItemUpdates_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitItemUpdates_btn.Location = new System.Drawing.Point(516, 394);
            this.submitItemUpdates_btn.Name = "submitItemUpdates_btn";
            this.submitItemUpdates_btn.Size = new System.Drawing.Size(187, 42);
            this.submitItemUpdates_btn.TabIndex = 15;
            this.submitItemUpdates_btn.Text = "Submit";
            this.submitItemUpdates_btn.UseVisualStyleBackColor = true;
            this.submitItemUpdates_btn.Click += new System.EventHandler(this.submitItemUpdates_btn_Click);
            // 
            // updateResults_label
            // 
            this.updateResults_label.AutoSize = true;
            this.updateResults_label.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateResults_label.Location = new System.Drawing.Point(31, 394);
            this.updateResults_label.Name = "updateResults_label";
            this.updateResults_label.Size = new System.Drawing.Size(356, 30);
            this.updateResults_label.TabIndex = 16;
            this.updateResults_label.Text = "0 Items Updated Successfully";
            this.updateResults_label.Visible = false;
            // 
            // UpdateItemsChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 437);
            this.Controls.Add(this.updateResults_label);
            this.Controls.Add(this.submitItemUpdates_btn);
            this.Controls.Add(this.updateItemsClose_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findItems_btn);
            this.Controls.Add(this.DescriptionCheck);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.SerialCheck);
            this.Controls.Add(this.SerialText);
            this.Controls.Add(this.PlatformCheck);
            this.Controls.Add(this.PlatformCombo);
            this.Controls.Add(this.TypeCheck);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.IDSpinner);
            this.Controls.Add(this.IDCheck);
            this.Controls.Add(this.OwnerCombo);
            this.Controls.Add(this.OwnerCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateItemsChild";
            this.Text = "Update Items";
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OwnerCheck;
        private System.Windows.Forms.ComboBox OwnerCombo;
        private System.Windows.Forms.CheckBox IDCheck;
        private System.Windows.Forms.NumericUpDown IDSpinner;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.CheckBox TypeCheck;
        private System.Windows.Forms.ComboBox PlatformCombo;
        private System.Windows.Forms.CheckBox PlatformCheck;
        private System.Windows.Forms.TextBox SerialText;
        private System.Windows.Forms.CheckBox SerialCheck;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.CheckBox DescriptionCheck;
        private System.Windows.Forms.Button findItems_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateItemsClose_btn;
        private System.Windows.Forms.Button submitItemUpdates_btn;
        private System.Windows.Forms.Label updateResults_label;
        private System.Windows.Forms.BindingSource itemResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckInValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckOutValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn archivedValueDataGridViewCheckBoxColumn;
    }
}