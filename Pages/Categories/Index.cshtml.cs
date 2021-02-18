using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorgan_Alexandru_lab8.Data;
using Gorgan_Alexandru_lab8.Models;

namespace Gorgan_Alexandru_lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Gorgan_Alexandru_lab8.Data.Gorgan_Alexandru_lab8Context _context;

        public IndexModel(Gorgan_Alexandru_lab8.Data.Gorgan_Alexandru_lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
