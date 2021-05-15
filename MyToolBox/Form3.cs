using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoText {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            for(int i=0; i<rtNocheck.Lines.Count(); i++){
                for(int j=0; j<rtList.Lines.Count(); j++){
                    if(rtNocheck.Lines[i].Equals(rtList.Lines[j])){
                        try{
                            string fileName = Path.GetFileNameWithoutExtension(rtList.Lines[j]);
                            string root = tbpath.Text + @"\";
                            string surfile = root + (j) +"_"+ fileName + ".csv";
                            string rename = root + rtNo.Lines[i] + ".csv";
                            File.Move(surfile, rename);
                            lblName.Text = fileName;
                            break;
                        }catch(Exception){
                            break;
                        }
                    }
                }
            }
        }
    }
}
