using AspNetCoreWebApp.Data;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreWebApp.Pages.ClienteCRUD
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        
        [BindProperty]
        public Cliente Cliente { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            //return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Cliente cliente = new();
            if(await TryUpdateModelAsync(cliente, "cliente", c => c.Nome, c => c.DataNascimento, c => c.CPF, c => c.Email))
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
