# Makale Projesi

Makale adında API projemiz var. Bu API üzerinden makale listeleme, arama, ekleme, güncelleme ve silme işlemlerinin REST çağrıları ile yapılması.

## Kullanılan Teknolojiler ve Yapılar

* .Net Framework
* ASP.NET Web API
* Entity Framework
* MSSQL
* Repository Pattern
* Katmanlı Mimari
* Code First


## Projede kullanılan tasarım deseni

Repository tasarım desenini kullandım. Projelerimde sürekli katmanlı mimari ile geliştirmeler yaptığımdan ve Entity Framework teknolojisinden yararlandığımdan dolayı Repository tasarımı bu yapıya uygun olduğunu düşünüyorum, sebebi ise veri işlemleri için bir interface tanımlayıp ve bu interface generic bir yapıya sahip olduğundan birbirinden farklı nesneleri alıp veri işlemlerini hızlıca yapmamızı ve sürekli kod yazmamızı engellemiş oluyoruz. 

## Proje Katmanları

* ENTITY: DAL katmanıyla yüksek oranda ilişkisel nesneleri barındıracak olan Entities katmanı içerisinde uygulamada kullanılacak tüm entity yapılanlarını barındırmaktadır.
* DAL(Data Access Layer): Veritabanı(context) nesnesi ve migration vs. gibi yapılanmaların bulunduğu katmandır.
* MAPPER: ENTITY katmanında bulunan nesnelerin ilişkileri ve niteliklerinin belirtildiği karmandır.
* BLL: Bilindiği gibi her türlü iş, eylem, fiiliyat, algoritma, istatistik vs. yani operasyonel tüm işlevleri kapsayan katmandır.
* API: WEB API katmanıdır.

## Projeye neler eklemek isterdim?

* Başlangıç seviyesi bir API yazdım bu yüzden ilk ekleyeceğim şey "Token" yapısı olurdu.
* User adında bir tablo oluşturup, token ile ilişkilendirip ardından Authentication kontrolleri yapardım.
