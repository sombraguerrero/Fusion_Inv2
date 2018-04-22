using System;
using System.Windows.Forms;
using GamingInventory;

namespace GamingInventory_V2
{
    public partial class ResultsControl : UserControl
    {

        public ResultsControl()
        {
            InitializeComponent();
        }

        public DataGridView ResultDGV {  get { return dataGridView1; } }
        public BindingSource ResultBindingV { get { return itemResultBindingSource; } }


        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell cc;
            ItemResult ItemChanged;

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("CheckInCol"))
            {
                cc = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                ItemChanged = itemResultBindingSource[e.RowIndex] as ItemResult;
                if ((bool)cc.Value)
                {
                    ItemChanged.LastCheckInValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    ItemChanged.UpsertCheckInOut(SearchItems.SearchItemsConnection, true);
                }
                else
                {
                    ItemChanged.LastCheckOutValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    ItemChanged.UpsertCheckInOut(SearchItems.SearchItemsConnection, false);
                }
            }

        }
    }
}
