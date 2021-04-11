using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GscStore.Models;

namespace GscStore.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly GscStore.Models.GscStoreContext _context;

        public CreateModel(GscStore.Models.GscStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _context.Products.Add(Product);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["error"] = "Please login as Admin";
                return Page();

            }
        }
    }
}
