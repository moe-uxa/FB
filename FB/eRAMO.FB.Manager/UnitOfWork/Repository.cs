using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;

public abstract class Repository<TModel,TEntity> : IRepository<TModel, TEntity> where TModel : class
{
    private readonly DbSet<TModel> _entities;
	private FBEntities _context;

    protected Repository(FBEntities context)
    {
        _entities = context.Set<TModel>();
        _context = context;
    }

    public IEnumerable<TModel> GetAll()
    {
        IEnumerable<TModel> entites = _entities;
        return entites;
    }

    public IEnumerable<T> GetAll<T>()
    {
        IEnumerable<TModel> entites = _entities;
        IEnumerable<T> mappedList = Map<T, TModel>(entites);

        return mappedList;
    }

    public TModel GetById(int id)
    {
        TModel foundEntity = _entities.Find(id);
        return foundEntity;
    }



    public T GetById<T>(int id)
    {
        TModel foundEntity = _entities.Find(id);
        T mappedEntity = Map<T, TModel>(foundEntity);

        return mappedEntity;
    }

    public TModel Add(TEntity entity)
    {
        TModel mappedEntity = Map<TModel, TEntity>(entity);
        return _entities.Add(mappedEntity);
    }

    public T Add<T>(TEntity entity)
    {
        TModel mappedEntity = Map<TModel, TEntity>(entity);
        TModel addedEntity = _entities.Add(mappedEntity);
        return Map<T, TModel>(addedEntity);
    }

    public void Delete(TEntity entity)
    {
        TModel mappedEntity = Map<TModel, TEntity>(entity);
        _entities.Remove(mappedEntity);
    }

    public void Delete(TModel model)
    {
        _entities.Remove(model);
    }

    public void Delete(int id)
    {
        var entity = _entities.Find(id);
        _entities.Remove(entity);
    }

    public void Update(TEntity entity)
    {
        TModel mappedEntity = Map<TModel, TEntity>(entity);
        _context.Entry(mappedEntity).State = EntityState.Added;
        _context.Entry(mappedEntity).State = EntityState.Modified;
    }

    public void Update(TModel model)
    {
        _context.Entry(model).State = EntityState.Modified;
    }

    private Result Map<Result, Source>(Source model)
    {
        Mapper.CreateMap<Source, Result>();
        Result mappedEntity = Mapper.Map<Source, Result>(model);
        Mapper.Reset();
        return mappedEntity;
    }

    private IEnumerable<Result> Map<Result, Source>(IEnumerable<Source> sourceList)
    {
        Mapper.CreateMap<Source, Result>();
        IEnumerable<Result> mappedList = Mapper.Map<IEnumerable<Source>, IEnumerable<Result>>(sourceList);
        Mapper.Reset();
        return mappedList;
    }
}

