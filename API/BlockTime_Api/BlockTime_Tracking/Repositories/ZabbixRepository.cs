using BlockTime_Tracking.Domains;
using BlockTime_Tracking.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ZabbixApi;

namespace BlockTime_Tracking.Repositories
{
    public class ZabbixRepository : IZabbixRepository
    {
        public IEnumerable<ZabbixApi.Entities.HostGroup> GetHostGroups(string nameHost)
        {
            using (var context = new Context("http://18.230.102.215/zabbix/api_jsonrpc.php", "Admin", "zabbix"))
            {
                var host = context.HostGroups.Get();
                return host;
            }
        }

        public IEnumerable<ZabbixApi.Entities.HostGroup> GetHostGroupsMonitoring()
        {
            using (var context = new Context("http://18.230.102.215/zabbix/api_jsonrpc.php", "Admin", "zabbix"))
            {
                var host = context.HostGroups.Get(new
                {
                    output = "extend",
        with_monitored_items = new { }
            }); ;

                return host;
            }
        }

        public IEnumerable<ZabbixApi.Entities.HostGroup> GetHostGroupByHost(string nameHost)
        {
            using (var context = new Context("http://18.230.102.215/zabbix/api_jsonrpc.php", "Admin", "zabbix"))
            {
                var host = context.HostGroups.Get(new
                {
                    output = "hostid",
                    selectGroups = "extend",
                    filter = new
                    {
                        host = nameHost
                    }
                }); ;


                return host;
            }
        }

        public IEnumerable<ZabbixApi.Entities.HostGroup> GetHostGroupByName(string nameHostGroup)
        {
            using (var context = new Context("http://18.230.102.215/zabbix/api_jsonrpc.php", "Admin", "zabbix"))
            {
                var host = context.HostGroups.Get(new {
                    output = "extend",
        selectHosts = "extend",
        filter = new {
                    name = 
                        nameHostGroup
        }
            });
                return host;
            }
        }

        public ZabbixApi.Entities.Host GetHostByName(string nameHost)
        {
            using (var context = new Context("http://18.230.102.215/zabbix/api_jsonrpc.php", "Admin", "zabbix"))
            {
                var host = context.Hosts.GetByName(nameHost);
                return host;
            }
        }
    }
}
