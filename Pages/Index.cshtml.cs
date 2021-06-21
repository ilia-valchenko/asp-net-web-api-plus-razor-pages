using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    // We can think about the class below as a controller.
    // Personal controller which belongs to a single view.
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        // This is a default method.
        public void OnGet()
        {
            this.Message = "Your application description page.";
        }
    }
}