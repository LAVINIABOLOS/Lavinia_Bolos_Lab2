using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lavinia_Bolos_Lab2.Data;
using Lavinia_Bolos_Lab2.Models;

namespace Lavinia_Bolos_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Lavinia_Bolos_Lab2.Data.Lavinia_Bolos_Lab2Context _context;

        public IndexModel(Lavinia_Bolos_Lab2.Data.Lavinia_Bolos_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
