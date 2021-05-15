namespace PDFtoText
{
    partial class Form1
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
            this.Rtext = new System.Windows.Forms.RichTextBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtext
            // 
            this.Rtext.Location = new System.Drawing.Point(12, 43);
            this.Rtext.Name = "Rtext";
            this.Rtext.Size = new System.Drawing.Size(607, 352);
            this.Rtext.TabIndex = 0;
            this.Rtext.Text = "";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(12, 413);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(523, 19);
            this.textPath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(544, 452);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(12, 452);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(443, 23);
            this.pbar.TabIndex = 4;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(463, 452);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbox
            // 
            this.cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "PDFbox",
            "ItextSharp",
            "St"});
            this.cbox.Location = new System.Drawing.Point(86, 12);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(121, 20);
            this.cbox.TabIndex = 6;
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Lib :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.Rtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF to Text Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtext;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar pbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

