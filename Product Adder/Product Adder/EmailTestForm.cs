using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Adder
{
    public partial class EmailTestForm : Form
    {
        private string oneP;

        public EmailTestForm()
        {
            InitializeComponent();
            GenerateData();
        }

        private void GenerateData()
        {
            tbContent.Clear();
            List<CheckBox> cbs = new List<CheckBox>();
            var client = new WebClient();
            string text = client.DownloadString("https://randomtextgenerator.com/");
            string p = text.Substring((text.IndexOf("generatedtext") + 15), (text.IndexOf("</textarea>") - text.IndexOf("generatedtext") - 18));
            oneP = p.Substring(0, p.IndexOf("\n\r"));
            tbActual.Text = oneP;
        }

        private void BtnPerWord_Click(object sender, EventArgs e)
        {
            GenerateData();

            int value = 1;
            string word = "";
            for (int i = 0; i < oneP.Length; i++)
            {
                if (oneP[i] != ' ')
                    word += oneP[i];
                else
                {
                    tbContent.Text += word + " ";
                    if (value == nudWord.Value)
                    {
                        tbContent.Text += "\r\n";
                        value = 0;
                    }
                    word = "";
                    value++;
                }
            }
        }

        private void BtnPerChar_Click(object sender, EventArgs e)
        {
            GenerateData();

            string line = "";
            string word = "";
            for (int i = 0; i < oneP.Length; i++)
            {
                if (oneP[i] != ' ')
                    word += oneP[i];
                else
                {
                    if (line.Length + word.Length >= nudChar.Value)
                    {
                        tbContent.Text += line;
                        tbContent.Text += "\r\n";
                        line = word + " ";
                    }
                    else
                        line += word + " ";
                    word = "";
                }
            }
            tbContent.Text += line;
        }
    }
}
