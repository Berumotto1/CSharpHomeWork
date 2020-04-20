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
using SimpleCrawler2;

namespace WindowsSimpleCrawler_1
{
    public partial class Form1 : Form
    {
        SimpleCrawler sc = new SimpleCrawler();

        public Form1()
        {
            string result = sc.crawlerResult;
            InitializeComponent();
            sc.PageDownload += Crawler_PageDownloaded;     
        }


        private void Crawler_PageDownloaded(string obj)
        {
            if (this.URLlistBox1.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { obj });
            }
            else
            {
                URLlistBox1.Items.Add(obj);
            }
        }


        private void AddUrl(string url)
        {
            URLlistBox1.Items.Add(url);
        }
        
        private void Crawler_button_Click(object sender, EventArgs e)
        {
            
            string startURL = URLBox1.Text + URLBox2.Text;
            URLlistBox1.Items.Clear(); //清空内容
            //new Thread(() => sc.init(startURL)).Start();
            sc.init(startURL);
            
            

        }
    }
}
