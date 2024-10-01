using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class ImageModel : PageModel
    {
        public string Message { get; set; } = "";

        public void OnGet()
        {
            Message="Images in Applications ASP.NET Core Razor Pages";
        }
    }
}
