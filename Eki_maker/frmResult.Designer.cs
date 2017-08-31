namespace Eki_maker
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.axExpDiaShowCoursePanel131 = new AxEXPDCTRL2Lib.AxExpDiaShowCoursePanel13();
            this.botton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaShowCoursePanel131)).BeginInit();
            this.SuspendLayout();
            // 
            // axExpDiaShowCoursePanel131
            // 
            this.axExpDiaShowCoursePanel131.Enabled = true;
            this.axExpDiaShowCoursePanel131.Location = new System.Drawing.Point(12, 12);
            this.axExpDiaShowCoursePanel131.Name = "axExpDiaShowCoursePanel131";
            this.axExpDiaShowCoursePanel131.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axExpDiaShowCoursePanel131.OcxState")));
            this.axExpDiaShowCoursePanel131.Size = new System.Drawing.Size(654, 335);
            this.axExpDiaShowCoursePanel131.TabIndex = 0;
            // 
            // botton1
            // 
            this.botton1.Location = new System.Drawing.Point(489, 362);
            this.botton1.Name = "botton1";
            this.botton1.Size = new System.Drawing.Size(177, 62);
            this.botton1.TabIndex = 1;
            this.botton1.Text = "保存";
            this.botton1.UseVisualStyleBackColor = true;
            this.botton1.Click += new System.EventHandler(this.btn_Write_Json);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.botton1);
            this.Controls.Add(this.axExpDiaShowCoursePanel131);
            this.Name = "frmResult";
            this.Text = "frmResult";
            ((System.ComponentModel.ISupportInitialize)(this.axExpDiaShowCoursePanel131)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxEXPDCTRL2Lib.AxExpDiaShowCoursePanel13 axExpDiaShowCoursePanel131;
        private System.Windows.Forms.Button botton1;
    }
}