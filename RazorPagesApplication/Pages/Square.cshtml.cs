using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class SquareModel : PageModel
    {
        public string Message { get; private set; } = "";

        [BindProperty]
        public int BaseTriangle { get; set; }

        [BindProperty]
        public int HeightTriangle { get; set; }


        public void OnPost()
        {
            double Square = (double)BaseTriangle * HeightTriangle / 2;
			Message = $"Square of triangle with base {BaseTriangle} and height {HeightTriangle} is {Square}";
		}

        //public void OnGet()
        //{
        //}
    }
}
