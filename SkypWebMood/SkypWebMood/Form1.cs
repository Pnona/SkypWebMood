using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypWebMood
{
    public partial class Form1 : Form
    {
        browser browserwindow;
        public Form1()
        {
            InitializeComponent();
            browserwindow = new browser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browserwindow.Show();
        }
    }
}
