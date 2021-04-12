using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace WebApp_DependancyInjection.Models
{
    public class Product
    {
        [Key]
        [MaxLength(40)]
        public string id { get; set; }
        [Required]
        [MaxLength(20)]
        public string maker { get; set; }
        [Required]
        [MaxLength(110)]
        public string img { get; set; }
        [Required]
        [MaxLength(128)]
        public string url { get; set; }
        [Required]
        [MaxLength(64)]
        public string title { get; set; }
        [Required]
        [MaxLength(256)]
        public string description { get; set; }

        public override string ToString()
            => JsonSerializer.Serialize(this, new JsonSerializerOptions{ WriteIndented = true });
    }
}
