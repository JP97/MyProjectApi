using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public Team Team { get; set; }
    }
}
