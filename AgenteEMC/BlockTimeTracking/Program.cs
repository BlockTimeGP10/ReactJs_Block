using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockTimeTracking
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("Kernel32")]
        private static extern IntPtr GetConsoleWindow();

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main(string[] args)
        {
            var note = new Note();
            IntPtr hwnd;
            hwnd = GetConsoleWindow();
            ShowWindow(hwnd, SW_SHOW);

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            note.NomeNotebook = computerProperties.HostName;

            GetLocationProperty(note);

        }

        static void GetLocationProperty(Note noteSend)
        {
            HttpClient _httpClient = new HttpClient();
            bool tentarDenovo = true;
            bool api = false;

            while (tentarDenovo)
            {

                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

                // Do not suppress prompt, and wait 1000 milliseconds to start.
                watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

                GeoCoordinate coord = watcher.Position.Location;

                if (coord.IsUnknown != true)
                {
                    noteSend.Lat = coord.Latitude.ToString();
                    noteSend.Lng = coord.Longitude.ToString();
                    System.Net.HttpStatusCode tst;

                    string json = $@"{{
 Lat : {noteSend.Lat},
 Lng : {noteSend.Lng},
 NomeNotebook : {noteSend.NomeNotebook}
}}";
                    using (var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json"))
                    {
                        HttpResponseMessage result = _httpClient.PutAsync("http://localhost:5000/api/Equipamentos/Nome", content).Result;
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {

                        }
                        string returnValue = result.Content.ReadAsStringAsync().Result;
                        var stt = result.StatusCode;
                        tst = stt;
                        throw new Exception($"Failed to put data: ({result.StatusCode}): {returnValue}");
                    }
                    
                    if (tst == System.Net.HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine("não achou");
                        do
                        {
                            string json2 = $@"{{
 Lat : {noteSend.Lat},
 Lng : {noteSend.Lng},
 NomeNotebook : {noteSend.NomeNotebook}
}}";
                            using (var content = new StringContent(json2, System.Text.Encoding.UTF8, "application/json"))
                            {
                                HttpResponseMessage result = _httpClient.PostAsync("http://localhost:5000/api/Equipamentos", content).Result;
                                Console.WriteLine(result.StatusCode);
                                if (result.StatusCode == System.Net.HttpStatusCode.Created)
                                    api = true;
                                Thread.Sleep(3600000);
                                Console.WriteLine("Parabéns");
                                Console.ReadLine();
                                string returnValue = result.Content.ReadAsStringAsync().Result;
                                throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
                            }
                        } while (api != true);
                    }
                    else
                    {
                        Console.WriteLine("tu entra aqui???");
                        using (var content = new StringContent(noteSend.ToString(), System.Text.Encoding.UTF8, "application/json"))
                        {
                            HttpResponseMessage result = _httpClient.PutAsync("http://localhost:5000/api/Equipamentos", content).Result;
                            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                                api = true;
                            Thread.Sleep(3600000);
                            Console.WriteLine("Parabéns");
                            Console.ReadLine();
                            string returnValue = result.Content.ReadAsStringAsync().Result;
                            throw new Exception($"Failed to put data: ({result.StatusCode}): {returnValue}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("deu td errado");
                }
            }
        }
    }
}
