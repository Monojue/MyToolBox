namespace MyToolBox {
    partial class TempForm {
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
            this.btnBack = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbShow = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.cbCopy = new System.Windows.Forms.CheckBox();
            this.lblnof = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.RichTextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.lblfilename = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.cbGcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(651, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(191, 59);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(298, 19);
            this.tbPath.TabIndex = 21;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(622, 57);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(104, 23);
            this.btnMove.TabIndex = 20;
            this.btnMove.Text = "TempToFolder";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(732, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbShow
            // 
            this.tbShow.Location = new System.Drawing.Point(31, 30);
            this.tbShow.Name = "tbShow";
            this.tbShow.Size = new System.Drawing.Size(611, 19);
            this.tbShow.TabIndex = 18;
            this.tbShow.TextChanged += new System.EventHandler(this.tbShow_TextChanged);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(226, 94);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(581, 351);
            this.tbInput.TabIndex = 17;
            this.tbInput.Text = "";
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
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
            this.cbox.Location = new System.Drawing.Point(495, 59);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(121, 20);
            this.cbox.TabIndex = 31;
            // 
            // cbCopy
            // 
            this.cbCopy.AutoSize = true;
            this.cbCopy.Location = new System.Drawing.Point(703, 12);
            this.cbCopy.Name = "cbCopy";
            this.cbCopy.Size = new System.Drawing.Size(74, 16);
            this.cbCopy.TabIndex = 30;
            this.cbCopy.Text = "AutoCopy";
            this.cbCopy.UseVisualStyleBackColor = true;
            this.cbCopy.CheckedChanged += new System.EventHandler(this.cbCopy_CheckedChanged);
            // 
            // lblnof
            // 
            this.lblnof.AutoSize = true;
            this.lblnof.Location = new System.Drawing.Point(453, 13);
            this.lblnof.Name = "lblnof";
            this.lblnof.Size = new System.Drawing.Size(17, 12);
            this.lblnof.TabIndex = 29;
            this.lblnof.Text = "\"\"";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(226, 79);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(11, 12);
            this.lblC2.TabIndex = 28;
            this.lblC2.Text = "0";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(29, 79);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(11, 12);
            this.lblC1.TabIndex = 27;
            this.lblC1.Text = "0";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(31, 52);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(51, 12);
            this.lblMove.TabIndex = 26;
            this.lblMove.Text = "MoveFile";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(22, 94);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(198, 351);
            this.tbNo.TabIndex = 25;
            this.tbNo.Text = "";
            this.tbNo.TextChanged += new System.EventHandler(this.tbNo_TextChanged);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(31, 13);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(8, 12);
            this.lblI.TabIndex = 24;
            this.lblI.Text = "i";
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(52, 13);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(48, 12);
            this.lblfilename.TabIndex = 23;
            this.lblfilename.Text = "filename";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(732, 57);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 32;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(622, 12);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(75, 16);
            this.cbAuto.TabIndex = 33;
            this.cbAuto.Text = "AutoMode";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // cbGcheck
            // 
            this.cbGcheck.AutoSize = true;
            this.cbGcheck.Location = new System.Drawing.Point(519, 12);
            this.cbGcheck.Name = "cbGcheck";
            this.cbGcheck.Size = new System.Drawing.Size(86, 16);
            this.cbGcheck.TabIndex = 34;
            this.cbGcheck.Text = "GroupCheck";
            this.cbGcheck.UseVisualStyleBackColor = true;
            this.cbGcheck.CheckedChanged += new System.EventHandler(this.cbGcheck_CheckedChanged);
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGcheck);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbShow);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.cbCopy);
            this.Controls.Add(this.lblnof);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblfilename);
            this.Name = "TempForm";
            this.Size = new System.Drawing.Size(829, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbShow;
        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.CheckBox cbCopy;
        private System.Windows.Forms.Label lblnof;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.RichTextBox tbNo;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbGcheck;
    }
}
