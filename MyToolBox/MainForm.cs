using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoText {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            TempForm tempForm = new TempForm();
            AddNewTab(tempForm, "Temp Control");

            csExporter csForm = new csExporter();
            AddNewTab(csForm, ".CS Exporter");
        }

        private void AddNewTab(UserControl frm, string name) {

            TabPage tab = new TabPage(name);
            frm.Parent = tab;
            frm.Visible = true;
            tabControl.TabPages.Add(tab);
            //frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);
            //tabControl.SelectedTab = tab;
        }
    }
}
