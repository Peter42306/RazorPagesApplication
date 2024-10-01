using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class DownloadFileLinkModel : PageModel
    {
        public string Message { get; private set; } = "";

		// ����������� ��������
		public void OnGet()
        {
            Message="Click the link to download the file";
        }

		// ����� ��� ���������� �����
		public IActionResult OnGetDownloadFileLink()
		{
			string filePath = "~/Images/IMG_20170504_170840.jpg"; // ���� � ����� �� �������
			string fileType = "image/jpeg"; // MIME-��� �����
			string fileName = "�����.jpg"; // ��� ����� ��� ����������
			return File(filePath, fileType, fileName); // �������� ����� �������
		}
	}
}
