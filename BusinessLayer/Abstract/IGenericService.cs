namespace BusinessLayer.Abstract
{
    /// <summary>
    /// Genel (generic) işlemleri tanımlayan bir arayüz. Bu arayüz, herhangi bir türdeki nesneler için temel işlemleri içerir.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericService<T>
	{
		void TAdd(T t);

		List<T> TGetList();

		T TGetByID(int id);

		void TUpdate(T t);
	}
}
