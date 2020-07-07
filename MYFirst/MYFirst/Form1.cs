using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.op1.Text);
            var y = int.Parse(this.op2.Text);
            var z = x + y;
            this.result.Text = z.ToString();

            //this.result.Text = this.op1.Text + this.op2.Text;
        }

        private void jian_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.op1.Text);
            var y = int.Parse(this.op2.Text);
            var z = x - y;
            this.result.Text = z.ToString();
        }

        private void cheng_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.op1.Text);
            var y = int.Parse(this.op2.Text);
            var z = x * y;
            this.result.Text = z.ToString();
        }

        private void chu_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.op1.Text);
            var y = int.Parse(this.op2.Text);
            var z = x / y;
            this.result.Text = z.ToString();
        }
    }
}
