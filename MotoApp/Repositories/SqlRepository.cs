namespace MotoApp.Repositories;
using MotoApp.Data;

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;

public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
    private readonly DbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }
    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }
    public void Add(T item)
    {
        _dbSet.Add(item);
    }
    public void Remove(T item)
    {
        _dbSet.Add(item);
    }
    public void Save()
    {
        _dbContext.SaveChanges();
    }

}
