using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class TestModel : PageModel
    {
        //// Text
        //public ContentResult OnGet()
        //{
        //    return Content("Content() method used.");
        //}

        // File
        private readonly IHostingEnvironment _appEnvironment;

        public TestModel(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public FileResult OnGet()
        {
            var path = Path.Combine(_appEnvironment.ContentRootPath, "Files/test.txt");
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "Application/txt", "test.txt");
        }

        //// Status code
        //public ForbidResult OnGet()
        //{
        //    return Forbid();
        //}
    }
}