namespace GamingInventory_V2
{
    partial class ItemsAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsAudit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ownerValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingCheckValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerValueDataGridViewTextBoxColumn,
            this.iDValueDataGridViewTextBoxColumn,
            this.typeValueDataGridViewTextBoxColumn,
            this.platformValueDataGridViewTextBoxColumn,
            this.serialValueDataGridViewTextBoxColumn,
            this.descriptionValueDataGridViewTextBoxColumn,
            this.bindingCheckValueDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.itemResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1103, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // ownerValueDataGridViewTextBoxColumn
            // 
            this.ownerValueDataGridViewTextBoxColumn.DataPropertyName = "OwnerValue";
            this.ownerValueDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerValueDataGridViewTextBoxColumn.Name = "ownerValueDataGridViewTextBoxColumn";
            this.ownerValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDValueDataGridViewTextBoxColumn
            // 
            this.iDValueDataGridViewTextBoxColumn.DataPropertyName = "IDValue";
            this.iDValueDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDValueDataGridViewTextBoxColumn.Name = "iDValueDataGridViewTextBoxColumn";
            this.iDValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeValueDataGridViewTextBoxColumn
            // 
            this.typeValueDataGridViewTextBoxColumn.DataPropertyName = "TypeValue";
            this.typeValueDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeValueDataGridViewTextBoxColumn.Name = "typeValueDataGridViewTextBoxColumn";
            this.typeValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platformValueDataGridViewTextBoxColumn
            // 
            this.platformValueDataGridViewTextBoxColumn.DataPropertyName = "PlatformValue";
            this.platformValueDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformValueDataGridViewTextBoxColumn.Name = "platformValueDataGridViewTextBoxColumn";
            this.platformValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialValueDataGridViewTextBoxColumn
            // 
            this.serialValueDataGridViewTextBoxColumn.DataPropertyName = "SerialValue";
            this.serialValueDataGridViewTextBoxColumn.HeaderText = "Serial/Title";
            this.serialValueDataGridViewTextBoxColumn.Name = "serialValueDataGridViewTextBoxColumn";
            this.serialValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionValueDataGridViewTextBoxColumn
            // 
            this.descriptionValueDataGridViewTextBoxColumn.DataPropertyName = "DescriptionValue";
            this.descriptionValueDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionValueDataGridViewTextBoxColumn.Name = "descriptionValueDataGridViewTextBoxColumn";
            this.descriptionValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingCheckValueDataGridViewCheckBoxColumn
            // 
            this.bindingCheckValueDataGridViewCheckBoxColumn.DataPropertyName = "BindingCheckValue";
            this.bindingCheckValueDataGridViewCheckBoxColumn.HeaderText = "Checked In";
            this.bindingCheckValueDataGridViewCheckBoxColumn.Name = "bindingCheckValueDataGridViewCheckBoxColumn";
            // 
            // itemResultBindingSource
            // 
            this.itemResultBindingSource.DataSource = typeof(GamingInventory_V2.ItemResult);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemsAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemsAudit";
            this.Text = "Audit Items";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemResultBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bindingCheckValueDataGridViewCheckBoxColumn;
    }
}