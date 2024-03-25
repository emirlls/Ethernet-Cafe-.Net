using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace kafe3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"Masalar.xml");
            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                if (txtmasano.Text == User.Attribute("Masano").Value)
                {
                    if (txtmasasifre.Text == User.Element("Password").Value)
                    {
                        XDocument xDocpass = XDocument.Load("LastLogin.xml");
                        XElement rootelement = xDocpass.Root;
                        XElement newelement = new XElement("Masa");
                        XAttribute usernameattribute = new XAttribute("Masano", txtmasano.Text);
                        XElement passwordelement = new XElement("Password", txtmasasifre.Text);
                        newelement.Add(usernameattribute, passwordelement);
                        rootelement.Add(newelement);
                        xDocpass.Save("LastLogin.xml");

                        Form5 f5 = new Form5();
                        f5.Show();

                        lblyanlis.Text = "";
                    }
                    else { lblyanlis.Text = "Kullanıcı adı veya parola yanlış"; }
                }
            }
        }

    }
}
