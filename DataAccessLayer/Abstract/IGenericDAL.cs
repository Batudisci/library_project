
namespace DataAccessLayer.Abstract
{
	public interface IGenericDAL<T> where T : class
	{
        /// <summary>
        /// Veritabanına yeni bir nesne ekler
        /// </summary>
        /// <param name="t">Eklenecek nesne.</param>
		void Insert(T t);


        /// <summary>
        /// Veritabanından tüm nesneleri listeler
        /// </summary>
        /// <returns>Veritabanındaki tüm nesnelerin listesi</returns>
		List<T> GetList();


        /// <summary>
        /// Belirli bir nesneyi veritabanından ID'ye göre getirir
        /// </summary>
        /// <param name="id">Getirilecek nesnenin ID değeri</param>
        /// <returns>Belirtilen ID'ye sahip nesne.</returns>
        T GetByID(int id);

        /// <summary>
        /// Veritabanındaki bir nesneyi günceller
        /// </summary>
        /// <param name="t">Güncellenecek nesne</param>
        void Update(T t);
	}
}
