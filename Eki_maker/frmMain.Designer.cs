namespace Eki_maker
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_result_botton = new System.Windows.Forms.Button();
            this.axExpDiaStationNameEdit21 = new AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2();
            this.axExpDiaStationNameEdit22 = new AxEXPDCTRL2Lib.AxExpDiaStationNameEdit2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttentionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close_botton = new System.Windows.Forms.Button();
            this.Read_file = new System.Windows.Forms.Button();
            this.Route_Display = new System.Windows.Forms.Label();
            this.Route＿Display = new System.Windows.Forms.Label();
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
            // search_result_botton
            // 
            this.search_result_botton.Location = new System.Drawing.Point(237, 24);
            this.search_result_botton.Name = "search_result_botton";
            this.search_result_botton.Size = new System.Drawing.Size(308, 104);
            this.search_result_botton.TabIndex = 15;
            this.search_result_botton.Text = "経路の探索";
            this.search_result_botton.UseVisualStyleBackColor = true;
            this.search_result_botton.Click += new System.EventHandler(this.btn_Search_Route);
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
            // close_botton
            // 
            this.close_botton.Location = new System.Drawing.Point(237, 134);
            this.close_botton.Name = "close_botton";
            this.close_botton.Size = new System.Drawing.Size(308, 93);
            this.close_botton.TabIndex = 20;
            this.close_botton.Text = "終了";
            this.close_botton.UseVisualStyleBackColor = true;
            this.close_botton.Click += new System.EventHandler(this.btn_Close);
            // 
            // Read_file
            // 
            this.Read_file.Location = new System.Drawing.Point(237, 341);
            this.Read_file.Name = "Read_file";
            this.Read_file.Size = new System.Drawing.Size(305, 79);
            this.Read_file.TabIndex = 21;
            this.Read_file.Text = "読込";
            this.Read_file.UseVisualStyleBackColor = true;
            this.Read_file.Click += new System.EventHandler(this.btn_Read_Json);
            // 
            // Route_Display
            // 
            this.Route_Display.Location = new System.Drawing.Point(16, 254);
            this.Route_Display.Name = "Route_Display";
            this.Route_Display.Size = new System.Drawing.Size(500, 28);
            this.Route_Display.TabIndex = 25;
            this.Route_Display.Text = "空欄（経路）";
            // 
            // Route＿Display
            // 
            this.Route＿Display.AutoSize = true;
            this.Route＿Display.Location = new System.Drawing.Point(16, 282);
            this.Route＿Display.Name = "Route＿Display";
            this.Route＿Display.Size = new System.Drawing.Size(89, 12);
            this.Route＿Display.TabIndex = 26;
            this.Route＿Display.Text = "空欄（合計時間）";
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 432);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Route＿Display);
            this.Controls.Add(this.Route_Display);
            this.Controls.Add(this.Read_file);
            this.Controls.Add(this.close_botton);
            this.Controls.Add(this.axExpDiaStationNameEdit22);
            this.Controls.Add(this.axExpDiaStationNameEdit21);
            this.Controls.Add(this.search_result_botton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "経路入出力画面";
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
        private System.Windows.Forms.Button close_botton;
        private System.Windows.Forms.Button Read_file;
        private System.Windows.Forms.Label Route_Display;
        private System.Windows.Forms.Label Route＿Display;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_result_botton;
    }
}

