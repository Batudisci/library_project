using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        
        public T GetByID(int id)
        {
            // Veritabanı bağlantısı oluşturmak için Context sınıfından bir örnek (nesne) oluşturuluyor
            // "using" bloğu kullanıldığı için, işlem tamamlandığında otomatik olarak bağlantı kapatılacaktır
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

  
        public List<T> GetList()
        {
            // Veritabanındaki tüm nesnelerin listesini getirir
            using var c = new Context();
            return c.Set<T>().ToList();
        }

    
        public void Insert(T t)
        {
            // Yeni bir nesneyi veritabanına ekler          
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            // Var olan bir nesneyi veritabanında günceller
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
