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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"Admin.xml");
            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                if (txtusername.Text == User.Attribute("Username").Value)
                {
                    if (txtpassword.Text == User.Element("Password").Value)
                    {
                        Form4 f4 = new Form4();
                        f4.Show();
                    }
                }
            }
        }
    }
}
