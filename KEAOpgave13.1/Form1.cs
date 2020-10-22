using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Coin coin1 = new Coin();
        Coin coin2 = new Coin();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coin1.Throw();
            coin2.Throw();
            listBox1.Items.Add(coin1.Value.ToString() + coin2.Value.ToString());
        }
    }
}
