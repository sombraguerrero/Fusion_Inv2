﻿namespace GamingInventory_V2
{
    partial class SearchItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchItems));
            this.findItems_btn = new System.Windows.Forms.Button();
            this.DescriptionCheck = new System.Windows.Forms.CheckBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.SerialCheck = new System.Windows.Forms.CheckBox();
            this.SerialText = new System.Windows.Forms.TextBox();
            this.PlatformCheck = new System.Windows.Forms.CheckBox();
            this.PlatformCombo = new System.Windows.Forms.ComboBox();
            this.TypeCheck = new System.Windows.Forms.CheckBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.IDSpinner = new System.Windows.Forms.NumericUpDown();
            this.IDCheck = new System.Windows.Forms.CheckBox();
            this.OwnerCombo = new System.Windows.Forms.ComboBox();
            this.OwnerCheck = new System.Windows.Forms.CheckBox();
            this.resultsTabs_ctrl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.archiveCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinner)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findItems_btn
            // 
            this.findItems_btn.AutoSize = true;
            this.findItems_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findItems_btn.Location = new System.Drawing.Point(744, 356);
            this.findItems_btn.Name = "findItems_btn";
            this.findItems_btn.Size = new System.Drawing.Size(187, 42);
            this.findItems_btn.TabIndex = 25;
            this.findItems_btn.Text = "Lookup Items";
            this.findItems_btn.UseVisualStyleBackColor = true;
            this.findItems_btn.Click += new System.EventHandler(this.findItems_btn_Click);
            // 
            // DescriptionCheck
            // 
            this.DescriptionCheck.AutoSize = true;
            this.DescriptionCheck.Checked = true;
            this.DescriptionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DescriptionCheck.Location = new System.Drawing.Point(677, 10);
            this.DescriptionCheck.Name = "DescriptionCheck";
            this.DescriptionCheck.Size = new System.Drawing.Size(79, 17);
            this.DescriptionCheck.TabIndex = 24;
            this.DescriptionCheck.Text = "Description";
            this.DescriptionCheck.UseVisualStyleBackColor = true;
            this.DescriptionCheck.CheckedChanged += new System.EventHandler(this.DescriptionCheck_CheckedChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(677, 32);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(160, 20);
            this.DescriptionText.TabIndex = 23;
            this.DescriptionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionText_KeyPress);
            // 
            // SerialCheck
            // 
            this.SerialCheck.AutoSize = true;
            this.SerialCheck.Checked = true;
            this.SerialCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SerialCheck.Location = new System.Drawing.Point(511, 10);
            this.SerialCheck.Name = "SerialCheck";
            this.SerialCheck.Size = new System.Drawing.Size(77, 17);
            this.SerialCheck.TabIndex = 22;
            this.SerialCheck.Text = "Serial/Title";
            this.SerialCheck.UseVisualStyleBackColor = true;
            this.SerialCheck.CheckedChanged += new System.EventHandler(this.SerialCheck_CheckedChanged);
            // 
            // SerialText
            // 
            this.SerialText.Location = new System.Drawing.Point(511, 32);
            this.SerialText.Name = "SerialText";
            this.SerialText.Size = new System.Drawing.Size(160, 20);
            this.SerialText.TabIndex = 21;
            this.SerialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialText_KeyPress);
            // 
            // PlatformCheck
            // 
            this.PlatformCheck.AutoSize = true;
            this.PlatformCheck.Checked = true;
            this.PlatformCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlatformCheck.Location = new System.Drawing.Point(384, 10);
            this.PlatformCheck.Name = "PlatformCheck";
            this.PlatformCheck.Size = new System.Drawing.Size(64, 17);
            this.PlatformCheck.TabIndex = 20;
            this.PlatformCheck.Text = "Platform";
            this.PlatformCheck.UseVisualStyleBackColor = true;
            this.PlatformCheck.CheckedChanged += new System.EventHandler(this.PlatformCheck_CheckedChanged);
            // 
            // PlatformCombo
            // 
            this.PlatformCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlatformCombo.FormattingEnabled = true;
            this.PlatformCombo.Location = new System.Drawing.Point(384, 32);
            this.PlatformCombo.Name = "PlatformCombo";
            this.PlatformCombo.Size = new System.Drawing.Size(121, 21);
            this.PlatformCombo.TabIndex = 19;
            // 
            // TypeCheck
            // 
            this.TypeCheck.AutoSize = true;
            this.TypeCheck.Checked = true;
            this.TypeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeCheck.Location = new System.Drawing.Point(257, 10);
            this.TypeCheck.Name = "TypeCheck";
            this.TypeCheck.Size = new System.Drawing.Size(50, 17);
            this.TypeCheck.TabIndex = 18;
            this.TypeCheck.Text = "Type";
            this.TypeCheck.UseVisualStyleBackColor = true;
            this.TypeCheck.CheckedChanged += new System.EventHandler(this.TypeCheck_CheckedChanged);
            // 
            // TypeCombo
            // 
            this.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Console",
            "Game",
            "Peripheral",
            "Utility",
            "Cable"});
            this.TypeCombo.Location = new System.Drawing.Point(257, 32);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 17;
            // 
            // IDSpinner
            // 
            this.IDSpinner.Location = new System.Drawing.Point(4, 33);
            this.IDSpinner.Maximum = new decimal(new int[] {
            99000,
            0,
            0,
            0});
            this.IDSpinner.Name = "IDSpinner";
            this.IDSpinner.Size = new System.Drawing.Size(120, 20);
            this.IDSpinner.TabIndex = 16;
            this.IDSpinner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDSpinner_KeyPress);
            // 
            // IDCheck
            // 
            this.IDCheck.AutoSize = true;
            this.IDCheck.Checked = true;
            this.IDCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IDCheck.Location = new System.Drawing.Point(4, 10);
            this.IDCheck.Name = "IDCheck";
            this.IDCheck.Size = new System.Drawing.Size(37, 17);
            this.IDCheck.TabIndex = 15;
            this.IDCheck.Text = "ID";
            this.IDCheck.UseVisualStyleBackColor = true;
            this.IDCheck.CheckedChanged += new System.EventHandler(this.IDCheck_CheckedChanged);
            // 
            // OwnerCombo
            // 
            this.OwnerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerCombo.FormattingEnabled = true;
            this.OwnerCombo.Location = new System.Drawing.Point(130, 32);
            this.OwnerCombo.Name = "OwnerCombo";
            this.OwnerCombo.Size = new System.Drawing.Size(121, 21);
            this.OwnerCombo.TabIndex = 14;
            // 
            // OwnerCheck
            // 
            this.OwnerCheck.AutoSize = true;
            this.OwnerCheck.Checked = true;
            this.OwnerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OwnerCheck.Location = new System.Drawing.Point(131, 10);
            this.OwnerCheck.Name = "OwnerCheck";
            this.OwnerCheck.Size = new System.Drawing.Size(57, 17);
            this.OwnerCheck.TabIndex = 13;
            this.OwnerCheck.Text = "Owner";
            this.OwnerCheck.UseVisualStyleBackColor = true;
            this.OwnerCheck.CheckedChanged += new System.EventHandler(this.OwnerCheck_CheckedChanged);
            // 
            // resultsTabs_ctrl
            // 
            this.resultsTabs_ctrl.Location = new System.Drawing.Point(4, 59);
            this.resultsTabs_ctrl.Name = "resultsTabs_ctrl";
            this.resultsTabs_ctrl.SelectedIndex = 0;
            this.resultsTabs_ctrl.Size = new System.Drawing.Size(1280, 288);
            this.resultsTabs_ctrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.resultsTabs_ctrl.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 51);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Close Tab";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(937, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // archiveCheck
            // 
            this.archiveCheck.AutoSize = true;
            this.archiveCheck.Location = new System.Drawing.Point(843, 10);
            this.archiveCheck.Name = "archiveCheck";
            this.archiveCheck.Size = new System.Drawing.Size(134, 17);
            this.archiveCheck.TabIndex = 28;
            this.archiveCheck.Text = "Include Archived Items";
            this.archiveCheck.UseVisualStyleBackColor = true;
            // 
            // SearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 410);
            this.Controls.Add(this.archiveCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultsTabs_ctrl);
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
            this.Name = "SearchItems";
            this.Text = "Search Items";
            ((System.ComponentModel.ISupportInitialize)(this.IDSpinner)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findItems_btn;
        private System.Windows.Forms.CheckBox DescriptionCheck;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.CheckBox SerialCheck;
        private System.Windows.Forms.TextBox SerialText;
        private System.Windows.Forms.CheckBox PlatformCheck;
        private System.Windows.Forms.ComboBox PlatformCombo;
        private System.Windows.Forms.CheckBox TypeCheck;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.NumericUpDown IDSpinner;
        private System.Windows.Forms.CheckBox IDCheck;
        private System.Windows.Forms.ComboBox OwnerCombo;
        private System.Windows.Forms.CheckBox OwnerCheck;
        private System.Windows.Forms.TabControl resultsTabs_ctrl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox archiveCheck;
    }
}