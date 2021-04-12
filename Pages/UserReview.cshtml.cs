using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GscStore.Pages
{
    public class UserReviewModel : PageModel
    {
        private readonly ILogger<LocationModel> _logger;

        public UserReviewModel(ILogger<LocationModel> logger)
        {
            _logger = logger;
        }

        //         public void OnGet()
        //         {
        //         }
        //     }
        // }
        [BindProperty(SupportsGet = true)]
        public string Comment { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Comment))
            {
                Comment = "Web";
            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }
    }
}
