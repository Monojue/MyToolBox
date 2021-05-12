using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDFtoText {
    public partial class TempForm : UserControl {
        public TempForm() {
            InitializeComponent();
            cbCopy.Checked = true;
            cbox.SelectedIndex = 0;
        }

        int i = 0;
        Boolean copy = true;
        string dir = "";
        string nextdir = "";

        private void btnBack_Click(object sender, EventArgs e) {
            try {
                tbInput.Text = tbInput.Text.Replace('"', ' ');
            } catch (Exception) {
            }

            if (i <= 1) {
                i = tbInput.Lines.Count();
            } else {
                i--;
            }

            try {
                dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                nextdir = Path.GetDirectoryName(tbInput.Lines[i - 2]);
            } catch (IndexOutOfRangeException) {
                dir = Path.GetDirectoryName(tbInput.Lines[tbInput.Lines.Count() - 1]);
            }

            if (dir.Equals(nextdir)) {
                while (dir.Equals(nextdir)) {
                    i--;
                    try {
                        dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                        nextdir = Path.GetDirectoryName(tbInput.Lines[i - 2]);
                    } catch (IndexOutOfRangeException) {
                        dir = Path.GetDirectoryName(tbInput.Lines[tbInput.Lines.Count()]);
                    }
                }
                tbShow.Text = tbInput.Lines[i - 1];
                lblnof.Text = "Group";
                if (copy) Clipboard.SetText(dir);
            } else {
                tbShow.Text = tbInput.Lines[i - 1];
                lblnof.Text = "";
                if (copy) Clipboard.SetText(tbShow.Text);
            }
            lblI.Text = i.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            try {
                tbInput.Text = tbInput.Text.Replace('"', ' ');
            } catch (Exception) {
            }

            if (i == tbInput.Lines.Count()) {
                i = 1;
            } else {
                i++;
            }

            try {
                dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                nextdir = Path.GetDirectoryName(tbInput.Lines[i]);
            } catch (IndexOutOfRangeException) {
                nextdir = Path.GetDirectoryName(tbInput.Lines[0]);
            }

            if (dir.Equals(nextdir)) {
                while (dir.Equals(nextdir)) {
                    i++;
                    try {
                        dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                        nextdir = Path.GetDirectoryName(tbInput.Lines[i]);
                    } catch (IndexOutOfRangeException) {
                        nextdir = Path.GetDirectoryName(tbInput.Lines[0]);
                    }
                }
                tbShow.Text = tbInput.Lines[i - 1];
                lblnof.Text = "Group";
                if (copy) Clipboard.SetText(dir);
            } else {
                tbShow.Text = tbInput.Lines[i - 1];
                lblnof.Text = "";
                if (copy) Clipboard.SetText(tbShow.Text);
            }
            lblI.Text = i.ToString();
        }

        String dispath = "";
        String frompath = "";
        string fileName = null;
        string root = @"C:\ProgramData\CoBeing\GaiaCloud\Temp";

        private void btnMove_Click(object sender, EventArgs e) {
            try {
                dispath = tbPath.Text;
                string[] sub = Directory.GetDirectories(root);
                frompath = sub[sub.Count() - 1] + @"\" + cbox.Text + ".csv";
                if (tbNo.Lines.Count() == 0) {
                    try {
                        fileName = Path.GetFileNameWithoutExtension(tbShow.Text.Replace('"', ' ').TrimEnd());
                    } catch (Exception) {
                        fileName = Path.GetFileNameWithoutExtension(tbShow.Text);
                    }
                    // Directory.CreateDirectory(dispath + @"\" + i);
                    File.Copy(frompath, dispath + @"\" + i + "_" + fileName + ".csv");
                } else {
                    fileName = tbNo.Lines[int.Parse(lblI.Text) - 1];
                    File.Copy(frompath, dispath + @"\" + fileName + ".csv");
                }
                lblMove.Text = fileName;
            } catch (IOException) {
                MessageBox.Show("Error Occoured!");
            }
        }

        private void tbShow_TextChanged(object sender, EventArgs e) {
            try {
                lblfilename.Text = Path.GetFileNameWithoutExtension(tbShow.Text.Replace('"', ' ').TrimEnd());
            } catch (Exception) {
                lblfilename.Text = Path.GetFileNameWithoutExtension(tbShow.Text);
            }
        }

        private void tbNo_TextChanged(object sender, EventArgs e) {
            lblC1.Text = tbNo.Lines.Count().ToString();
        }

        private void tbInput_TextChanged(object sender, EventArgs e) {
            lblC2.Text = tbInput.Lines.Count().ToString();
        }

        private void cbCopy_CheckedChanged(object sender, EventArgs e) {
            copy = cbCopy.Checked;
        }
    }
}
