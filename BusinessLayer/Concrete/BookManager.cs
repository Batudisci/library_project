using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        IBookDAL _bookDal;

        public BookManager(IBookDAL bookDal)
        {
            _bookDal = bookDal;
        }

        public Book TGetByID(int id)
        {
            // Belirtilen ID'ye sahip bir kitabı getirir.
            // Eğer kitap bulunamazsa bir istisna (exception) fırlatır.
            Book book = _bookDal.GetByID(id);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            return book;
        }

        public void TAdd(Book t)
        {
            // Yeni bir kitap ekler.
            _bookDal.Insert(t);
        }

        public List<Book> TGetList()
        {
            // Tüm kitapları adlarına göre sıralayarak bir liste olarak döndürür
            return _bookDal.GetList().OrderBy(book=>book.BookName).ToList();
        }

        public void TUpdate(Book t)
        {
            // Var olan bir kitabın bilgilerini günceller
            _bookDal.Update(t);
        }
    }
}
