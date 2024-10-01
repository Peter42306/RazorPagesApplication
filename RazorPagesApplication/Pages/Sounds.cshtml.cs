using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class SoundsModel : PageModel
    {
		public string Message { get; set; } = "";

		public void OnGet()
		{
			Message="Sounds in Applications ASP.NET Core Razor Pages";
		}
	}
}
