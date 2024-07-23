using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CokeWikiDemo.Models;
using CokeWikiDemo.Models.Context;

namespace CokeWikiDemo.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly CokeWikiDemo.Models.Context.ApplicationDbContext _context;

        public DetailsModel(CokeWikiDemo.Models.Context.ApplicationDbContext context)
        {
            _context = context;
        }

        public Article Article { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FirstOrDefaultAsync(m => m.Topic == id);
            if (article == null)
            {
                return NotFound();
            }
            else
            {
                Article = article;
            }
            return Page();
        }
    }
}
