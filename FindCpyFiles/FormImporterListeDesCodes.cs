using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindCpyFiles
{
    public partial class FormImporterListeDesCodes : Form
    {
        public string[] tabDesCodes;
        Form1 fpere;

        public FormImporterListeDesCodes()
        {
            InitializeComponent();
            
        }

        //pour créer un lien vers le formulaire pére
        public void setRef()
        {
            fpere = (Form1)this.Tag;
        }

        private void buttonColler_Click(object sender, EventArgs e)
        {

            string text;
            if (Clipboard.ContainsText())
            {
                text = Clipboard.GetText(TextDataFormat.Text);

                //  the following could have been done simpler with
                //  a Regex, but the regular expression would be not
                //  exactly simple

                if (text.Length > 1)
                {
                    this.textBox1.Text = "";
                    this.textBox1.Text = text;
                    //  unify all line breaks to \r
                    
                }
            }

        }

        private void buttonOkImporter_Click(object sender, EventArgs e)
        {
            String text = this.textBox1.Text;
            text = text.Replace("\r\n", "\r").Replace("\n", "\r");
            //  create an array of lines
            tabDesCodes = text.Split('\r');
            text = "";
            fpere.importerNumFactures(tabDesCodes);
            this.Hide();
        }

        private void FormImporterListeDesCodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
