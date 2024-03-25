using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count ==0)
            {
                MessageBox.Show("Birini seçmelisiniz !");

            }
            else if(checkedListBox1.CheckedItems.Count == 2)
            {
                MessageBox.Show("Yalnızca birini seçmelisiniz !");
                checkedListBox1.SetItemChecked(0, false);
                checkedListBox1.SetItemChecked(1, false);
            }

            else if(checkedListBox1.SelectedIndex== 0)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                
            }
            else if (checkedListBox1.SelectedIndex== 1)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = @"pc3.png";


            //PictureBox'ı boyutlandır.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Ardından PictureBox'a görseli yükleyin.
            pictureBox1.Image = Image.FromFile(imagePath); // Görselinizin dosya yolunu belirtin

        }
    }
}
