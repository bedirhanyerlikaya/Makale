using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MakaleBLL : ICUD<Makale>, IListEntity<Makale>
    {
        MakaleDAL _makaleDAL = new MakaleDAL(); 

        public void Insert(Makale entity)
        {
            _makaleDAL.Insert(entity);
        }

        public void Update(Makale entity)
        {
            _makaleDAL.Update(entity);
        }

        public void Delete(Makale entity)
        {
            _makaleDAL.Delete(entity);
        }

        public Makale GetById(int id)
        {
            return _makaleDAL.GetById(id);
        }

        public List<Makale> GetAll()
        {
            return _makaleDAL.GetAll();
        }

        public List<Makale> GetByAll(Expression<Func<Makale, bool>> exprs)
        {
            return _makaleDAL.GetByAll(exprs);
        }

    }
}
