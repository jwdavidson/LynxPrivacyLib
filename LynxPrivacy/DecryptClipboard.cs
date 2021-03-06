﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LynxPrivacyLib;

namespace LynxPrivacy
{
    public partial class DecryptClipboard : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public DecryptClipboard()
        {
            InitializeComponent();
            Application.ThreadException += Application_ThreadException;
            richTextBox1.Visible = false;
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            log.Error(e.Exception.Message, e.Exception);
            DialogResult result = MessageBox.Show(e.Exception.Message, "Error Detected", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                this.Close();
        }

        private void DecryptClipboard_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SortableBindingList<KeyView> bndPublicKeyView = new SortableBindingList<KeyView>();
            List<KeyStores> pubKeyStores = Global.keyDb.KeyStores.Where(k => k.KeyType == "Public").ToList();
            foreach (KeyStores key in pubKeyStores) {
                bndPublicKeyView.Add(new KeyView(key, key.KeyUsers.First().KeyUserID));
            }
            dgvPublicKeys.DataSource = bndPublicKeyView;
            SortableBindingList<KeyView> bndSecretKeyView = new SortableBindingList<KeyView>();
            List<KeyStores> secKeyStores = Global.keyDb.KeyStores.Where(k => k.KeyType == "Secret").ToList();
            foreach (KeyStores key in secKeyStores) {
                bndSecretKeyView.Add(new KeyView(key, key.KeyUsers.First().KeyUserID));
            }
            dgvSecretKeys.DataSource = bndSecretKeyView;
            Cursor.Current = Cursors.Default;
        }

        private void DecryptClipboard_Resize(object sender, EventArgs e)
        {
            dgvPublicKeys.Width = this.Width - 54;
            dgvSecretKeys.Width = this.Width - 54;
            richTextBox1.Width = this.Width - 44;
            richTextBox1.Height = this.Height - 74;
        }

        private void dgvPublicKeys_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void dgvSecretKeys_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvSecretKeys.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgvSecretKeys.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted. 
            if (oldColumn != null) {
                // Sort the same column again, reversing the SortOrder. 
                if (oldColumn == newColumn &&
                    dgvSecretKeys.SortOrder == SortOrder.Ascending) {
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
            dgvSecretKeys.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dgvPublicKeys_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode. 
            foreach (DataGridViewColumn column in dgvPublicKeys.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void dgvSecretKeys_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode. 
            foreach (DataGridViewColumn column in dgvSecretKeys.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
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

        private void dgvSecretKeys_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnDisplayClipBrd_Click(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 44;
            richTextBox1.Height = this.Height - 74;
            richTextBox1.Visible = richTextBox1.Visible ? false : true;
            btnDisplayClipBrd.Text = btnDisplayClipBrd.Text == "Show Clipboard" ? "Hide Clipboard" : "Show Clipboard";
        }

        private void btnPubKeyFilter_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnSignOnly_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void btnEncryptSign_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(sender.ToString());
        }

        private void DecryptClipboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ThreadException -= Application_ThreadException;
        }
    }
}
