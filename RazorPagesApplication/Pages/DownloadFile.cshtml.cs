using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class DownloadFileModel : PageModel
    {
        // свойство хранит сообщение, которое будет использовано для отображения информации о процессе обработки страницы
        // это свойство можно изменять только внутри класса, но доступ к нему из внешнего кода возможен
        public string Message { get; private set; } = "";

        // метод обрабатывает GET-запрос к странице (то есть запрос на загрузку страницы, когда клиент открывает URL)
        // возвращает объект типа IActionResult, который описывает действие, выполняемое в ответ на запрос (в данном случае — это возврат файла)
        public IActionResult OnGet()
        {
            string filePath = "~/Images/IMG_20170504_170840.jpg"; // строка, которая указывает путь к файлу, находящемуся на сервере
            string fileType = "image/jpeg"; // MIME-тип помогает браузеру клиента понять, как обрабатывать загружаемый файл
            string fileName = "Капри.jpg"; // файла, которое будет предложено клиенту для сохранения на его устройстве
            Message=$"File {fileName} was send to client";
            return File(filePath, fileType, fileName);
        }
    }
}
