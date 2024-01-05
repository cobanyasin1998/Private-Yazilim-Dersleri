

using System.Linq.Expressions;

interface IReadRepository<T>
{
    T GetById(int id);
    IEnumerable<T> List();
    IEnumerable<T> List(Expression<Func<T, bool>> predicate);
}
interface IWriteRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}
interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
{

}
 interface IProductRepository : IRepository<Product>
{

}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public abstract class BaseRepository<T> : IRepository<T>
{
    public virtual void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<T> List()
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public virtual void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
public class ProductRepository : BaseRepository<Product>, IProductRepository
{
   
}