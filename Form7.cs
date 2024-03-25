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
    public partial class Form7 : Form
    {
        private string masano;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmasano.Text=="" || txtpassword.Text=="")
            {
                MessageBox.Show("Boş bırakılamaz.");
            }
            else
            {
                XDocument xDoc1 = new XDocument();
                xDoc1 = XDocument.Load(@"Masalar.xml");

                XElement rootElement1 = xDoc1.Root;

                foreach (XElement User in rootElement1.Elements())
                {
                    if (txtmasano.Text == User.Attribute("Masano").Value)
                    {
                        User.Element("Password").Value = txtpassword.Text;
                        xDoc1.Save(@"Masalar.xml");
                        txtmasano.Text = "";
                        txtpassword.Text = "";
                        MessageBox.Show("Masa Şifresi Değiştirildi.");
                        
                        return;
                    }
                    else {MessageBox.Show("Masa bulunamadı.");return; }                   
                }
            }
        }
    }
}
