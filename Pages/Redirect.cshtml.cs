using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class RedirectModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("Index");
        }
    }
}