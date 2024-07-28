using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyToolBox
{
    public partial class EntityBuilder : UserControl
    {
        public EntityBuilder()
        {
            InitializeComponent();
            lblError.Text = "";
            cbox.SelectedIndex = 0;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string label = $"{tbAccess.Text} {tbFormat.Text}";
            StringBuilder sb = new StringBuilder();
            lblError.Text = "";
            if (tbFormat.Text == "" || tbAccess.Text == "")
            {
                lblError.Text = "Please insert fields!";
                return;
            };

            if (!tbFormat.Text.Contains("_"))
            {
                lblError.Text = "Variable Format must contains \"_\"";
                return;
            }

            for (int i = 1; i <= richTextBox.Lines.Count(); i++) {
                string txtLine = richTextBox.Lines[i-1].Trim();
                if (txtLine.Length == 0) continue; 
                string comment = $"\r\n/**\r\n* {tbFormat.Text.Substring(0,tbFormat.Text.IndexOf("_"))}項目： {txtLine}ﾞ\r\n*/\r\n";
                sb.Append($"{comment}{label}{i.ToString().PadLeft(3, '0')} = \"{txtLine}\";\r\n");
            }

            richTextBox.Text = sb.ToString();

        }
    }
}
