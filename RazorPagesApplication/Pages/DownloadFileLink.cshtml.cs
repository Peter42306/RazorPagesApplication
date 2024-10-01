using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class DownloadFileLinkModel : PageModel
    {
        public string Message { get; private set; } = "";

		// Отображение страницы
		public void OnGet()
        {
            Message="Click the link to download the file";
        }

		// Метод для скачивания файла
		public IActionResult OnGetDownloadFileLink()
		{
			string filePath = "~/Images/IMG_20170504_170840.jpg"; // путь к файлу на сервере
			string fileType = "image/jpeg"; // MIME-тип файла
			string fileName = "Капри.jpg"; // имя файла для скачивания
			return File(filePath, fileType, fileName); // отправка файла клиенту
		}
	}
}
