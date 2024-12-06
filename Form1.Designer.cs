namespace Web4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbSizes = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnB = new System.Windows.Forms.ToolStripButton();
            this.btnI = new System.Windows.Forms.ToolStripButton();
            this.btnU = new System.Windows.Forms.ToolStripButton();
            this.TaovanbanmoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdMofile = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1390, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaovanbanmoiToolStripMenuItem,
            this.cmdMofile,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(155, 41);
            this.menuToolStripMenuItem.Text = "Hệ Thống";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(517, 48);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(166, 41);
            this.địnhDạngToolStripMenuItem.Text = "Định Dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 891);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1390, 48);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(236, 37);
            this.toolStripStatusLabel1.Text = "Thời Gian Hiển Thị";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.cmbFonts,
            this.cmbSizes,
            this.btnB,
            this.btnI,
            this.btnU});
            this.toolStrip1.Location = new System.Drawing.Point(0, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1390, 46);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 161);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1406, 727);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cmbSizes
            // 
            this.cmbSizes.Name = "cmbSizes";
            this.cmbSizes.Size = new System.Drawing.Size(121, 46);
            this.cmbSizes.Click += new System.EventHandler(this.cmbSizes_Click);
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 46);
            this.cmbFonts.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_103527;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 40);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_103657;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.LưuFile_Click);
            // 
            // btnB
            // 
            this.btnB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnB.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_111733;
            this.btnB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(52, 40);
            this.btnB.Text = "toolStripButton3";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnI
            // 
            this.btnI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnI.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_111812;
            this.btnI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(52, 40);
            this.btnI.Text = "toolStripButton4";
            this.btnI.Click += new System.EventHandler(this.btn_I_Click);
            // 
            // btnU
            // 
            this.btnU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnU.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_111829;
            this.btnU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(52, 40);
            this.btnU.Text = "toolStripButton3";
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // TaovanbanmoiToolStripMenuItem
            // 
            this.TaovanbanmoiToolStripMenuItem.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_103527;
            this.TaovanbanmoiToolStripMenuItem.Name = "TaovanbanmoiToolStripMenuItem";
            this.TaovanbanmoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TaovanbanmoiToolStripMenuItem.Size = new System.Drawing.Size(517, 48);
            this.TaovanbanmoiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.TaovanbanmoiToolStripMenuItem.Click += new System.EventHandler(this.TaovanbanmoiToolStripMenuItem_Click);
            // 
            // cmdMofile
            // 
            this.cmdMofile.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_103631;
            this.cmdMofile.Name = "cmdMofile";
            this.cmdMofile.Size = new System.Drawing.Size(517, 48);
            this.cmdMofile.Text = "Mở tập tin";
            this.cmdMofile.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = global::Web4.Properties.Resources.Ảnh_chụp_màn_hình_2024_12_06_103657;
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(517, 48);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 939);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnB;
        private System.Windows.Forms.ToolStripButton btnI;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem TaovanbanmoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdMofile;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbSizes;
        private System.Windows.Forms.ToolStripButton btnU;
    }
}

