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

namespace kafe3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Boş bırakılamaz."); return;
            }
            else
            {
                XDocument xDoc1 = new XDocument();
                xDoc1 = XDocument.Load(@"Admin.xml");

                XElement rootElement1 = xDoc1.Root;

                foreach (XElement User in rootElement1.Elements())
                {
                    User.Attribute("Username").Value = txtusername.Text;
                    User.Element("Password").Value = txtpassword.Text;
                    xDoc1.Save(@"Admin.xml");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    MessageBox.Show("Admin Bilgileri Değiştirildi.");
                }
            }
        }
    }
}
