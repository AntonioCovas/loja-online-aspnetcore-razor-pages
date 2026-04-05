using AspNetCoreWebApp.Data;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApp.Pages.ClienteCRUD
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Cliente> Clientes { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
            Clientes = new();
        }

        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if(id == null) return BadRequest();
            
            var cliente = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
            if(cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
