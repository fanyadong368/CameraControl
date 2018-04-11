namespace SoftwareTrigger
{
    partial class FormConfig
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
            this.tabCtrCam = new System.Windows.Forms.TabControl();
            this.tabPgDet = new System.Windows.Forms.TabPage();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.tabPgCam = new System.Windows.Forms.TabPage();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.lblGain = new System.Windows.Forms.Label();
            this.txtExposure = new System.Windows.Forms.TextBox();
            this.lblExposure = new System.Windows.Forms.Label();
            this.folderBrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabCtrCam.SuspendLayout();
            this.tabPgDet.SuspendLayout();
            this.tabPgCam.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrCam
            // 
            this.tabCtrCam.Controls.Add(this.tabPgDet);
            this.tabCtrCam.Controls.Add(this.tabPgCam);
            this.tabCtrCam.Location = new System.Drawing.Point(12, 12);
            this.tabCtrCam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtrCam.Name = "tabCtrCam";
            this.tabCtrCam.SelectedIndex = 0;
            this.tabCtrCam.Size = new System.Drawing.Size(699, 438);
            this.tabCtrCam.TabIndex = 0;
            // 
            // tabPgDet
            // 
            this.tabPgDet.Controls.Add(this.btnSelectPath);
            this.tabPgDet.Controls.Add(this.txtPath);
            this.tabPgDet.Controls.Add(this.lblSavePath);
            this.tabPgDet.Location = new System.Drawing.Point(4, 25);
            this.tabPgDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgDet.Name = "tabPgDet";
            this.tabPgDet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgDet.Size = new System.Drawing.Size(691, 409);
            this.tabPgDet.TabIndex = 0;
            this.tabPgDet.Text = "检测参数";
            this.tabPgDet.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(551, 52);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(93, 25);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "选择路径";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(35, 52);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(475, 25);
            this.txtPath.TabIndex = 2;
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(31, 31);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(97, 15);
            this.lblSavePath.TabIndex = 0;
            this.lblSavePath.Text = "图片保存路径";
            // 
            // tabPgCam
            // 
            this.tabPgCam.Controls.Add(this.txtGain);
            this.tabPgCam.Controls.Add(this.lblGain);
            this.tabPgCam.Controls.Add(this.txtExposure);
            this.tabPgCam.Controls.Add(this.lblExposure);
            this.tabPgCam.Location = new System.Drawing.Point(4, 25);
            this.tabPgCam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgCam.Name = "tabPgCam";
            this.tabPgCam.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgCam.Size = new System.Drawing.Size(691, 409);
            this.tabPgCam.TabIndex = 1;
            this.tabPgCam.Text = "相机参数";
            this.tabPgCam.UseVisualStyleBackColor = true;
            // 
            // txtGain
            // 
            this.txtGain.Location = new System.Drawing.Point(251, 100);
            this.txtGain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(100, 25);
            this.txtGain.TabIndex = 3;
            this.txtGain.Text = "1.0";
            this.txtGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGain.TextChanged += new System.EventHandler(this.txtGain_TextChanged);
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(101, 102);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(67, 15);
            this.lblGain.TabIndex = 2;
            this.lblGain.Text = "相机增益";
            // 
            // txtExposure
            // 
            this.txtExposure.Location = new System.Drawing.Point(251, 58);
            this.txtExposure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExposure.Name = "txtExposure";
            this.txtExposure.Size = new System.Drawing.Size(100, 25);
            this.txtExposure.TabIndex = 1;
            this.txtExposure.Text = "1800";
            this.txtExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExposure.TextChanged += new System.EventHandler(this.txtExposure_TextChanged);
            // 
            // lblExposure
            // 
            this.lblExposure.AutoSize = true;
            this.lblExposure.Location = new System.Drawing.Point(101, 60);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.Size = new System.Drawing.Size(127, 15);
            this.lblExposure.TabIndex = 0;
            this.lblExposure.Text = "曝光时间（毫秒）";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 461);
            this.Controls.Add(this.tabCtrCam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.tabCtrCam.ResumeLayout(false);
            this.tabPgDet.ResumeLayout(false);
            this.tabPgDet.PerformLayout();
            this.tabPgCam.ResumeLayout(false);
            this.tabPgCam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrCam;
        private System.Windows.Forms.TabPage tabPgDet;
        private System.Windows.Forms.TabPage tabPgCam;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowsePath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label lblExposure;
        private System.Windows.Forms.TextBox txtExposure;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Label lblGain;
    }
}