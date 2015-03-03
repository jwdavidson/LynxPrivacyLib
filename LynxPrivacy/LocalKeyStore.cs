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
using LynxPrivacy.LocalKeyStoreDialogs;

namespace LynxPrivacy
{
    public partial class LocalKeyStore : Form
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool m_secretKeyGridLoaded;
        public LocalKeyStore()
        {
            InitializeComponent();
            Application.ThreadException += Application_ThreadException;
            m_secretKeyGridLoaded = false;

        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            log.Error(e.Exception.Message, e.Exception);
            DialogResult result = MessageBox.Show(e.Exception.Message, "Error Detected", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                this.Close();
        }

        private void LocalKeyStore_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SortableBindingList<KeyView> boundKeyView = new SortableBindingList<KeyView>();
            List<KeyStores> pubKeyStores = Global.keyDb.KeyStores.Where(k => k.KeyType == "Public").ToList();
            foreach (KeyStores key in pubKeyStores) {
                boundKeyView.Add(new KeyView(key, key.KeyUsers.First().KeyUserID));
            }
            keyViewBindingSource.DataSource = boundKeyView;
            dgvPublicKeys.ContextMenuStrip = contextMenuStrip1;
            Cursor.Current = Cursors.Default;
            log.Debug("This is a test");
        }

        private void LocalKeyStore_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.Width - 34;
            tabControl1.Height = this.Height - 54;
            dgvPublicKeys.Width = tabControl1.Width - 20;
            dgvPublicKeys.Height = tabControl1.Height - 20;
            dgvSecretKeys.Width = tabControl1.Width - 20;
            dgvSecretKeys.Height = tabControl1.Height - 20;
        }

        private void dgvPublicKeys_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void dgvPublicKeys_ColumnHeaderMouseClick(
    object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvPublicKeys.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgvPublicKeys.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted. 
            if (oldColumn != null) {
                // Sort the same column again, reversing the SortOrder. 
                if (oldColumn == newColumn &&
                    dgvPublicKeys.SortOrder == SortOrder.Ascending) {
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
            dgvPublicKeys.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dgvPublicKeys_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode. 
            foreach (DataGridViewColumn column in dgvPublicKeys.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == "Secret Keys" && (!m_secretKeyGridLoaded)) {
                Cursor.Current = Cursors.WaitCursor;
                SortableBindingList<KeyView> boundKeyView1 = new SortableBindingList<KeyView>();
                List<KeyStores> secKeyStores = Global.keyDb.KeyStores.Where(k => k.KeyType == "Secret").ToList();
                foreach (KeyStores key in secKeyStores) {
                    boundKeyView1.Add(new KeyView(key, key.KeyUsers.First().KeyUserID));
                }
                dgvSecretKeys.DataSource = boundKeyView1;
                dgvSecretKeys.ContextMenuStrip = contextMenuStrip1;
                Cursor.Current = Cursors.Default;
                m_secretKeyGridLoaded = true;
            }
        }

        private void btnSecSetLocalTrust_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void LocalKeyStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ThreadException -= Application_ThreadException;
        }

        private void dgvSecretKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1) {
                if ((((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == null)
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                else if (((bool)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                else
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            }
        }

        private void btnExportKey_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnUploadToKeyserver_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            ImportKeyToKeyStore frmImportKey = new ImportKeyToKeyStore();
            frmImportKey.SetCaller("Public");
            frmImportKey.ShowDialog();
        }

        private void btnRefreshFromKeyserver_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnExportSecKey_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnChangePassphrase_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnExpireKey_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnImportSecretKey_Click(object sender, EventArgs e)
        {
            ImportKeyToKeyStore frmImportKey = new ImportKeyToKeyStore();
            frmImportKey.SetCaller("Secret");
            frmImportKey.ShowDialog();
        }

        private void dgvPublicKeys_CellClick(object sender, DataGridViewCellEventArgs e)
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
