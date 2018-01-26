﻿using EniWine.Investigacao.Library.Repository.Contracts;
using System;
using System.Data.Entity;
using System.Linq;

namespace EniWine.Investigacao.Library.Repository
{
    public class BaseRepository<T>
       : IDisposable, IBaseRepository<T> where T : class
    {

        private EnieWineContext _context = new EnieWineContext();

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> List()
        {
            return _context.Set<T>();
        }

        public void Add(T item)
        {
            try
            {
                _context.Set<T>().Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(T item)
        {
            try
            {
                _context.Set<T>().Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(int item)
        {
            try
            {
                T itemDatabase = this.Find(item);

                if (itemDatabase == null)
                    throw new Exception("Record not found by id");

                this.Remove(itemDatabase);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

