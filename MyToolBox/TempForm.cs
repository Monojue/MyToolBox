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
using System.Diagnostics;

namespace MyToolBox {
    public partial class TempForm : UserControl {
        public TempForm() {
            InitializeComponent();
            cbCopy.Checked = true;
            cbox.SelectedIndex = 0;
            lblnof.Text = "";
        }

        int i = 0;
        Boolean copy = true;
        Boolean groupCheck = false;
        string dir = "";
        string nextdir = "";
        List<int> groupFile = new List<int>();
        RichTextBoxScrollBars scroll = new RichTextBoxScrollBars();

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

            if (dir.Equals(nextdir) && groupCheck) {
                while (dir.Equals(nextdir)) {
                    groupFile.Add(i - 1);
                    i--;
                    try {
                        dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                        nextdir = Path.GetDirectoryName(tbInput.Lines[i - 2]);
                    } catch (IndexOutOfRangeException) {
                        dir = Path.GetDirectoryName(tbInput.Lines[tbInput.Lines.Count()-1]);
                    }
                }
                tbShow.Text = tbInput.Lines[i - 1];
                refreshtbInput();
                lblnof.Text = "Group";
                if (copy) Clipboard.SetText(dir);
            } else {
                tbShow.Text = tbInput.Lines[i - 1];
                scroll = tbInput.ScrollBars;
                refreshtbInput();
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

            if (dir.Equals(nextdir) && groupCheck) {
                while (dir.Equals(nextdir)) {
                    groupFile.Add(i - 1);
                    i++;
                    try {
                        dir = Path.GetDirectoryName(tbInput.Lines[i - 1]);
                        nextdir = Path.GetDirectoryName(tbInput.Lines[i]);
                    } catch (IndexOutOfRangeException) {
                        nextdir = Path.GetDirectoryName(tbInput.Lines[0]);
                    }
                }
                tbShow.Text = tbInput.Lines[i - 1];
                refreshtbInput();
                lblnof.Text = "Group";
                if (copy) Clipboard.SetText(dir);
            } else {
                tbShow.Text = tbInput.Lines[i - 1];
                scroll = tbInput.ScrollBars;
                refreshtbInput();
                lblnof.Text = "";
                if (copy) Clipboard.SetText(tbShow.Text);
            }
            lblI.Text = i.ToString();
        }

        String dispath = "";
        String frompath = "";
        string fileName = null;
        string root = @"C:\ProgramData\CoBeing\GaiaCloud\Temp";
        List<int> movedfile = new List<int>();

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
                movedfile.Add(i-1);
                refreshtbInput();
                if (cbAuto.Checked) btnNext_Click(sender, e);
            } catch (IOException) {
                MessageBox.Show("Error Occoured!");
            }
        }

        private void refreshtbInput(){
            string[] Lines = new string[0];
            Lines = tbInput.Lines;
            tbInput.Clear();
            
            for (int j = 0; j <= Lines.Count() - 1; j++) {

                if (tbShow.Text.Equals(Lines[j]) || groupFile.Contains(j))
                    tbInput.SelectionColor = Color.Red;

                if (movedfile.Contains(j))
                    tbInput.SelectionColor = Color.Green;

                if (movedfile.Contains(j) && tbShow.Text.Equals(Lines[j]))
                    tbInput.SelectionColor = Color.Blue;

                if (j < Lines.Count() - 1)
                    tbInput.AppendText(Lines[j] + "\r\n");
                else
                    tbInput.AppendText(Lines[j]);

                tbInput.ScrollBars = scroll;
            }
            groupFile.Clear();
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

        private void btnOpenFile_Click(object sender, EventArgs e) {
            Process.Start(tbShow.Text);
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e) {
            btnNext.Enabled = !cbAuto.Checked;
            btnBack.Enabled = !cbAuto.Checked;
        }

        private void cbGcheck_CheckedChanged(object sender, EventArgs e) {
            groupCheck = cbGcheck.Checked;
            groupFile.Clear();
        }

        private void btnOpenTemp_Click(object sender, EventArgs e) {
            Process.Start(tbPath.Text);
        }
    }
}
