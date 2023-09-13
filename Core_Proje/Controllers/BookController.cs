using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager(new EfBookDal());
        private Logger logger = Logger.getLogger();

        /// <summary>
        /// Kitapların listesini görüntülemek için kullanılan sayfa
        /// </summary>
        /// <returns>Kitapların listesi görünümü.</returns>
        public IActionResult Index()
        {
            try
            {
                var books = bookManager.TGetList();

                return View(books);
            }
            catch (Exception ex)
            {
                logger.writeLog("Index ", ex.ToString());
                // Hata durumunda boş bir liste görünümü döndürülür
                return View(new List<Book>());
            }
            
        }

        [HttpGet]
        public IActionResult AddBook()
        { 
            // Yeni bir kitap eklemek için kullanılan sayfa
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(AddBook book)
        {
            if (!ModelState.IsValid)
            {
                // Geçersiz model durumunda aynı sayfa yeniden görüntülenir
                return View("AddBook");
            }

            try
            {
                Book b = new Book();
                if (book.BookImage != null)
                {
                    //Kullanıcıdan alınan resmi istenilen klasöre benzersiz bir isimle kaydeder
                    var extension = Path.GetExtension(book.BookImage.FileName);
                    var newimagename = Guid.NewGuid() + extension; // benzersiz isim olusturma
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newimagename);
                    var stream = new FileStream(location, FileMode.Create);
                    book.BookImage.CopyTo(stream);
                    b.BookImage = newimagename;
                }
                b.BookName = book.BookName;
                b.BookWriter = book.BookWriter;
                b.IsInLibrary = true;
                b.BookDescription = book.BookDescription;
                b.DeadLine = book.DeadLine;

                bookManager.TAdd(b);
            }
            catch (Exception ex)
            {
                logger.writeLog("AddBook (POST) ", ex.ToString());
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            try
            {
                // Belirli bir kitabı düzenlemek için kullanılan sayfa
                var book = bookManager.TGetByID(id);
                return View(book);
            }
            catch (Exception ex)
            {
                logger.writeLog("EditBook (GET) ", ex.ToString());
                return RedirectToAction("Index");
            }
            
        }
        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if ( book.Borrower == null || book.DeadLine == null || book?.Borrower?.Length <= 0 || book?.DeadLine <= DateTime.Now)
            {
                return RedirectToAction("Index");
            }

            try
            {
                Book edit = edit = bookManager.TGetByID(book.ID);
                edit.Borrower = book.Borrower;
                edit.DeadLine = book.DeadLine;
                edit.IsInLibrary = false;
                // Kitap bilgilerini günceller
                bookManager.TUpdate(edit);
            }
            catch(Exception ex) {
                logger.writeLog("EditBook (POST) ", ex.ToString());
            }
            
            return RedirectToAction("Index");
        }
    }
}
