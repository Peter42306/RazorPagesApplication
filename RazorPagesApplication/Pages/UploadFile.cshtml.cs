using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApplication.Models;

namespace RazorPagesApplication.Pages
{
    // Модель страницы для загрузки и отображения файлов
    public class UploadFileModel : PageModel
    {
        public IEnumerable<Models.FileModel> FilesModel { get; set; } = default!; // Свойство для хранения списка файлов из базы данных

        FileModelContext _context; // Контекст базы данных, используется для взаимодействия с таблицей файлов
        IWebHostEnvironment _environment; // Переменная для работы с файловой системой, предоставляет доступ к веб-ресурсам

        // Конструктор, в который передается контекст базы данных и веб-среда
        public UploadFileModel(FileModelContext context, IWebHostEnvironment environment)
        {
            _context = context; // Инициализация контекста базы данных
            _environment = environment; // Инициализация среды для работы с файлами
        }

        // Метод, вызываемый при GET-запросе, используется для получения списка файлов из базы данных
        public async Task OnGetAsync()
        {
            if (_context.Files != null)
            {
                FilesModel = await _context.Files.ToListAsync();
            }
        }

        public IFormFile uploadedFile { get; set; } = default!; // Свойство для хранения загружаемого файла

        // Метод, вызываемый при POST-запросе для загрузки файла
        public async Task<IActionResult> OnPostAsync()
        {
            if (uploadedFile != null)
            {
                string path = "/Files/"+uploadedFile.FileName; // Формируем путь к папке "Files" в каталоге wwwroot

                // Открываем поток для сохранения файла в файловой системе
                using (var fileStream = new FileStream(_environment.WebRootPath+path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream); // Копируем содержимое загруженного файла в файловую систему
                }

                // Создаем новый объект FileModel, который будет добавлен в базу данных
                FileModel file = new FileModel
                {
                    Name = uploadedFile.FileName,
                    Path = path
                };

                _context.Files.Add(file); // Добавляем файл в базу данных
                _context.SaveChanges(); // Сохраняем изменения в базе данных
            }

            return RedirectToPage("./UploadFile"); // Перенаправляем обратно на страницу загрузки файлов
        }

        //public void OnGet()
        //{
        //}
    }
}
