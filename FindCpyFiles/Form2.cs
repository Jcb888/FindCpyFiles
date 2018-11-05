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
    public partial class Form2 : Form
    {
        Form1 fpere;

        public Form2()
        {
            InitializeComponent();
        }

        private void checkBoxTest1_CheckedChanged(object sender, EventArgs e)
        {
            if(fpere != null)
                fpere.setCOcheckTest1(checkBoxTest1.Checked);
        }

        public void setRef()
        {
            fpere = (Form1) this.Tag; 
        }
        
        private void checkBoxtest2_CheckedChanged(object sender, EventArgs e)
        {
            if (fpere != null)
                fpere.setCOcheckTest2(checkBoxtest2.Checked);
        }

        private void comboBoxCommencePar_KeyDown(object sender, KeyEventArgs e)
        {
            string s = comboBoxCommencePar.Text;
            if (e.KeyCode == Keys.Enter)
            {
                fpere.ajouterListCommencePar();
            }
        }

        private void comboBoxContient_KeyDown(object sender, KeyEventArgs e)
        {
            string s = comboBoxContient.Text;
            if (e.KeyCode == Keys.Enter)
            {
                fpere.ajouterListContient();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            fpere.ajouterListCommencePar();
            fpere.ajouterListContient();

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void buttonCommencePar_Click(object sender, EventArgs e)
        {

            if (comboBoxCommencePar.SelectedIndex != -1)
            {
                fpere.getCO().listCommencePar.RemoveAll(x => x.myValue.Contains(this.comboBoxCommencePar.Text));
                comboBoxCommencePar.Items.RemoveAt(comboBoxCommencePar.SelectedIndex);
                comboBoxCommencePar.SelectedIndex = 0;
            }
        }

        public bool OneLineChecked()
        {
            return this.radioButton1.Checked;
        }
        public void setOneLineChecked()
        {
            this.radioButton1.Checked = true;
        }

        private void buttonContient_Click(object sender, EventArgs e)
        {

            if (comboBoxContient.SelectedIndex != -1)
            {
                fpere.getCO().ListContient.RemoveAll(x => x.myValue.Contains(this.comboBoxContient.Text));
                comboBoxContient.Items.RemoveAt(comboBoxContient.SelectedIndex);
                comboBoxContient.SelectedIndex = 0;
            }

        }

        private void textBoxNomFichierCommencePar_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNomFichierCommencePar.Text != "something")
                e.Cancel = true;
        }
    }
}
