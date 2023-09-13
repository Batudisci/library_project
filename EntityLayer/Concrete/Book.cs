using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Kitaplar için oluşturduğumuz Entity sınıfımız
    /// </summary>
	public class Book
	{
        [Key]
        public int ID { get; set; }
        
        public string BookName { get; set; }

        public string BookWriter { get; set; }

        public string BookImage { get; set; }

        public bool IsInLibrary { get; set; }      

        public string? Borrower { get; set; }

        public string? BookDescription { get; set; }

		public DateTime? DeadLine { get; set; }
    }
}
