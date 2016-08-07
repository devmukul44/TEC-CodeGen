using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication4;

namespace TEC_GUI_ledMatrix
{
    public partial class Form2 : Form
    {

        string start = @"int main(void)
{
	DDRC =0xFF;
	DDRD =0xFF;
    // This program requires D Port connected to +ve end and C Port to negetive end.
  while(1)
 {  uint8_t x=255;
	 while(x>0)
   	{
";
        
        string end = @"}
       
          } // end of while1
       }";
        
        String code = @" ";


        public Form2()
        {
            
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            button63.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            button62.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            button61.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            button60.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            button59.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            button58.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.BackColor = Color.Blue;         
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            button64.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 0); _delay_ms(dl);\n";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 1); _delay_ms(dl);\n";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 2); _delay_ms(dl);\n";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 3); _delay_ms(dl);\n";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 4); _delay_ms(dl);\n";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 5); _delay_ms(dl);\n";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 3); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 2); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 1); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 0); PORTD = (1 << 6); _delay_ms(dl);\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 7); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 6); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 5); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Blue;
            code = code + " PORTC = ~(1 << 4); PORTD = (1 << 7); _delay_ms(dl);\n";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = start;
            richTextBox1.Text = richTextBox1.Text+code;
            richTextBox1.Text = richTextBox1.Text+end;

            code = "";
            
            /*for(int i=0;i<64;i++)
            {
                button57.BackColor = Color.Blue;           
            }*/

            /*button1.BackColor = Color.Khaki;
            button2.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button4.BackColor = Color.Khaki;
            button5.BackColor = Color.Khaki;
            button6.BackColor = Color.Khaki;
            button7.BackColor = Color.Khaki;
            button8.BackColor = Color.Khaki;
            button9.BackColor = Color.Khaki;
            button10.BackColor = Color.Khaki;
            button11.BackColor = Color.Khaki;
            button12.BackColor = Color.Khaki;
            button13.BackColor = Color.Khaki;
            button14.BackColor = Color.Khaki;
            button15.BackColor = Color.Khaki;
            button16.BackColor = Color.Khaki;
            button17.BackColor = Color.Khaki;
            button18.BackColor = Color.Khaki;
            button19.BackColor = Color.Khaki;
            button20.BackColor = Color.Khaki;
            button21.BackColor = Color.Khaki;
            button22.BackColor = Color.Khaki;
            button23.BackColor = Color.Khaki;
            button24.BackColor = Color.Khaki;
            button25.BackColor = Color.Khaki;
            button26.BackColor = Color.Khaki;
            button27.BackColor = Color.Khaki;
            button28.BackColor = Color.Khaki;
            button29.BackColor = Color.Khaki;
            button30.BackColor = Color.Khaki;
            button31.BackColor = Color.Khaki;
            button32.BackColor = Color.Khaki;
            button33.BackColor = Color.Khaki;
            button34.BackColor = Color.Khaki;
            button35.BackColor = Color.Khaki;
            button36.BackColor = Color.Khaki;
            button37.BackColor = Color.Khaki;
            button38.BackColor = Color.Khaki;
            button39.BackColor = Color.Khaki;
            button40.BackColor = Color.Khaki;
            button41.BackColor = Color.Khaki;
            button42.BackColor = Color.Khaki;
            button43.BackColor = Color.Khaki;
            button44.BackColor = Color.Khaki;
            button45.BackColor = Color.Khaki;
            button46.BackColor = Color.Khaki;
            button47.BackColor = Color.Khaki;
            button48.BackColor = Color.Khaki;
            button49.BackColor = Color.Khaki;
            button50.BackColor = Color.Khaki;
            button51.BackColor = Color.Khaki;
            button52.BackColor = Color.Khaki;
            button53.BackColor = Color.Khaki;
            button54.BackColor = Color.Khaki;
            button55.BackColor = Color.Khaki;
            button56.BackColor = Color.Khaki;
            button57.BackColor = Color.Khaki;
            button58.BackColor = Color.Khaki;
            button59.BackColor = Color.Khaki;
            button60.BackColor = Color.Khaki;
            button61.BackColor = Color.Khaki;
            button62.BackColor = Color.Khaki;
            button63.BackColor = Color.Khaki;
            button64.BackColor = Color.Khaki;*/
        }

        private void button66_Click(object sender, EventArgs e)
        {
            code = "";
            richTextBox1.Text = "";

            button1.BackColor = Color.Khaki;
            button2.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button4.BackColor = Color.Khaki;
            button5.BackColor = Color.Khaki;
            button6.BackColor = Color.Khaki;
            button7.BackColor = Color.Khaki;
            button8.BackColor = Color.Khaki;
            button9.BackColor = Color.Khaki;
            button10.BackColor = Color.Khaki;
            button11.BackColor = Color.Khaki;
            button12.BackColor = Color.Khaki;
            button13.BackColor = Color.Khaki;
            button14.BackColor = Color.Khaki;
            button15.BackColor = Color.Khaki;
            button16.BackColor = Color.Khaki;
            button17.BackColor = Color.Khaki;
            button18.BackColor = Color.Khaki;
            button19.BackColor = Color.Khaki;
            button20.BackColor = Color.Khaki;
            button21.BackColor = Color.Khaki;
            button22.BackColor = Color.Khaki;
            button23.BackColor = Color.Khaki;
            button24.BackColor = Color.Khaki;
            button25.BackColor = Color.Khaki;
            button26.BackColor = Color.Khaki;
            button27.BackColor = Color.Khaki;
            button28.BackColor = Color.Khaki;
            button29.BackColor = Color.Khaki;
            button30.BackColor = Color.Khaki;
            button31.BackColor = Color.Khaki;
            button32.BackColor = Color.Khaki;
            button33.BackColor = Color.Khaki;
            button34.BackColor = Color.Khaki;
            button35.BackColor = Color.Khaki;
            button36.BackColor = Color.Khaki;
            button37.BackColor = Color.Khaki;
            button38.BackColor = Color.Khaki;
            button39.BackColor = Color.Khaki;
            button40.BackColor = Color.Khaki;
            button41.BackColor = Color.Khaki;
            button42.BackColor = Color.Khaki;
            button43.BackColor = Color.Khaki;
            button44.BackColor = Color.Khaki;
            button45.BackColor = Color.Khaki;
            button46.BackColor = Color.Khaki;
            button47.BackColor = Color.Khaki;
            button48.BackColor = Color.Khaki;
            button49.BackColor = Color.Khaki;
            button50.BackColor = Color.Khaki;
            button51.BackColor = Color.Khaki;
            button52.BackColor = Color.Khaki;
            button53.BackColor = Color.Khaki;
            button54.BackColor = Color.Khaki;
            button55.BackColor = Color.Khaki;
            button56.BackColor = Color.Khaki;
            button57.BackColor = Color.Khaki;
            button58.BackColor = Color.Khaki;
            button59.BackColor = Color.Khaki;
            button60.BackColor = Color.Khaki;
            button61.BackColor = Color.Khaki;
            button62.BackColor = Color.Khaki;
            button63.BackColor = Color.Khaki;
            button64.BackColor = Color.Khaki;
        }

        private void univeralGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm2 = new Form1();
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enterStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index myForm2 = new index();
            myForm2.Show();
            this.Hide();
        }

    }
}
