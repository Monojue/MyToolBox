using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoText {
    public partial class csExporter : UserControl {
        public csExporter() {
            InitializeComponent();
        }

        string output = "";
        string name = "";
        string pdf = "";
        Boolean next = false;

        private void btnRun_Click(object sender, EventArgs e) {
            output = "#region Test\n\n";
            name = "";
            pdf = "";
            next = false;

            for (int i = 0; i < rtNo.Lines.Count(); i++) {

                name = rtNo.Lines[i].TrimEnd();
                if (pdf.Equals("")) {
                    pdf = rtList.Lines[i];
                }

                try {
                    if (rtNo.Lines[i].Equals(rtNo.Lines[i + 1])) {
                        next = true;
                    } else {
                        next = false;
                    }
                } catch (Exception) {
                    next = false;
                }

                if (next) {
                    pdf += "\" + \"*\" + @\"" + rtList.Lines[i + 1];
                } else {


                    switch(cbox.SelectedIndex){

                        case (0):
                            output += "[Test]\n" +
            "\t\tpublic void Test" + name + "() {\n" +
                    "\t\t\tstring wTestName = @\"" + name + "\";\n" +
                    "\t\t\tstring wTorikomiFile =   @\"" + pdf + "\";\n" +
                    "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
                    "\t\t\twTorikomiTest.ExecAdditionalTest(FInFilePath);\n" +
                "\t\t}\n\n";
                            break;

                        case (1):
                            output += "[Test]\n" +
            "\t\tpublic void Test" + name + "() {\n" +
                    "\t\t\tstring wTestName = @\"" + name + "\";\n" +
                    "\t\t\tstring wTorikomiFile =   @\"" + pdf + "\";\n" +
                    "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
                    "\t\t\twTorikomiTest.ExecAdditionalTest(FInFilePath);\n" +
                "\t\t}\n\n";
                            break;

                        case (2):
                            output += "[Test]\n" +
            "\t\tpublic void Test" + name + "() {\n" +
                    "\t\t\tstring wTestName = @\"" + name + "\";\n" +
                    "\t\t\tstring wTorikomiFile =   @\"" + pdf + "\";\n" +
                    "\t\t\tTorikomiTest wTorikomiTest = new TorikomiTest(FOutFilePath, FSekkeishoPath, wTestName, FShoshikiName + SekkeiTorikomiDefine.C_INIEXT_S, wTorikomiFile);\n" +
                    "\t\t\twTorikomiTest.ExecAdditionalTest(FInFilePath);\n" +
                "\t\t}\n\n";
                            break;

                    }

                    name = "";
                    pdf = "";

                }
            }

            output += "#endregion Test";
            rtOuput.Text = output;
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(rtOuput.Text);
        }

        private void rtNo_TextChanged(object sender, EventArgs e) {
            lblC1.Text = rtNo.Lines.Count().ToString();
        }

        private void rtList_TextChanged(object sender, EventArgs e) {
            lblC2.Text = rtList.Lines.Count().ToString();
        }
    }
}
