using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kafe3
{
    public class ZamanBilgisi
    {
        private static ZamanBilgisi instance;
        public TimeSpan KalanZaman { get; set; }
        private Timer timer;

        public event EventHandler<TimeSpan> KalanZamanDegisti;

        public ZamanBilgisi() {

            timer = new Timer(TimerCallback, null, 1000, 1000); // 1 saniyede bir tetikle
            KalanZaman = TimeSpan.FromMinutes(30); // Başlangıçta 30 dakika
        }

        public static ZamanBilgisi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZamanBilgisi();
                }
                return instance;
            }
        }

        private void TimerCallback(object state)
        {
            KalanZaman = KalanZaman.Subtract(TimeSpan.FromSeconds(1));

            // Kalan zaman değiştikçe event'i tetikle
            KalanZamanDegisti?.Invoke(this, KalanZaman);

            if (KalanZaman.TotalSeconds <= 0)
            {
                // Süre dolduğunda timer'ı durdurabilirsiniz
                timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }
    }
}
