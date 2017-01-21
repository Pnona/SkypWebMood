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
            button2.Dock = DockStyle.Top;
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
        int showing = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (showing == 1) {
                textBox1.Visible = false;
                button1.Visible = false;
                button2.Dock = DockStyle.None;
                button2.Text = "Show";
                showing = 0;
            } else
            {
                textBox1.Visible = true;
                button1.Visible = true;
                button2.Dock = DockStyle.Top;
                button2.Text = "Hide";
                showing = 1;
            }
        }
    }
}
