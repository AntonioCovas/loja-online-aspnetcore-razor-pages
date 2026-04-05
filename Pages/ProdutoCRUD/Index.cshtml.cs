using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreWebApp.Data;
using AspNetCoreWebApp.Models;

namespace AspNetCoreWebApp.Pages.ProdutoCRUD
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Produto> Produtos { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produto.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null) return BadRequest();
            
            var produto = await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
