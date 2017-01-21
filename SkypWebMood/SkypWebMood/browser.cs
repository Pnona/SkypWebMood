using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SkypWebMood
{
    
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser prohlizec;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            prohlizec = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(prohlizec);
            prohlizec.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prohlizec.Load(textBox1.Text);
        }
    }
}
