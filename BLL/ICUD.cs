using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Interface'lerimizi oluşturuyoruz. Bu sayede BLL ve DAL class larımızı Interface kalıtımı alarak hızlıca method oluşturabileceğiz.
    interface ICUD<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);

        void Delete(T entity);

    }
}
