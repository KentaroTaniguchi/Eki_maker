using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Eki_maker
{
    class cousedate
    {
     /*   [System.Runtime.Serialization.DataMember(Name = "totaltime")]
        public int TotalTime { get; set; }

        [System.Runtime.Serialization.DataMember(Name="name")]
        public string Name { get; set; }*/

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("totaltime")]
        public int TotalTime { get; set; }
    }
}
