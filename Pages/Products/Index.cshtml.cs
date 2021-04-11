using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GscStore.Models;
using Microsoft.Extensions.Logging;

namespace GscStore.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly GscStore.Models.GscStoreContext _context;
        [BindProperty(SupportsGet = true)]
        public string SearchText { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(GscStore.Models.GscStoreContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            var products = from p in _context.Products select p;
            if (!string.IsNullOrEmpty(SearchText))
            {
                products = products.Where(p => p.Name.ToLower().Contains(SearchText.ToLower()));
            }

            Product = await products.ToListAsync();
        }
    }
}
