using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class PrintTimePageModel : PageModel
    {
        public string Message { get; }

        public PrintTimePageModel()
        {
            Message = "ASP.NET Core Razor Pages (from Constructor)";
        }

        public void OnGet()
        {
            ViewData["Message"] = "ASP.NET Core MVC (from OnGet)";            
        }

        public string PrintTime() => DateTime.Now.ToShortTimeString();
    }
}
