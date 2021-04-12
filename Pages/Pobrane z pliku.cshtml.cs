using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp_DependancyInjection.Models;
using WebApp_DependancyInjection.Services;

namespace WebApp_DependancyInjection.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        readonly ILogger<IndexModel> _logger;
        readonly JsonFileProductService productService;

        public IEnumerable<Product> products { get; private set; }

        public Pobrane_z_plikuModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public void OnGet()
        {
            products = productService.GetProducts();
        }
    }
}
