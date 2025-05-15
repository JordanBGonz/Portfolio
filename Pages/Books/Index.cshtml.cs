using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookNest.Models;

namespace BookNest.Pages_Books
{
    public class IndexModel : PageModel
    {
        private readonly BookNest.Models.AppDbContext _context;

        public IndexModel(BookNest.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;


        public async Task OnGetAsync()
        {
            var query = _context.Books.Include(b => b.Reviews).Select(b => b);
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(b => b.Title.Contains(CurrentSearch));
            }
            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(b => b.Title);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(b => b.Title);
                    break;
            }
            TotalPages = (int)Math.Ceiling(_context.Books.Count() / (double)PageSize);
            Book = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }

        
    }
}
