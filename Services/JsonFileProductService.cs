using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApp_DependancyInjection.Models;

namespace WebApp_DependancyInjection.Services
{
    public class JsonFileProductService
    {
        public IWebHostEnvironment webHostEnvironment { get; }

        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
            => this.webHostEnvironment = webHostEnvironment;

        public string JsonFileName => Path.Combine(webHostEnvironment.WebRootPath, "data", "products.json");

        public IEnumerable<Product> GetProducts()
        {
            using (StreamReader reader = File.OpenText(JsonFileName))
                return JsonSerializer.Deserialize<Product[]>(reader.ReadToEnd());
        }
    }
}
