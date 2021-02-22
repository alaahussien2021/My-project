using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RLC frm = new RLC();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shanon sh = new Shanon();
            sh.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            huffman hf = new huffman();
            hf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdabtiveHulfman adb = new AdabtiveHulfman();
            adb.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LZW lzw = new LZW();
            lzw.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Arthmatic AA = new Arthmatic();
            AA.ShowDialog();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VRLC VRL = new VRLC();
            VRL.ShowDialog();
        }
    }
}
