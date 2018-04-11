using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareTrigger
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        public FormConfig(object sender, EventArgs e)
        {
            InitializeComponent();
            strSavePath = txtPath.Text;
            nExpTime = Int32.Parse(txtExposure.Text);
            fCamGain = float.Parse(txtGain.Text);
            formMain = sender as frmMain;
        }

        private frmMain formMain;
        public String strSavePath { get; set; }
        public Int32 nExpTime { get; set; }
        public float fCamGain { get; set; }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (folderBrowsePath.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowsePath.SelectedPath.Length != 0)
                {
                    strSavePath = folderBrowsePath.SelectedPath;
                    txtPath.Text = strSavePath;
                }
            }
        }

        private void txtExposure_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                nExpTime = Int32.Parse(txtExposure.Text);
            }
        }

        private void txtGain_TextChanged(object sender, EventArgs e)
        {
            fCamGain = float.Parse(txtGain.Text);
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain.SetSavePath(strSavePath);
            formMain.SetExpTime(nExpTime);
            formMain.SetCamGain(fCamGain);
        }
    }
}
