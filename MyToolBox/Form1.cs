using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Threading;

using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using IFilter;

namespace PDFtoText
{
    public partial class Form1 : Form
    {

        string finaltext;
        int lib;
        List<string> sptext;
       

       
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files(*.pdf)|*.pdf";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = of.FileName.ToString();
            }
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (lib == 0)
                {
                    pdfbox();
                }
                else if (lib == 1)
                {
                    iTextSharp();
                }
                else if (lib == 2)
                {
                    ifilt();
                }
                   
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void pdfbox()
        {
            for (int i = 0; i <= 100; i += 100)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(i);
                    finaltext = PDFText(textPath.Text);
                }
            }
        }

        //public void iTextSharp()
        //{
        //    using (PdfReader reader = new PdfReader(textPath.Text))
        //    {
        //        StringBuilder bulider = new StringBuilder();
        //        for (int i = 1; i <= reader.NumberOfPages; i++)
        //        {
        //            if (!backgroundWorker.CancellationPending)
        //            {
        //                backgroundWorker.ReportProgress((i * 100) / reader.NumberOfPages);
        //                //pagefromtext = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding., reader.GetPageContent(i)));
                        
        //                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
        //                string currentText = PdfTextExtractor.GetTextFromPage(reader, i, strategy);
        //                pagefromtext = Encoding.Unicode.GetString(UnicodeEncoding.Convert(Encoding.Unicode, Encoding.Unicode, Encoding.Unicode.GetBytes(currentText)));
        //                finaltext = pagefromtext;
                        

        //            }
        //        }

        //    }
        //}

        public void ifilt()
        {
            for (int i = 0; i <= 100; i += 100)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(i);
                    finaltext = DefaultParser.Extract(textPath.Text);
                }
            }
               
        }

        public static string ExtractTextFromPdf(string path)
        {
            return DefaultParser.Extract(path);
        }

        public void iTextSharp()
        {
            using (PdfReader reader = new PdfReader(textPath.Text))
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress((i * 100) / reader.NumberOfPages);
                        //bulider.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                        string s = PdfTextExtractor.GetTextFromPage(reader, i, its);
                        //s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                        builder.Append(s);
                    }
                }
                dataextract(builder.ToString());
                //finaltext = getdata("Construction Name");
                finaltext = builder.ToString();
            }
        }

        public void dataextract(string data)
        {
            sptext = data.Split(new[] { "\n" }, StringSplitOptions.None).ToList();
        }

        public string getdata(string key)
        {
            for (int i = 0; i < sptext.Count; i++)
            {
                if (sptext[i].Contains(key))
                {
                    return sptext[i-1];
                }
            }
            return "Empty";
        }

        public String PDFText(String PDFFilePath)
        {
            PDDocument doc = PDDocument.load(PDFFilePath);
            PDFTextStripper stripper = new PDFTextStripper();
            string text = stripper.getText(doc);
            doc.close();
            return text;
        }

        //public void iTextWithSt()
        //{
        //    PdfReader reader = new PdfReader(textPath.Text);

        //    for (int page = 1; page < reader.NumberOfPages; page++)
        //    {
        //        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy();
        //        string s = PdfTextExtractor.GetTextFromPage(reader, page, its);

        //        s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
        //        text = s;
        //    }
        //    reader.Close();
        //} 

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
            pbar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Rtext.Text = finaltext;
            
            MessageBox.Show("Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lib = cbox.SelectedIndex;
        }
        List<string> list = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            //Rtext.Text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(finaltext)));
           


            for (int i = 0; i < sptext.Count; i++)
            {
                if (sptext[i].Contains("Construction period"))
                {
                    list.Add(sptext[i].Substring(sptext[i].IndexOf("自")+2, 10));
                    list.Add(sptext[i].Substring(sptext[i].IndexOf("至")+2, 10));
                    list.Add(sptext[i].Substring(sptext[i].IndexOf("施工日数：")+6).Replace("Days", ""));
                }
            }



        }



    }
}
