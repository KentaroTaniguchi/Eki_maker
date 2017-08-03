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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit22)).BeginInit();
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
            this.label2.Text = "出発駅";
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
            this.button1.Click += new System.EventHandler(this.search_route);
            // 
            // axExpDiaStationNameEdit21
            // 
            this.axExpDiaStationNameEdit21.Enabled = true;
            this.axExpDiaStationNameEdit21.Location = new System.Drawing.Point(12, 49);
            this.axExpDiaStationNameEdit21.Name = "axExpDiaStationNameEdit21";
            this.axExpDiaStationNameEdit21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axExpDiaStationNameEdit21.OcxState")));
            this.axExpDiaStationNameEdit21.Size = new System.Drawing.Size(192, 25);
            this.axExpDiaStationNameEdit21.TabIndex = 16;
            // 
            // axExpDiaStationNameEdit22
            // 
            this.axExpDiaStationNameEdit22.Enabled = true;
            this.axExpDiaStationNameEdit22.Location = new System.Drawing.Point(12, 103);
            this.axExpDiaStationNameEdit22.Name = "axExpDiaStationNameEdit22";
            this.axExpDiaStationNameEdit22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axExpDiaStationNameEdit22.OcxState")));
            this.axExpDiaStationNameEdit22.Size = new System.Drawing.Size(192, 25);
            this.axExpDiaStationNameEdit22.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 24;
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
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 79);
            this.button3.TabIndex = 21;
            this.button3.Text = "読込";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Read);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "空欄（経路）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "空欄（合計時間）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "到着駅";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 432);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaStationNameEdit22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2 axExpDiaStationNameEdit21;
        public AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2 axExpDiaStationNameEdit22;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAttentionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

