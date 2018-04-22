namespace GamingInventory_V2
{
    partial class ResultsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckInCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ownerValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerValueDataGridViewTextBoxColumn,
            this.iDValueDataGridViewTextBoxColumn,
            this.typeValueDataGridViewTextBoxColumn,
            this.platformValueDataGridViewTextBoxColumn,
            this.serialValueDataGridViewTextBoxColumn,
            this.descriptionValueDataGridViewTextBoxColumn,
            this.CheckInCol});
            this.dataGridView1.DataSource = this.itemResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1024, 768);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // CheckInCol
            // 
            this.CheckInCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckInCol.DataPropertyName = "BindingCheckValue";
            this.CheckInCol.HeaderText = "Checked In";
            this.CheckInCol.Name = "CheckInCol";
            this.CheckInCol.Width = 68;
            // 
            // ownerValueDataGridViewTextBoxColumn
            // 
            this.ownerValueDataGridViewTextBoxColumn.DataPropertyName = "OwnerValue";
            this.ownerValueDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerValueDataGridViewTextBoxColumn.Name = "ownerValueDataGridViewTextBoxColumn";
            this.ownerValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerValueDataGridViewTextBoxColumn.Width = 63;
            // 
            // iDValueDataGridViewTextBoxColumn
            // 
            this.iDValueDataGridViewTextBoxColumn.DataPropertyName = "IDValue";
            this.iDValueDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDValueDataGridViewTextBoxColumn.Name = "iDValueDataGridViewTextBoxColumn";
            this.iDValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDValueDataGridViewTextBoxColumn.Width = 43;
            // 
            // typeValueDataGridViewTextBoxColumn
            // 
            this.typeValueDataGridViewTextBoxColumn.DataPropertyName = "TypeValue";
            this.typeValueDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeValueDataGridViewTextBoxColumn.Name = "typeValueDataGridViewTextBoxColumn";
            this.typeValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeValueDataGridViewTextBoxColumn.Width = 56;
            // 
            // platformValueDataGridViewTextBoxColumn
            // 
            this.platformValueDataGridViewTextBoxColumn.DataPropertyName = "PlatformValue";
            this.platformValueDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformValueDataGridViewTextBoxColumn.Name = "platformValueDataGridViewTextBoxColumn";
            this.platformValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformValueDataGridViewTextBoxColumn.Width = 70;
            // 
            // serialValueDataGridViewTextBoxColumn
            // 
            this.serialValueDataGridViewTextBoxColumn.DataPropertyName = "SerialValue";
            this.serialValueDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialValueDataGridViewTextBoxColumn.Name = "serialValueDataGridViewTextBoxColumn";
            this.serialValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialValueDataGridViewTextBoxColumn.Width = 58;
            // 
            // descriptionValueDataGridViewTextBoxColumn
            // 
            this.descriptionValueDataGridViewTextBoxColumn.DataPropertyName = "DescriptionValue";
            this.descriptionValueDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionValueDataGridViewTextBoxColumn.Name = "descriptionValueDataGridViewTextBoxColumn";
            this.descriptionValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionValueDataGridViewTextBoxColumn.Width = 85;
            // 
            // itemResultBindingSource
            // 
            this.itemResultBindingSource.DataSource = typeof(GamingInventory.ItemResult);
            // 
            // ResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResultsControl";
            this.Size = new System.Drawing.Size(1033, 864);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckInCol;
    }
}
