using Microsoft.EntityFrameworkCore;
using PhoneBookDataLayer.InterfacesOfRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDataLayer.ImplementationsOfRepo
{
    public class Repository<T, Id> : IRepository<T, Id> where T : class, new()
    {
        protected readonly MyContext _context;
        public Repository(MyContext context)
        {
            _context = context; //DI
        }

        public int Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }



        public IQueryable<T> GetAll(Expression<Func<T, bool>>? filter, string[]? includeRelationalTables)
        {
            //select* from TabloAdi
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                //Eğer koşul verdiyse select * from TabloAdi where koşul/lar
                query = query.Where(filter);
            }
            if (includeRelationalTables != null)
            {
                foreach (var item in includeRelationalTables)
                {
                    query = query.Include(item); //join yapıyor
                }
            }
            return query;
        }
        public T GetByConditions(Expression<Func<T, bool>>? filter = null, string[]? includeRelationalTables = null)
        {
            //select* from TabloAdi
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                //Eğer koşul verdiyse select * from TabloAdi where koşul/lar
                query = query.Where(filter);
            }
            if (includeRelationalTables != null)
            {
                foreach (var item in includeRelationalTables)
                {
                    query = query.Include(item); //join yapıyor
                }
            }
            return query.FirstOrDefault();//query'nin içinden ilk gelen datayı geri dönderir
        }

    }

    public T GetById(Id id)
    {
        try
        {
            return _context.Set<T>().Find(id);
        }
        catch (Exception)
        {

            throw;
        }


    }

    public int Update(T entity)
    {
        try
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
