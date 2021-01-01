namespace GUI
{
    partial class frm_BCDSMH_Tungay_Denngay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDayStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDayEnd = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDayStart
            // 
            this.txtDayStart.CustomFormat = "dd/MM/yyyy";
            this.txtDayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDayStart.Location = new System.Drawing.Point(23, 102);
            this.txtDayStart.Name = "txtDayStart";
            this.txtDayStart.Size = new System.Drawing.Size(200, 22);
            this.txtDayStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDayEnd
            // 
            this.txtDayEnd.CustomFormat = "dd/MM/yyyy";
            this.txtDayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDayEnd.Location = new System.Drawing.Point(296, 102);
            this.txtDayEnd.Name = "txtDayEnd";
            this.txtDayEnd.Size = new System.Drawing.Size(200, 22);
            this.txtDayEnd.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(156, 161);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 37);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frm_BCDSMH_Tungay_Denngay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(526, 229);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtDayEnd);
            this.Controls.Add(this.txtDayStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_BCDSMH_Tungay_Denngay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BCDSMH_Tungay_Denngay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDayStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDayEnd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
    }
}