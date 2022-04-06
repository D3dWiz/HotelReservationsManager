﻿using System;
using System.Linq;
using System.Collections.Generic;
using HotelReservationsManager.DAL.Data;
using HotelReservationsManager.DAL.Entities;
using HotelReservationsManager.DAL.Abstractions;

namespace HotelReservationsManager.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HotelDbContext _context;
        public Repository(HotelDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() != 0;
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _context.Set<T>()
                .FirstOrDefault(predicate);        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() != 0;
        }

        public bool RemoveById(int id)
        {
            var item = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Set<T>().Remove(item);
                return _context.SaveChanges() != 0;
            }
            else
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            if (entity.Id != 0)
            {
                _context.Update(entity);
                return _context.SaveChanges() != 0;
            }
            else
            {
                return false;
            }
        }
    }
}