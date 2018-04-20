using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cities;

        public Form1()
        {
            InitializeComponent();
            cityBox.Text = "Киев";

            cities = new Dictionary<string, string>
            {
                {"Винница",     "http://rp5.ua/rss/187/ru" },
                {"Днепр",       "http://rp5.ua/rss/247/ru" },
                {"Донецк",      "http://rp5.ua/rss/298/ru" },
                {"Житомир",     "http://rp5.ua/rss/342/ru" },
                {"Запорожье",   "http://rp5.ua/rss/383/ru" },
                {"Киев",        "http://rp5.ua/rss/509938/ru" },
                {"Кропивницкий","http://rp5.ua/rss/471/ru" },
                {"Луганск",     "http://rp5.ua/rss/520/ru" },
                {"Луцк",        "http://rp5.ua/rss/224/ru" },
                {"Львов",       "http://rp5.ua/rss/557/ru" },
                {"Николаев",    "http://rp5.ua/rss/585/ru" },
                {"Одесса",      "http://rp5.ua/rss/614/ru" },
                {"Полтава",     "http://rp5.ua/rss/644/ru" },
                {"Ровно",       "http://rp5.ua/rss/665/ru" },
                {"Севастополь", "http://rp5.ua/rss/234/ru" },
                {"Симферополь", "http://rp5.ua/rss/174/ru" },
                {"Сумы",        "http://rp5.ua/rss/687/ru" },
                {"Тернополь",   "http://rp5.ua/rss/712/ru" },
                {"Ужгород",     "http://rp5.ua/rss/373/ru" },
                {"Харьков",     "http://rp5.ua/rss/741/ru" },
                {"Херсон",      "http://rp5.ua/rss/764/ru" },
                {"Хмельницкий", "http://rp5.ua/rss/787/ru" },
                {"Черкассы",    "http://rp5.ua/rss/811/ru" },
                {"Чернигов",    "http://rp5.ua/rss/838/ru" },
                {"Черновцы",    "http://rp5.ua/rss/853/ru" }
            };
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            HttpWebRequest query = null;
            HttpWebResponse answer = null;


            foreach (var i in cities)
            {
                if (i.Key == cityBox.Text)
                {
                    query = (HttpWebRequest)HttpWebRequest.Create(i.Value);
                    break;
                }
            }

            answer = (HttpWebResponse)query.GetResponse();
            Stream content = answer.GetResponseStream();
            StreamReader sr = new StreamReader(content);
            string code = sr.ReadToEnd();

            string path = @"data.xml";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(code);

            sw.Close();
            sr.Close();

            XmlDocument xD = new XmlDocument();
            xD.Load(path);
            XmlElement root = xD.DocumentElement;
            foreach (XmlNode xnode in root)
            {
                if (xnode.Name == "entry")
                {
                    foreach (XmlNode xnd in xnode.ChildNodes)
                    {
                        if (xnd.Name == "title")
                        {
                            outputBox.Text = xnd.InnerText;
                            outputBox.Text += ",";
                        }
                        if (xnd.Name == "summary")
                            outputBox.Text += xnd.InnerText;
                    }
                }
            }
        }
    }
}
