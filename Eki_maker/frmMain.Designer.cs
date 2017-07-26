namespace Eki_maker
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.axExpDiaStationNameEdit21 = new AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2();
            this.axExpDiaStationNameEdit22 = new AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttentionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit22)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "出発地";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "到着";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 104);
            this.button1.TabIndex = 15;
            this.button1.Text = "経路の探索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axExpDiaStationNameEdit21
            // 
            this.axExpDiaStationNameEdit21.Enabled = true;
            this.axExpDiaStationNameEdit21.Location = new System.Drawing.Point(12, 49);
            this.axExpDiaStationNameEdit21.Name = "axExpDiaStationNameEdit21";
            this.axExpDiaStationNameEdit21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axExpDiaStationNameEdit21.OcxState")));
            this.axExpDiaStationNameEdit21.Size = new System.Drawing.Size(192, 25);
            this.axExpDiaStationNameEdit21.TabIndex = 16;
            this.axExpDiaStationNameEdit21.StationTypeChanged += new AxEXPDCTRL2Lib._IExpDiaStationNameEdit2Events_StationTypeChangedEventHandler(this.axExpDiaStationNameEdit21_StationTypeChanged);
            // 
            // axExpDiaStationNameEdit22
            // 
            this.axExpDiaStationNameEdit22.Enabled = true;
            this.axExpDiaStationNameEdit22.Location = new System.Drawing.Point(12, 103);
            this.axExpDiaStationNameEdit22.Name = "axExpDiaStationNameEdit22";
            this.axExpDiaStationNameEdit22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axExpDiaStationNameEdit22.OcxState")));
            this.axExpDiaStationNameEdit22.Size = new System.Drawing.Size(192, 25);
            this.axExpDiaStationNameEdit22.TabIndex = 17;
            this.axExpDiaStationNameEdit22.StationTypeChanged += new AxEXPDCTRL2Lib._IExpDiaStationNameEdit2Events_StationTypeChangedEventHandler(this.axExpDiaStationNameEdit22_StationTypeChanged);
           
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "ファイル";
            // 
            // mnuToolStripMenuItem
            // 
            this.mnuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAttentionToolStripMenuItem});
            this.mnuToolStripMenuItem.Name = "mnuToolStripMenuItem";
            this.mnuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mnuToolStripMenuItem.Text = "設定";
            // 
            // mnuAttentionToolStripMenuItem
            // 
            this.mnuAttentionToolStripMenuItem.Name = "mnuAttentionToolStripMenuItem";
            this.mnuAttentionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.mnuAttentionToolStripMenuItem.Text = "結果画面の警告を表示";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 93);
            this.button2.TabIndex = 20;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 79);
            this.button3.TabIndex = 21;
            this.button3.Text = "保存内容";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(533, 79);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 432);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axExpDiaStationNameEdit22);
            this.Controls.Add(this.axExpDiaStationNameEdit21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit22)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2 axExpDiaStationNameEdit21;
        public AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2 axExpDiaStationNameEdit22;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAttentionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

