using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{
    //Ayrı klasörlerdeki projelerimizin içerisinde bulunan sınıflara ulaşabilmemiz için bulunduğumuz projeye referance
    //kısmından ulaşmak istenilen projeyi seçmemiz gerek.
    public class MakaleMAPPER : EntityTypeConfiguration<Makale>
    {
        public MakaleMAPPER()
        {
            //Makale class'ımız içerisinde bulunan propertylerimizin niteliklerini belirtiyoruz. 

            //Haskey: Primary Key.
            //Property: Tablo sütunlarını belirtir.

            //HasMaxLength(X) tablo alanımızın maksimum alabileceği değer uzunluğu .
            //IsRequired() tablo alanı boş geçilemez.
            //IsOptional() tablo alanı boş geşilebilir.


            this.HasKey(x => x.Id); //Haskey: oluşacak tablomuzun Primary Key'nı belirtiyoruz.
            this.Property(x => x.Ad).HasMaxLength(100).IsRequired(); //Ad sütunumuzun niteliklerini yazıyoruz.
            this.Property(x => x.OlusturulmaTarihi).IsRequired();//OlusturulmaTarihi sütunumuzun niteliklerini yazıyoruz.
        }
    }
}
