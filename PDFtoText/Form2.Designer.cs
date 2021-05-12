namespace PDFtoText {
    partial class Form2 {
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
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.tbShow = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblfilename = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.RichTextBox();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblnof = new System.Windows.Forms.Label();
            this.cbCopy = new System.Windows.Forms.CheckBox();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(207, 87);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(581, 351);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "";
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbShow
            // 
            this.tbShow.Location = new System.Drawing.Point(12, 23);
            this.tbShow.Name = "tbShow";
            this.tbShow.Size = new System.Drawing.Size(611, 19);
            this.tbShow.TabIndex = 1;
            this.tbShow.TextChanged += new System.EventHandler(this.tbShow_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(713, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "TempToFolder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(380, 58);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(298, 19);
            this.tbPath.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(632, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(33, 6);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(48, 12);
            this.lblfilename.TabIndex = 8;
            this.lblfilename.Text = "filename";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(12, 6);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(8, 12);
            this.lblI.TabIndex = 9;
            this.lblI.Text = "i";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(3, 87);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(198, 351);
            this.tbNo.TabIndex = 10;
            this.tbNo.Text = "";
            this.tbNo.TextChanged += new System.EventHandler(this.tbNo_TextChanged);
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(12, 45);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(51, 12);
            this.lblMove.TabIndex = 11;
            this.lblMove.Text = "MoveFile";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(10, 72);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(11, 12);
            this.lblC1.TabIndex = 12;
            this.lblC1.Text = "0";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(207, 72);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(11, 12);
            this.lblC2.TabIndex = 13;
            this.lblC2.Text = "0";
            // 
            // lblnof
            // 
            this.lblnof.AutoSize = true;
            this.lblnof.Location = new System.Drawing.Point(516, 6);
            this.lblnof.Name = "lblnof";
            this.lblnof.Size = new System.Drawing.Size(17, 12);
            this.lblnof.TabIndex = 14;
            this.lblnof.Text = "\"\"";
            // 
            // cbCopy
            // 
            this.cbCopy.AutoSize = true;
            this.cbCopy.Location = new System.Drawing.Point(684, 5);
            this.cbCopy.Name = "cbCopy";
            this.cbCopy.Size = new System.Drawing.Size(74, 16);
            this.cbCopy.TabIndex = 15;
            this.cbCopy.Text = "AutoCopy";
            this.cbCopy.UseVisualStyleBackColor = true;
            this.cbCopy.CheckedChanged += new System.EventHandler(this.cbCopy_CheckedChanged);
            // 
            // cbox
            // 
            this.cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "SokatsuInfo",
            "SekkeishoJoken",
            "SekkeishoKoseihi",
            "SekkeishoRendo"});
            this.cbox.Location = new System.Drawing.Point(253, 57);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(121, 20);
            this.cbox.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.cbCopy);
            this.Controls.Add(this.lblnof);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbShow);
            this.Controls.Add(this.tbInput);
            this.Name = "Form2";
            this.Text = "Sokatsu Temp Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.TextBox tbShow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.RichTextBox tbNo;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblnof;
        private System.Windows.Forms.CheckBox cbCopy;
        private System.Windows.Forms.ComboBox cbox;
    }
}