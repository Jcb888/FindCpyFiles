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
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void checkBoxtest2_CheckedChanged(object sender, EventArgs e)
        {
            if (fpere != null)
                fpere.setCOcheckTest2(checkBoxtest2.Checked);
        }
    }
}
