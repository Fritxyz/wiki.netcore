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
    public class IndexModel : PageModel
    {
        private readonly CokeWikiDemo.Models.Context.ApplicationDbContext _context;

        public IndexModel(CokeWikiDemo.Models.Context.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Article = await _context.Articles.ToListAsync();
        }
    }
}
