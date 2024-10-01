using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class SquareUrlModel : PageModel
    {
        public string Message { get; private set; } = "";

        [BindProperty(SupportsGet =true,Name ="a")]
        public int BaseTriangle {  get; set; }

        [BindProperty (SupportsGet =true,Name ="h")]
        public int HeightTriangle { get; set; }

        public void OnGet()
        {
            double Square = (double)BaseTriangle * HeightTriangle / 2;
            Message = $"Square of triangle with base {BaseTriangle} and height {HeightTriangle} is {Square}";
        }
    }
}
