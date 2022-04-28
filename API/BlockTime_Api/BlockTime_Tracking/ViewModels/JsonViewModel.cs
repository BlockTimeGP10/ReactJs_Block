using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockTime_Tracking.ViewModels
{
    public class JsonViewModel
    {
       public string jsonrpc { get; set; }
       public string method { get; set; }
       public int id { get; set; }
       public string auth { get; set; }

       public ParamsViewModel @params;
    }
}
