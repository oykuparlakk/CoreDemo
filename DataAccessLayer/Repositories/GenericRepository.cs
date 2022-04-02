﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context _context = new Context();
        public void Delete(T item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
     //git denemesi
}
