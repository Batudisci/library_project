using Microsoft.AspNetCore.Http;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Bu sayfada IFormFile türünü kullanmak için AddBook isimli class oluşturuldu
    /// </summary>
    public class AddBook
    {
        public string BookName { get; set; }

        public string BookWriter { get; set; }

        public IFormFile BookImage { get; set; }

        public bool IsInLibrary { get; set; }

        public string? Borrower { get; set; }

        public string? BookDescription { get; set; }

        public DateTime? DeadLine { get; set; }
    }
}
