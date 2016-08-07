using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEC_GUI_ledMatrix;

namespace WindowsFormsApplication4
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowsFormsApplication1.Form1 myForm1 = new WindowsFormsApplication1.Form1();
            myForm1.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 myForm2 = new TEC_GUI_ledMatrix.Form2();
            myForm2.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1 myForm1 = new WindowsFormsApplication1.Form1();
            myForm1.Show();
            this.Hide();
        }

        private void univeralGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new TEC_GUI_ledMatrix.Form2();
            myForm2.Show();
            this.Hide();
        }
    }
}
