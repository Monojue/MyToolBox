namespace MyToolBox
{
    partial class EntityBuilder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.richTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 502);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(216, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(613, 502);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.btnBuild);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbFormat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAccess);
            this.panel2.Controls.Add(this.cbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 502);
            this.panel2.TabIndex = 0;
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "Constants Entity"});
            this.cbox.Location = new System.Drawing.Point(6, 17);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(207, 21);
            this.cbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Access Modifier";
            // 
            // tbAccess
            // 
            this.tbAccess.Location = new System.Drawing.Point(6, 74);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.Size = new System.Drawing.Size(207, 20);
            this.tbAccess.TabIndex = 3;
            this.tbAccess.Text = "public static final String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Variable Format";
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(6, 121);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(207, 20);
            this.tbFormat.TabIndex = 5;
            this.tbFormat.Text = "CSV_FIELD";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(138, 461);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 7;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(6, 153);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "lblError";
            // 
            // EntityBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EntityBuilder";
            this.Size = new System.Drawing.Size(829, 502);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblError;
    }
}
