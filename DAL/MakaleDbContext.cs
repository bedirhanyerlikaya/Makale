using ENTITY;
using MAPPER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DAL
{
    public class MakaleDbContext : DbContext
    {

        //DAL katmanımızda ki App.config dosyamız içerisinde bulunan "baglanti" adında ConnectionString'imizi burada çağırıyoruz.

        public MakaleDbContext() 
            : base(WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString) 
        {
            //Tüm işlemleri yaptıktan sonra Package Manager Console ekranına girip Default Project kısmında DAL katmanımızı seçmemiz gerek ardından şu adımları takip edeceğiz:
            //Not:Projemiz'in DAL katmanımız içerisindeki App.config dosyasını görmesi için Set as Stratup Project seçmemiz gerekiyor, aksi durumda App.config dosyamızı göremeyecektir.

            //1. Adım Migration oluşturma 
            //>> enable-migrations
            //işlem başarılı bittiğinde DAL katmanımızda Migration klasörümüz oluşup altında Configuration class'ı oluşacaktır.
            //class içerisine girip AutomaticMigrationsEnabled kısmını göreceksiniz bu özellik sayesinde veri tabanımızı otomatik güncelleştiriyor.
            //False kalırsa otomatik veri tabanımız güncellenmeyecektir.
            //2. Adım Database Update etme
            //>> update-database
            //No pending explicit migrations.
            //Applying automatic migration: 202010131138000_AutomaticMigration.
            //Running Seed method.
            //Artık Database de Makaleler adında tablomuzun olduğunu göreceksiniz güncelleme işlemimiz başarı oldu!
            //Ek olarak __MigrationHistory adında tablomuz oluştu bu ise güncelleştirilmiş Database'mizin o 
            //halini tutar ileride problem yaşarsak buradan istediğimiz Migration'ı çağırıp DataBase'imizi kurtarabiliriz.
        }

        DbSet<Makale> Makale { get; set; } //Tablo ismini belirliyoruz.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // Tablo isimleri sonundaki çoğul eklerini kaldırır.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // CasCade işlemlerini kaldırır.

            
            modelBuilder.Configurations.Add(new MakaleMAPPER()); // Oluşturduğumuz EntityTypeConfiguration sınıfımızda bulunan kriter ve niteliklerimizi belirtiyoruz.

        }

    }
}
