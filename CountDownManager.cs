using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace kafe3
{
    public class CountDownManager
    {

        private List<string> masaNumaralari;
        private Dictionary<string, int> masaSureleri;
        private System.Threading.Timer timer;

        public event EventHandler<CountDownEventArgs> CountDownTick;



        public CountDownManager(List<string> masaNumaralari)
        {
            this.masaNumaralari = masaNumaralari;
            masaSureleri = new Dictionary<string, int>();

            LoadMasalar();

            timer = new System.Threading.Timer(TimerCallback, null, 0, 60000); // Her bir dakikada bir çalışacak şekilde ayarlandı


        }

        private void LoadMasalar()
        {
            XDocument xDoc = XDocument.Load("Zaman.xml");
            foreach (var masaNo in masaNumaralari)
            {
                var masaElement = xDoc.Descendants("Masa").FirstOrDefault(e => e.Attribute("Masano").Value == masaNo);
                if (masaElement != null)
                {
                    int sure;
                    if (int.TryParse(masaElement.Element("Süre").Value, out sure))
                    {
                        masaSureleri[masaNo] = sure; // Dakika cinsinden süre
                    }
                }
            }
        }

        private void TimerCallback(object state)
        {
            foreach (var masaNo in masaNumaralari)
            {
                if (masaSureleri.TryGetValue(masaNo, out int remainingTime))
                {
                    OnCountdownTick(masaNo, remainingTime);
                    remainingTime--; // Her bir dakikada bir azalt
                    masaSureleri[masaNo] = remainingTime;


                    if (remainingTime <= 0)
                    {
                        masaSureleri[masaNo] = 0; // Negatif değerleri önlemek için
                    }
                }
            }
        }

        protected virtual void OnCountdownTick(string masaNo, int remainingTime)
        {
            CountDownTick?.Invoke(this, new CountDownEventArgs(masaNo, remainingTime));
        }


        private decimal CalculateFee(int remainingTime)
        {
            // Her bir dakika için 30 kuruş ücret hesapla
            decimal feePerMinute = 0.30m;
            return feePerMinute * remainingTime;
        }
    }

    public class CountDownEventArgs : EventArgs
    {
        public string MasaNo { get; }
        public int RemainingTime { get; }

        public CountDownEventArgs(string masaNo, int remainingTime)
        {
            MasaNo = masaNo;
            RemainingTime = remainingTime;
        }
    }
}
