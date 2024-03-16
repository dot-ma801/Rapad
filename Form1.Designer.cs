
namespace Rapad
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChangeTopMost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonResetFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChangeFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMarkdown = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(306, 162);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSettings,
            this.toolStripButtonChangeTopMost,
            this.toolStripSeparator1,
            this.toolStripButtonResetFont,
            this.toolStripButtonChangeFont,
            this.toolStripButtonOpenFolder,
            this.toolStripButtonMarkdown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(310, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSettings.Text = "設定";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonChangeTopMost
            // 
            this.toolStripButtonChangeTopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonChangeTopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangeTopMost.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangeTopMost.Image")));
            this.toolStripButtonChangeTopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeTopMost.Name = "toolStripButtonChangeTopMost";
            this.toolStripButtonChangeTopMost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonChangeTopMost.Text = "最前面表示";
            this.toolStripButtonChangeTopMost.Click += new System.EventHandler(this.toolStripButtonChangeTopMost_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonResetFont
            // 
            this.toolStripButtonResetFont.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonResetFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResetFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResetFont.Image")));
            this.toolStripButtonResetFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetFont.Name = "toolStripButtonResetFont";
            this.toolStripButtonResetFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonResetFont.Text = "フォントリセット";
            this.toolStripButtonResetFont.Click += new System.EventHandler(this.toolStripButtonResetFont_Click);
            // 
            // toolStripButtonChangeFont
            // 
            this.toolStripButtonChangeFont.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangeFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangeFont.Image")));
            this.toolStripButtonChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeFont.Name = "toolStripButtonChangeFont";
            this.toolStripButtonChangeFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonChangeFont.Text = "フォント変更";
            this.toolStripButtonChangeFont.Click += new System.EventHandler(this.toolStripButtonChangeFont_Click);
            // 
            // toolStripButtonOpenFolder
            // 
            this.toolStripButtonOpenFolder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFolder.Image")));
            this.toolStripButtonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFolder.Name = "toolStripButtonOpenFolder";
            this.toolStripButtonOpenFolder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFolder.Text = "toolStripButton1";
            this.toolStripButtonOpenFolder.ToolTipText = "自動保存先を開く";
            this.toolStripButtonOpenFolder.Click += new System.EventHandler(this.toolStripButtonOpenFolder_Click);
            // 
            // toolStripButtonMarkdown
            // 
            this.toolStripButtonMarkdown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonMarkdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMarkdown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMarkdown.Image")));
            this.toolStripButtonMarkdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarkdown.Name = "toolStripButtonMarkdown";
            this.toolStripButtonMarkdown.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMarkdown.Text = "markdownとして開く";
            this.toolStripButtonMarkdown.Click += new System.EventHandler(this.toolStripButtonMarkdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 187);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 39);
            this.Name = "Form1";
            this.Text = "Rapad";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeTopMost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonMarkdown;
    }
}

