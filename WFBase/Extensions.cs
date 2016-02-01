using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase
{
    public static class Extensions
    {
        public static string toJson(this BaseEleman eleman)
        {
            string output = JsonConvert.SerializeObject(eleman);
            return output;
        }
    }
}
