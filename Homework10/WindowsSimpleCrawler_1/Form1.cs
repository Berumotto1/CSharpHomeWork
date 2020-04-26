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
        BindingSource resultBindingSource = new BindingSource();
        Thread thread = null;
        public Form1()
        {
            
            InitializeComponent();
            URLlistBox1.DataSource = resultBindingSource;
            sc.PageDownload += Crawler_PageDownloaded;
            sc.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(SimpleCrawler obj)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(SimpleCrawler crwaler,int index,string obj,string info)
        {
            var pageInfo = new { Index = index, URL = obj, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.URLlistBox1.InvokeRequired)
            {
                this.Invoke(action);
                /*Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { obj });*/
            }
            else
            {
                action();
                //URLlistBox1.Items.Add(obj);
            }
        }


        private void AddUrl(string url)
        {
            URLlistBox1.Items.Add(url);
        }
        
        private void Crawler_button_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            
            string startURL = URLBox1.Text + URLBox2.Text;
            //URLlistBox1.Items.Clear(); //清空内容
            new Thread(() => sc.init(startURL,1)).Start();
            //sc.init(startURL);
            lblInfo.Text = "爬虫已启动....";


        }
    }
}
