namespace SoftwareTrigger
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSoftwareTrigger = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnShowImg = new System.Windows.Forms.Button();
            this.Pro = new System.Windows.Forms.PropertyGrid();
            this.hWindowCtrl = new HalconDotNet.HWindowControl();
            this.menuStripSet = new System.Windows.Forms.MenuStrip();
            this.ToolStripSet = new System.Windows.Forms.ToolStripMenuItem();
            this.chkboxMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStripSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(17, 96);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(970, 611);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOpen.Location = new System.Drawing.Point(235, 28);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开相机";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(888, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭相机";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSoftwareTrigger
            // 
            this.btnSoftwareTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSoftwareTrigger.Location = new System.Drawing.Point(407, 29);
            this.btnSoftwareTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoftwareTrigger.Name = "btnSoftwareTrigger";
            this.btnSoftwareTrigger.Size = new System.Drawing.Size(83, 46);
            this.btnSoftwareTrigger.TabIndex = 3;
            this.btnSoftwareTrigger.Text = "采集图像";
            this.btnSoftwareTrigger.UseVisualStyleBackColor = false;
            this.btnSoftwareTrigger.Click += new System.EventHandler(this.btnSoftwareTrigger_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(103, 29);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 41);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "OK";
            // 
            // btnDetect
            // 
            this.btnDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDetect.Location = new System.Drawing.Point(579, 28);
            this.btnDetect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(83, 46);
            this.btnDetect.TabIndex = 5;
            this.btnDetect.Text = "检测";
            this.btnDetect.UseVisualStyleBackColor = false;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnShowImg
            // 
            this.btnShowImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowImg.Location = new System.Drawing.Point(745, 28);
            this.btnShowImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowImg.Name = "btnShowImg";
            this.btnShowImg.Size = new System.Drawing.Size(83, 46);
            this.btnShowImg.TabIndex = 6;
            this.btnShowImg.Text = "显示原图";
            this.btnShowImg.UseVisualStyleBackColor = false;
            this.btnShowImg.Click += new System.EventHandler(this.btnShowImg_Click);
            // 
            // Pro
            // 
            this.Pro.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pro.Location = new System.Drawing.Point(989, 28);
            this.Pro.Margin = new System.Windows.Forms.Padding(4);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(291, 701);
            this.Pro.TabIndex = 8;
            // 
            // hWindowCtrl
            // 
            this.hWindowCtrl.BackColor = System.Drawing.Color.Black;
            this.hWindowCtrl.BorderColor = System.Drawing.Color.Black;
            this.hWindowCtrl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowCtrl.Location = new System.Drawing.Point(17, 96);
            this.hWindowCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hWindowCtrl.Name = "hWindowCtrl";
            this.hWindowCtrl.Size = new System.Drawing.Size(971, 611);
            this.hWindowCtrl.TabIndex = 9;
            this.hWindowCtrl.WindowSize = new System.Drawing.Size(971, 611);
            // 
            // menuStripSet
            // 
            this.menuStripSet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSet});
            this.menuStripSet.Location = new System.Drawing.Point(0, 0);
            this.menuStripSet.Name = "menuStripSet";
            this.menuStripSet.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripSet.Size = new System.Drawing.Size(1280, 28);
            this.menuStripSet.TabIndex = 10;
            this.menuStripSet.Text = "menuStrip1";
            // 
            // ToolStripSet
            // 
            this.ToolStripSet.Name = "ToolStripSet";
            this.ToolStripSet.Size = new System.Drawing.Size(51, 24);
            this.ToolStripSet.Text = "设置";
            this.ToolStripSet.Click += new System.EventHandler(this.ToolStripSet_Click);
            // 
            // chkboxMode
            // 
            this.chkboxMode.AutoSize = true;
            this.chkboxMode.Location = new System.Drawing.Point(888, 72);
            this.chkboxMode.Name = "chkboxMode";
            this.chkboxMode.Size = new System.Drawing.Size(89, 19);
            this.chkboxMode.TabIndex = 11;
            this.chkboxMode.Text = "录像模式";
            this.chkboxMode.UseVisualStyleBackColor = true;
            this.chkboxMode.CheckedChanged += new System.EventHandler(this.chkboxMode_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 729);
            this.Controls.Add(this.chkboxMode);
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.btnShowImg);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSoftwareTrigger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.hWindowCtrl);
            this.Controls.Add(this.menuStripSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSet;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = " 苏州优维毕-缺陷检测";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStripSet.ResumeLayout(false);
            this.menuStripSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSoftwareTrigger;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnShowImg;
        private System.Windows.Forms.PropertyGrid Pro;
        private HalconDotNet.HWindowControl hWindowCtrl;
        private System.Windows.Forms.MenuStrip menuStripSet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSet;
        private System.Windows.Forms.CheckBox chkboxMode;
    }
}

