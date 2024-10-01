using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApplication.Pages
{
    public class DownloadFileModel : PageModel
    {
        // �������� ������ ���������, ������� ����� ������������ ��� ����������� ���������� � �������� ��������� ��������
        // ��� �������� ����� �������� ������ ������ ������, �� ������ � ���� �� �������� ���� ��������
        public string Message { get; private set; } = "";

        // ����� ������������ GET-������ � �������� (�� ���� ������ �� �������� ��������, ����� ������ ��������� URL)
        // ���������� ������ ���� IActionResult, ������� ��������� ��������, ����������� � ����� �� ������ (� ������ ������ � ��� ������� �����)
        public IActionResult OnGet()
        {
            string filePath = "~/Images/IMG_20170504_170840.jpg"; // ������, ������� ��������� ���� � �����, ������������ �� �������
            string fileType = "image/jpeg"; // MIME-��� �������� �������� ������� ������, ��� ������������ ����������� ����
            string fileName = "�����.jpg"; // �����, ������� ����� ���������� ������� ��� ���������� �� ��� ����������
            Message=$"File {fileName} was send to client";
            return File(filePath, fileType, fileName);
        }
    }
}
