namespace GamingInventory_V2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importCSVbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.updateItem_btn = new System.Windows.Forms.Button();
            this.addItem_btn = new System.Windows.Forms.Button();
            this.updateOwner_btn = new System.Windows.Forms.Button();
            this.addOwner_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchOwner_btn = new System.Windows.Forms.Button();
            this.searchItems_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemsAudit_btn = new System.Windows.Forms.Button();
            this.gamesByPlatform_btn = new System.Windows.Forms.Button();
            this.UsageRpt_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importCSVbtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Controls.Add(this.exportBtn);
            this.groupBox1.Controls.Add(this.updateItem_btn);
            this.groupBox1.Controls.Add(this.addItem_btn);
            this.groupBox1.Controls.Add(this.updateOwner_btn);
            this.groupBox1.Controls.Add(this.addOwner_btn);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management";
            // 
            // importCSVbtn
            // 
            this.importCSVbtn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCSVbtn.Location = new System.Drawing.Point(328, 90);
            this.importCSVbtn.Name = "importCSVbtn";
            this.importCSVbtn.Size = new System.Drawing.Size(93, 65);
            this.importCSVbtn.TabIndex = 7;
            this.importCSVbtn.Text = "Import CSV";
            this.importCSVbtn.UseVisualStyleBackColor = true;
            this.importCSVbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(328, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Platform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // importBtn
            // 
            this.importBtn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.Location = new System.Drawing.Point(232, 90);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(90, 65);
            this.importBtn.TabIndex = 5;
            this.importBtn.Text = "Import Database";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(232, 19);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(90, 65);
            this.exportBtn.TabIndex = 4;
            this.exportBtn.Text = "Export Database";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click_2);
            // 
            // updateItem_btn
            // 
            this.updateItem_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItem_btn.Location = new System.Drawing.Point(119, 90);
            this.updateItem_btn.Name = "updateItem_btn";
            this.updateItem_btn.Size = new System.Drawing.Size(107, 65);
            this.updateItem_btn.TabIndex = 3;
            this.updateItem_btn.Text = "Update Items";
            this.updateItem_btn.UseVisualStyleBackColor = true;
            this.updateItem_btn.Click += new System.EventHandler(this.updateItem_btn_Click);
            // 
            // addItem_btn
            // 
            this.addItem_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem_btn.Location = new System.Drawing.Point(119, 19);
            this.addItem_btn.Name = "addItem_btn";
            this.addItem_btn.Size = new System.Drawing.Size(107, 65);
            this.addItem_btn.TabIndex = 2;
            this.addItem_btn.Text = "Add Items";
            this.addItem_btn.UseVisualStyleBackColor = true;
            this.addItem_btn.Click += new System.EventHandler(this.addItem_btn_Click_1);
            // 
            // updateOwner_btn
            // 
            this.updateOwner_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOwner_btn.Location = new System.Drawing.Point(6, 90);
            this.updateOwner_btn.Name = "updateOwner_btn";
            this.updateOwner_btn.Size = new System.Drawing.Size(107, 65);
            this.updateOwner_btn.TabIndex = 1;
            this.updateOwner_btn.Text = "Update Owner";
            this.updateOwner_btn.UseVisualStyleBackColor = true;
            this.updateOwner_btn.Click += new System.EventHandler(this.updateOwner_btn_Click_1);
            // 
            // addOwner_btn
            // 
            this.addOwner_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOwner_btn.Location = new System.Drawing.Point(6, 19);
            this.addOwner_btn.Name = "addOwner_btn";
            this.addOwner_btn.Size = new System.Drawing.Size(107, 65);
            this.addOwner_btn.TabIndex = 0;
            this.addOwner_btn.Text = "Add Owner";
            this.addOwner_btn.UseVisualStyleBackColor = true;
            this.addOwner_btn.Click += new System.EventHandler(this.addOwner_btn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchOwner_btn);
            this.groupBox2.Controls.Add(this.searchItems_btn);
            this.groupBox2.Location = new System.Drawing.Point(113, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching";
            // 
            // searchOwner_btn
            // 
            this.searchOwner_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwner_btn.Location = new System.Drawing.Point(6, 19);
            this.searchOwner_btn.Name = "searchOwner_btn";
            this.searchOwner_btn.Size = new System.Drawing.Size(107, 65);
            this.searchOwner_btn.TabIndex = 1;
            this.searchOwner_btn.Text = "Search Owner";
            this.searchOwner_btn.UseVisualStyleBackColor = true;
            this.searchOwner_btn.Click += new System.EventHandler(this.searchOwner_btn_Click);
            // 
            // searchItems_btn
            // 
            this.searchItems_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItems_btn.Location = new System.Drawing.Point(113, 19);
            this.searchItems_btn.Name = "searchItems_btn";
            this.searchItems_btn.Size = new System.Drawing.Size(107, 65);
            this.searchItems_btn.TabIndex = 0;
            this.searchItems_btn.Text = "Search Items";
            this.searchItems_btn.UseVisualStyleBackColor = true;
            this.searchItems_btn.Click += new System.EventHandler(this.searchItems_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemsAudit_btn);
            this.groupBox3.Controls.Add(this.gamesByPlatform_btn);
            this.groupBox3.Controls.Add(this.UsageRpt_btn);
            this.groupBox3.Location = new System.Drawing.Point(18, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporting";
            // 
            // itemsAudit_btn
            // 
            this.itemsAudit_btn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsAudit_btn.Location = new System.Drawing.Point(6, 19);
            this.itemsAudit_btn.Name = "itemsAudit_btn";
            this.itemsAudit_btn.Size = new System.Drawing.Size(122, 49);
            this.itemsAudit_btn.TabIndex = 2;
            this.itemsAudit_btn.Text = "Load-In/Out";
            this.itemsAudit_btn.UseVisualStyleBackColor = true;
            this.itemsAudit_btn.Click += new System.EventHandler(this.itemsAudit_btn_Click);
            // 
            // gamesByPlatform_btn
            // 
            this.gamesByPlatform_btn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesByPlatform_btn.Location = new System.Drawing.Point(134, 19);
            this.gamesByPlatform_btn.Name = "gamesByPlatform_btn";
            this.gamesByPlatform_btn.Size = new System.Drawing.Size(172, 49);
            this.gamesByPlatform_btn.TabIndex = 1;
            this.gamesByPlatform_btn.Text = "Games By Platform";
            this.gamesByPlatform_btn.UseVisualStyleBackColor = true;
            this.gamesByPlatform_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UsageRpt_btn
            // 
            this.UsageRpt_btn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsageRpt_btn.Location = new System.Drawing.Point(312, 19);
            this.UsageRpt_btn.Name = "UsageRpt_btn";
            this.UsageRpt_btn.Size = new System.Drawing.Size(121, 49);
            this.UsageRpt_btn.TabIndex = 0;
            this.UsageRpt_btn.Text = "Logistics Summary";
            this.UsageRpt_btn.UseVisualStyleBackColor = true;
            this.UsageRpt_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.Filter = "SQL Script|*.sql";
            this.saveFileDialog1.Title = "Export Database";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "sql";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "SQL Script|*.sql";
            this.openFileDialog1.Title = "Select Database Dump to Import";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Electronic Gaming Inventory v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateItem_btn;
        private System.Windows.Forms.Button addItem_btn;
        private System.Windows.Forms.Button updateOwner_btn;
        private System.Windows.Forms.Button addOwner_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchOwner_btn;
        private System.Windows.Forms.Button searchItems_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button UsageRpt_btn;
        private System.Windows.Forms.Button gamesByPlatform_btn;
        private System.Windows.Forms.Button itemsAudit_btn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button importCSVbtn;
    }
}

