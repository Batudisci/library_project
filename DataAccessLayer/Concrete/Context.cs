using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    /// <summary>
    /// Veritabanı işlemleri için DbContext sınıfını uygulayan sınıf. Bu sınıf, 
    /// veritabanı bağlantısını yapılandırır ve veritabanındaki tablolara erişim sağlar
    /// </summary>
    public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            // Veritabanı bağlantısını yapılandırır. Bu örnekte SQL Server kullanılıyor
            optionsBuilder.UseSqlServer("server =JARVIS\\JARVIS;database=LibraryDb; integrated security=true");
		}
        // Veritabanındaki "Books" tablosuna erişim sağlayan DbSet nesnesi
        public DbSet<Book> Books { get; set; }

    }
}
