namespace UserLoginApp;

public interface IRepository<T, TKey>
{
    void Add(T entity);
    T GetById(TKey id);

    IEnumerable<T> GetAll();
    void DeleteById(TKey id);

    void Update(TKey key, T entity);
}
