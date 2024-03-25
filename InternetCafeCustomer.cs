using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe3
{
    public class InternetCafeCustomer
    {
        private readonly int computerNumber;
        private readonly TextBox remainingTimeTextBox;
        private readonly TextBox additionalMinutesTextBox;

        public InternetCafeCustomer(int computerNumber, TextBox remainingTimeTextBox, TextBox additionalMinutesTextBox)
        {
            this.computerNumber = computerNumber;
            this.remainingTimeTextBox = remainingTimeTextBox;
            this.additionalMinutesTextBox = additionalMinutesTextBox;

            // Düğmeye tıklandığında süre talep et
            additionalMinutesTextBox.TextChanged += (sender, e) =>
            {
                int additionalMinutes;
                if (int.TryParse(additionalMinutesTextBox.Text, out additionalMinutes))
                {
                    RequestAdditionalTime(additionalMinutes);
                }
            };

            // Geriye sayım işlemini başlat
            Task.Factory.StartNew(CountDown);
        }

        private void RequestAdditionalTime(int additionalMinutes)
        {
            // Zaman.xml dosyasına kaydet
            SaveToXml(additionalMinutes);

            // Kullanıcının girdiği süreyi kalan süreye ekleyerek göster
            int remainingTime = int.Parse(remainingTimeTextBox.Text);
            remainingTimeTextBox.Text = (remainingTime + additionalMinutes).ToString();
        }

        private void CountDown()
        {
            while (true)
            {
                int remainingTime = int.Parse(remainingTimeTextBox.Text);

                if (remainingTime > 0)
                {
                    remainingTimeTextBox.Invoke((MethodInvoker)delegate
                    {
                        remainingTimeTextBox.Text = (remainingTime - 1).ToString();
                    });
                }

                Thread.Sleep(60000); // Her dakika bir güncelleme yap
            }
        }

        private void SaveToXml(int additionalMinutes)
        {
            // Zaman.xml dosyasına kaydetme işlemi buraya eklenebilir
            // Bu kısımda InternetCafeManager sınıfının ilgili metodunu çağırabilirsiniz
        }

    }
}
