using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static kafe3.CountDownManager;

namespace kafe3
{
    public partial class Form4 : Form
    {

        private CountDownManager countdownManager;
        private List<TextBox> masaTextBoxes;

        public Form4()
        {
            InitializeComponent();

            List<string> masaNumaralari = new List<string> { "Masa1", "Masa2", "Masa3", "Masa4", "Masa5" };
            countdownManager = new CountDownManager(masaNumaralari);
            countdownManager.CountDownTick += CountdownManager_CountDownTick;
            InitializeMasaTextBoxes();

        }

        private void InitializeMasaTextBoxes()
        {
            masaTextBoxes = new List<TextBox>
            {
                textBoxMasa1,
                textBoxMasa2,
                textBoxMasa3,
                textBoxMasa4,
                textBoxMasa5
            };
        }


        private void CountdownManager_CountDownTick(object sender, CountDownEventArgs e)
        {
            // e.MasaNo ve e.RemainingTime değerlerini kullanarak TextBox'ları güncelle
            UpdateTextBox(e.MasaNo, e.RemainingTime);
        }

        private void UpdateTextBox(string masaNo, int remainingTime)
        {
            int index = int.Parse(masaNo.Substring("Masa".Length)) - 1;

            if (index >= 0 && index < masaTextBoxes.Count)
            {
                if (masaTextBoxes[index].InvokeRequired)
                {
                    masaTextBoxes[index].Invoke((MethodInvoker)delegate
                    {
                        masaTextBoxes[index].Text = remainingTime.ToString();
                    });
                }
                else
                {
                    masaTextBoxes[index].Text = remainingTime.ToString();
                }
            }
        }

        private void Updateucret()
        {
            XDocument xDoc1 = new XDocument();
            xDoc1 = XDocument.Load(@"Zaman.xml");

            XElement rootElement1 = xDoc1.Root;

            foreach (XElement User in rootElement1.Elements())
            {
                if (User.Attribute("Masano").Value == "Masa1")
                {
                    textBoxUcretMasa1.Text=(int.Parse(User.Element("Süre").Value)*0.30).ToString();
                }
                if (User.Attribute("Masano").Value == "Masa2")
                {
                    textBoxUcretMasa2.Text = (int.Parse(User.Element("Süre").Value) * 0.30).ToString();
                }
                if (User.Attribute("Masano").Value == "Masa3")
                {
                    textBoxUcretMasa3.Text = (int.Parse(User.Element("Süre").Value) * 0.30).ToString();
                }
                if (User.Attribute("Masano").Value == "Masa4")
                {
                    textBoxUcretMasa4.Text = (int.Parse(User.Element("Süre").Value) * 0.30).ToString();
                }
                if (User.Attribute("Masano").Value == "Masa5")
                {
                    textBoxUcretMasa5.Text = (int.Parse(User.Element("Süre").Value) * 0.30).ToString();
                }

            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            string imagePath = @"pc1.png";

            pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
            pictureBox2.Image = System.Drawing.Image.FromFile(imagePath);
            pictureBox3.Image = System.Drawing.Image.FromFile(imagePath);
            pictureBox4.Image = System.Drawing.Image.FromFile(imagePath);
            pictureBox5.Image = System.Drawing.Image.FromFile(imagePath);

            Updateucret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}
