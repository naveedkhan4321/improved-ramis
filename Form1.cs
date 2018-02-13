using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DateObj = DateTime.Parse(textBox1.Text);
            DateObj = DateObj.AddMilliseconds(1);
            label1.Text = DateObj.ToLongDateString();

            DateObj = DateObj.AddHours(1);

            var txt = DateObj.ToLongTimeString();
        }
    }
}
