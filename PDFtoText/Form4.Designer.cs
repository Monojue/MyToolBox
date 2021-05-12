namespace PDFtoText {
    partial class Form4 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtNo = new System.Windows.Forms.RichTextBox();
            this.rtList = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtOuput = new System.Windows.Forms.RichTextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtNo
            // 
            this.rtNo.Location = new System.Drawing.Point(3, 30);
            this.rtNo.Name = "rtNo";
            this.rtNo.Size = new System.Drawing.Size(275, 408);
            this.rtNo.TabIndex = 0;
            this.rtNo.Text = "";
            this.rtNo.TextChanged += new System.EventHandler(this.rtNo_TextChanged);
            // 
            // rtList
            // 
            this.rtList.Location = new System.Drawing.Point(284, 30);
            this.rtList.Name = "rtList";
            this.rtList.Size = new System.Drawing.Size(464, 408);
            this.rtList.TabIndex = 1;
            this.rtList.Text = "";
            this.rtList.TextChanged += new System.EventHandler(this.rtList_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(984, 415);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtOuput
            // 
            this.rtOuput.Location = new System.Drawing.Point(754, 30);
            this.rtOuput.Name = "rtOuput";
            this.rtOuput.Size = new System.Drawing.Size(396, 379);
            this.rtOuput.TabIndex = 4;
            this.rtOuput.Text = "";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1075, 415);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy All";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = ".cs export";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(219, 15);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(11, 12);
            this.lblC1.TabIndex = 9;
            this.lblC1.Text = "0";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(682, 15);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(11, 12);
            this.lblC2.TabIndex = 10;
            this.lblC2.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtNo;
        private System.Windows.Forms.RichTextBox rtList;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtOuput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblC2;
    }
}