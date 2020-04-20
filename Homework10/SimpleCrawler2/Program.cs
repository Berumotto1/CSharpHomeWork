using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler2
{
    public class SimpleCrawler
    {
        public event Action<string> PageDownload;
        private Queue urls2 = new Queue(); //有序
        private int count = 0;
        public string tld;//顶级域名
        public string crawlerResult { get; set; }
        public string startURL = "http://www.cnblogs.com/dstang2000/";
        static void Main(string[] args)
        {
            string initurl = "http://www.baidu.com";
            SimpleCrawler myCrawler = new SimpleCrawler();
            myCrawler.init(initurl, 1);

            /*SimpleCrawler myCrawler2 = new SimpleCrawler();
            myCrawler2.init(initurl, 2);*/
            Console.ReadKey();
        }

        public void init(string starturl, int index)
        {
            crawlerResult = "123";
            string startUrl = starturl;
            string tldRef = @"(https://|http://)[^""'#>/]+(/)";  //顶级域名的正则表达式
            MatchCollection matches2 = new Regex(tldRef).Matches(starturl);
            if (matches2.Count > 0)
            {
                tld = matches2[0].Value.Substring(0, matches2[0].Value.Length - 1);
            }
            else
            {
                tld = startUrl;
            }
            this.urls2.Enqueue(startUrl);

           
            new Thread(this.Crawl).Start();
            
            /*if (index==1)
            {
                //普通方法
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                
                Task task = Task.Run(() => this.Crawl());
                Task.WaitAll(task);
                sw2.Stop();
                Console.WriteLine("普通方法用时：" + sw2.ElapsedMilliseconds);
            }

            else
            {
                //并行方法
                this.count = 1;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Task[] tasks = {
                Task.Run(()=>this.Crawl()),
                Task.Run(()=>this.Crawl()),
                Task.Run(()=>this.Crawl()),
                Task.Run(()=>this.Crawl()),
                Task.Run(()=>this.Crawl())
                };

                Task.WaitAll(tasks);
                sw.Stop();
                Console.WriteLine("并行方法用时：" + sw.ElapsedMilliseconds);
            }*/



        }


        public void Crawl()
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("开始爬行了.... ");

            string current = null;
            string url2;
            while (urls2.Count > 0)
            {
                url2 = (string)urls2.Dequeue();  //队列里不用实现 寻找没有爬过的链接
                current = url2;
                if (current == null || count > 10) break; //爬10个以后停下来
                Console.WriteLine("爬行" + current + "页面!");
                
                //{
                    count++;
                    //Task<string> task = Task.Run(() => DownLoad(current));
                    //string html = task.Result;
                    string html = DownLoad(current); // 下载
                                                     //PageDownload(current);

                    //Task task2 = Task.Run(() => Parse(html));
                    Parse(html);//解析,并加入新的链接
                    Console.WriteLine("爬行结束");
                //});
                
            }
            sw.Stop();

            Console.WriteLine("并行方法用时：" + sw.ElapsedMilliseconds);



        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }



        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            //string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(.html)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                string strRefRel = @"^(/)[^""'#>]+"; //相对地址的正则表达式
                if (Regex.IsMatch(strRef, strRefRel))
                {
                    strRef = tld + strRef;
                }
                if (strRef.Length == 0) continue;

                if (!urls2.Contains(strRef)) urls2.Enqueue(strRef); //进入队列
            }
        }
    }
}
