using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;

namespace WebApp_DependancyInjection.Models
{
    public class Product
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string img { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public override string ToString()
            => JsonSerializer.Serialize(this);
    }
}
