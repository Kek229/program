using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

     
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = data.a;
            textBox2.Text = data.b;
            textBox3.Text = data.c;
            textBox4.Text = data.d;
        }
    }
}
