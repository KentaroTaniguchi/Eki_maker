using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Eki_maker
{
    class CouseDate
    {
        [Newtonsoft.Json.JsonProperty("searchresult")]
        public string Route{ get; set; }

        [Newtonsoft.Json.JsonProperty("totaltime")]
        public int TotalTime { get; set; }
    }
}
