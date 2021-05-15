namespace PDFtoText {
    partial class csExporter {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtOuput = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtList = new System.Windows.Forms.RichTextBox();
            this.rtNo = new System.Windows.Forms.RichTextBox();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(804, 9);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(11, 12);
            this.lblC2.TabIndex = 20;
            this.lblC2.Text = "0";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(285, 9);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(11, 12);
            this.lblC1.TabIndex = 19;
            this.lblC1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = ".cs export";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "File Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(740, 426);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy All";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtOuput
            // 
            this.rtOuput.Location = new System.Drawing.Point(21, 259);
            this.rtOuput.Name = "rtOuput";
            this.rtOuput.Size = new System.Drawing.Size(794, 161);
            this.rtOuput.TabIndex = 14;
            this.rtOuput.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(649, 426);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtList
            // 
            this.rtList.Location = new System.Drawing.Point(313, 24);
            this.rtList.Name = "rtList";
            this.rtList.Size = new System.Drawing.Size(502, 217);
            this.rtList.TabIndex = 12;
            this.rtList.Text = "";
            this.rtList.TextChanged += new System.EventHandler(this.rtList_TextChanged);
            // 
            // rtNo
            // 
            this.rtNo.Location = new System.Drawing.Point(21, 24);
            this.rtNo.Name = "rtNo";
            this.rtNo.Size = new System.Drawing.Size(275, 217);
            this.rtNo.TabIndex = 11;
            this.rtNo.Text = "";
            this.rtNo.TextChanged += new System.EventHandler(this.rtNo_TextChanged);
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "Additional_S",
            "_TorikomiKoji_S",
            "TorikomiTest_S"});
            this.cbox.Location = new System.Drawing.Point(501, 429);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(121, 20);
            this.cbox.TabIndex = 21;
            // 
            // csExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.rtOuput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rtList);
            this.Controls.Add(this.rtNo);
            this.Name = "csExporter";
            this.Size = new System.Drawing.Size(829, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RichTextBox rtOuput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtList;
        private System.Windows.Forms.RichTextBox rtNo;
        private System.Windows.Forms.ComboBox cbox;
    }
}
