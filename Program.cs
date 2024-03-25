using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;


namespace kafe3
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// WebSocket bağlantısını oluştur
            //var hubConnection = new HubConnectionBuilder()
            //    .WithUrl("https://your-server-url/chatHub") // SignalR sunucu URL'sini belirtin
            //    .Build();


            Application.Run(new Form1());
            
        }
    }
}
