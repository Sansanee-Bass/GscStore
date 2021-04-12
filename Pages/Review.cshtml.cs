using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GscStore.Pages
{
    public class ReviewModel : PageModel
    {
        private readonly ILogger<LocationModel> _logger;

        public ReviewModel(ILogger<LocationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

    }
}
