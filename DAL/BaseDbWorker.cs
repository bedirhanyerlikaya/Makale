using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    //BaseDbWorker class'ımızı oluşturuyoruz, CRUD işlemlerimizi ICUD ve IListEntity adında interface kalıtım alıyoruz.
    //Artık oluşturacağımız ENTITY katmanında bulunan classlarımızın CRUD işlemlerini buradan(BaseDbWorker class'ından) kalıtım aldırtarak kod fazlalığını ortadan kaldırmış olacağız. 
   
    public class BaseDbWorker<T> : ICUD<T>, IListEntity<T> where T : class
    {
        MakaleDbContext _db = new MakaleDbContext();
        //DbContext'imizin instance alıyoruz.


        //Ekleme
        public void Insert(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();

        }

        //Güncelleme
        public void Update(T entity)
        {
            _db.Entry<T>(entity).State = EntityState.Modified;
            _db.SaveChanges();

        }

        //Silme
        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        //Kaydetme
        public void SaveChances()
        {
            try
            {
                _db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Tümünü Getir
        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        //Belirtilen Id elemanını getir
        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        //LINQ kullanarak liste döndürme
        public List<T> GetByAll(System.Linq.Expressions.Expression<Func<T, bool>> exprs)
        {
            return _db.Set<T>().Where(exprs).AsNoTracking().ToList();
        }
    }
}
