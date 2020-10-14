using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Interface'lerimizi oluşturuyoruz. Bu sayede BLL ve DAL class larımızı Interface kalıtımı alarak hızlıca method oluşturabileceğiz.
    interface IListEntity<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> GetByAll(Expression<Func<T, bool>> exprs);
    }
}
