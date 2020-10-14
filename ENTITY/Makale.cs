using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    //Makale adında bir class oluşturuyoruz, ardından propertylerini ekliyoruz.
    //Entity Framework aracını kullanarak Code First yapısını kullanacağız.
    //Burada oluşturduğumuz class tablomuz, propertyleri ise tablomuzun sütunları olacaktır. 
    public class Makale
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
