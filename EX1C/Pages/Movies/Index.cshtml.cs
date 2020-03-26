using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EX1C.Data;
using EX1C.Models;

namespace EX1C
{
    public class IndexModel : PageModel
    {
        private readonly EX1C.Data.EX1CContext _context;

        public IndexModel(EX1C.Data.EX1CContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
