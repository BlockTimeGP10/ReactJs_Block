using BlockTime_Tracking.Domains;
using BlockTime_Tracking.ViewModels;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlockTime_Tracking.Repositories
{
    public class ZabbixRepository
    {

        public void Login()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var loginJsn = new JsonViewModel
            {
                jsonrpc = "2.0",
                method = "user.login",
                @params =
                {
                    user = "Admin",
                    password = "zabbix"
                },
                id = 1,
                auth = null
            };

             var resposta = client.PostAsJsonAsync("http://18.230.102.215/zabbix/api_jsonrpc.php", loginJsn);

           // return resposta;
        }
    }
}
