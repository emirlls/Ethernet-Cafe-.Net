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
using System.Xml.Linq;


namespace kafe3
{
    public partial class Form5 : Form
    {
        private string masano;
        private int anliksure;
        private int totalsure;
        public int ucret;
        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            XDocument xDoc = XDocument.Load(@"Lastlogin.xml");

            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                masano = User.Attribute("Masano").Value;
            }

            XDocument xDoc1 = new XDocument();
            xDoc1 = XDocument.Load(@"Zaman.xml");

            XElement rootElement1 = xDoc1.Root;

            foreach (XElement User in rootElement1.Elements())
            {
                if (masano == User.Attribute("Masano").Value)
                {
                    txtkalan.Text=User.Element("Süre").Value.ToString();
                    txtucret.Text=(int.Parse(txtkalan.Text)*0.30).ToString();                 
                }

            }
        }

        private void btndakikaekle_Click(object sender, EventArgs e)
        {
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(@"Zaman.xml");

            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                if (masano == User.Attribute("Masano").Value)
                {

                    if(txtboxdakika.Text.Length > 0)
                    {
                        anliksure = int.Parse(User.Element("Süre").Value);
                        totalsure = anliksure + int.Parse(txtboxdakika.Text);
                        User.Element("Süre").Value = totalsure.ToString();
                        txtkalan.Text=totalsure.ToString();
                        txtucret.Text=(totalsure * 0.30).ToString();
                        txtboxdakika.Text = "";
                        
                        xDoc.Save(@"Zaman.xml");
                        MessageBox.Show("Ek süre talebiniz alındı.");

                    }
                    else
                    {
                        MessageBox.Show("Dakika girin");
                    }
                }

            }
            
        }

    }
}
