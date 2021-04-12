using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp_DependancyInjection.Data;
using WebApp_DependancyInjection.Models;

namespace WebApp_DependancyInjection.Pages
{
    public class Pobrane_z_bazy_danychModel : PageModel
    {
        readonly ILogger<Pobrane_z_bazy_danychModel> _logger;
        readonly ProductContext _context;

        public IList<Product> products { get; private set; }

        public Pobrane_z_bazy_danychModel(ILogger<Pobrane_z_bazy_danychModel> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
        }


        public void OnGet()
        {
            products = _context.Products.ToList();
        }
    }
}
