﻿namespace MotoApp.Repositories;

using MotoApp.Entities;
using System;

public class ListRepository<T> : IRepository<T> where T : class, IEntity, new()
{
   
    private readonly List<T> _items = new();
    private readonly List<double> nums = new();

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();
    }

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
    public T GetById(int id)
    {
        return _items.Single(item => item.Id == id);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }
    public void Add(double num)
    {
        nums.Add(num);
    }
}