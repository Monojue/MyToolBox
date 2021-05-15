namespace MyToolBox {
    partial class Form3 {
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
            this.rtNocheck = new System.Windows.Forms.RichTextBox();
            this.rtList = new System.Windows.Forms.RichTextBox();
            this.tbpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtNo
            // 
            this.rtNo.Location = new System.Drawing.Point(12, 61);
            this.rtNo.Name = "rtNo";
            this.rtNo.Size = new System.Drawing.Size(159, 377);
            this.rtNo.TabIndex = 0;
            this.rtNo.Text = "";
            // 
            // rtNocheck
            // 
            this.rtNocheck.Location = new System.Drawing.Point(177, 61);
            this.rtNocheck.Name = "rtNocheck";
            this.rtNocheck.Size = new System.Drawing.Size(300, 377);
            this.rtNocheck.TabIndex = 1;
            this.rtNocheck.Text = "";
            // 
            // rtList
            // 
            this.rtList.Location = new System.Drawing.Point(483, 61);
            this.rtList.Name = "rtList";
            this.rtList.Size = new System.Drawing.Size(312, 377);
            this.rtList.TabIndex = 2;
            this.rtList.Text = "";
            // 
            // tbpath
            // 
            this.tbpath.Location = new System.Drawing.Point(12, 23);
            this.tbpath.Name = "tbpath";
            this.tbpath.Size = new System.Drawing.Size(673, 19);
            this.tbpath.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "New PDF List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Old PDF List";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label4";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpath);
            this.Controls.Add(this.rtList);
            this.Controls.Add(this.rtNocheck);
            this.Controls.Add(this.rtNo);
            this.Name = "Form3";
            this.Text = "Rename the Existing File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtNo;
        private System.Windows.Forms.RichTextBox rtNocheck;
        private System.Windows.Forms.RichTextBox rtList;
        private System.Windows.Forms.TextBox tbpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
    }
}