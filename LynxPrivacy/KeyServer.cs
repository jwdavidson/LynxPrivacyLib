using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LynxPrivacyLib;

namespace LynxPrivacy
{
    public partial class KeyServer : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public KeyServer()
        {
            InitializeComponent();
            Application.ThreadException += Application_ThreadException;
            btnLocalSearch.Visible = false;
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            log.Error(e.Exception.Message, e.Exception);
            DialogResult result = MessageBox.Show(e.Exception.Message, "Error Detected", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                this.Close();
        }

        private void KeyServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ThreadException -= Application_ThreadException;
        }

        private SortableBindingList<KeySearchView> m_keySearchView;
        private async void btnSearchKeyserver_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            m_keySearchView = new SortableBindingList<KeySearchView>();
            SortableBindingList<KeySearchView> boundKeySrchView = new SortableBindingList<KeySearchView>();
            PgpKeyserverSearch newSearch = new PgpKeyserverSearch(Global.keyServerConnectionBase);
            await newSearch.ReadResults(txtPubKeyFilter.Text);
            foreach (KeyserverPublicKey key in newSearch.m_SearchResults) {
                boundKeySrchView.Add(new KeySearchView(key));
            }
            m_keySearchView = boundKeySrchView;
            dataGridView1.DataSource = boundKeySrchView;
            Cursor.Current = Cursors.Default;
        }

        private void btnLocalSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void btmImportSelectedKeysToKeystore_Click(object sender, EventArgs e)
        {
            PgpKeyserverGetKey getKey = new PgpKeyserverGetKey(Global.keyServerConnectionBase);
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[0].Value != null) {
                    if ((bool)row.Cells[0].Value == true) {
                        await getKey.ImportKey((string)row.Cells[2].Value, Global.keyDb);
                    }
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted. 
            if (oldColumn != null) {
                // Sort the same column again, reversing the SortOrder. 
                if (oldColumn == newColumn &&
                    dataGridView1.SortOrder == SortOrder.Ascending) {
                    direction = ListSortDirection.Descending;
                } else {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            } else {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                if ((((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == null)
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                else if (((bool)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                else
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            }
        }

    }
}
