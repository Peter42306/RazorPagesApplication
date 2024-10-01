using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApplication.Models;

namespace RazorPagesApplication.Pages
{
    public class UploadFileModel : PageModel
    {
        public IEnumerable<Models.FileModel> FilesModel { get; set; } = default!;

        FileModelContext _context;

        IWebHostEnvironment _environment;

        public UploadFileModel(FileModelContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task OnGetAsync()
        {
            if (_context.Files != null)
            {
                FilesModel = await _context.Files.ToListAsync();
            }
        }

        public IFormFile uploadedFile { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (uploadedFile != null)
            {
                string path="/Files/"+uploadedFile.FileName;

                using (var fileStream=new FileStream(_environment.WebRootPath+path,FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                FileModel file = new FileModel
                {
                    Name = uploadedFile.FileName,
                    Path = path
                };

                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToPage("./UploadFile");
        }

        //public void OnGet()
        //{
        //}
    }
}
