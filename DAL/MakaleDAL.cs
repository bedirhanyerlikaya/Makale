using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //BaseDbWorker class'ımızdan kalıtım alarak artık CRUD işlemlerimizi BaseDbWorker üzerinden yapacağız.
    public class MakaleDAL : BaseDbWorker<Makale>
    {
        //BaseDbWorker sınıfımızdan kalıtım aldığımız Methodlarımız dışında özel Method üretmek istersek buradan ekleme yapabiliriz.
    }
}
