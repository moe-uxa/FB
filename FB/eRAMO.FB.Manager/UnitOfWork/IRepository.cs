using System.Collections.Generic;

public interface IRepository<M, T>
{
    IEnumerable<M> GetAll();
    IEnumerable<X> GetAll<X>();
    M GetById(int id);
    X GetById<X>(int id);
    M Add(T entity);
    X Add<X>(T entity);
    void Delete(T entity);
    void Delete(M model);
    void Delete(int id);
    void Update(T entity);
    void Update(M model);
}
