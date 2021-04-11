using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp_DependancyInjection.Services;

namespace WebApp_DependancyInjection.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        readonly ILogger<IndexModel> _logger;
        public readonly JsonFileProductService productService;

        public Pobrane_z_plikuModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public void OnGet()
        {
        }
    }
}
