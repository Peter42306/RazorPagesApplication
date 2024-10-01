using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class OldPageModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("PrintTimePage");
        }
    }
}
