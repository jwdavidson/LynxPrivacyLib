﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynxPrivacy
{
    public partial class LynxPrivacyTopMDI : Form
    {

        private Director m_frmDirector;
        public LynxPrivacyTopMDI()
        {
            InitializeComponent();
            m_frmDirector = new Director();
            m_frmDirector.MdiParent = this;
            m_frmDirector.Width = this.Width - 20;
            m_frmDirector.Height = this.Height - 67;
            m_frmDirector.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) {
                if (form.GetType() == typeof(AboutBox1)) {
                    form.Activate();
                    return;
                }
            }
            AboutBox1 frmAbout = new AboutBox1();
            frmAbout.MdiParent = this.MdiParent;
            frmAbout.Show();
        }

        private void LynxPrivacyTopMDI_Resize(object sender, EventArgs e)
        {
            m_frmDirector.Width = this.Width - 20;
            m_frmDirector.Height = this.Height - 67;
        }

       

    }
}