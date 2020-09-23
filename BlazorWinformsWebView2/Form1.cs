using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlazorWinformsWebView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            WebView2 webView2 = new WebView2();
            webView2.Source = new Uri("https://localhost:44363/");
            webView2.Dock = DockStyle.Fill;
            this.Controls.Add(webView2);
        }
    }
}
