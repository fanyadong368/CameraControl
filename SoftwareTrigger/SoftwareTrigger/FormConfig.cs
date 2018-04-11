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
        private frmMain formMain;               // 主窗口变量，用于此窗口变量值的传回
        public String strSavePath { get; set; } // 图片保存路径
        public Int32 nExpTime { get; set; }     // 曝光时间
        public float fCamGain { get; set; }     // 相机增益

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

        /* 保存路径按钮事件 */
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

        /* 曝光时间改变事件 */
        private void txtExposure_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                nExpTime = Int32.Parse(txtExposure.Text);
            }
        }

        /* 增益数字改变事件 */
        private void txtGain_TextChanged(object sender, EventArgs e)
        {
            fCamGain = float.Parse(txtGain.Text);
        }

        /* 参数设置窗口关闭事件：将窗口上的变量值传回主窗口对应变量 */
        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain.SetSavePath(strSavePath);
            formMain.SetExpTime(nExpTime);
            formMain.SetCamGain(fCamGain);
        }
    }
}
