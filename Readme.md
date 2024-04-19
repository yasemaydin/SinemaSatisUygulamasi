# Proje Hakkında
Bu proje C# dili ve Entity Framework teknolojisi ile yapılmıştır. Windows Form türünde bir projedir. Bu proje sinema bileti satışı yapmak için kodlanan bir projedir.

# Proje Varlıkları
* YaseminAydın.db dosyası veritabanıdır ve uygulamanın derleme klasörü içerisinde bulunur.
* Models adlı klasör veritabanına göre oluşturulmuş sınıfları (Film.cs, Salon.cs ve Seans.cs) içerir.
* Context adlı sınıf context ve model için oluşturulan sınıfdır.

# Pencere Özellikleri
* Projede tek pencere kullanılmıştır.
* Pencerede TabControl özelliği kullanılmıştır.
* 3 tane sayfa (Film, Salon, Seans) kullanılmıştır.

# Film Sayfası
* Film adı, 3 tane seans saati girilir.
* 'Kaydet' adlı kısma basılır.
* Veriler Models\Film sınıfı özelliklerine göre biçimlendirilir.
* Veriler veritabanına kayıt edilir.

# Salon Sayfası
* Salon adı ve kapasitesi girilir.
* 'Kaydet' adlı kısma basılır.
* Veriler Models\Salon sınıfı özelliklerine göre biçimlendirilir.
* Veriler veritabanına kayıt edilir.

# Seans Sayfası
* Film adı, film seansı, seans tarihi, salon adı, müşteri adı, müşteri soyadı ve kimlik numarası girilir.
* 'Kaydet' adlı kısma basılır.
* Veriler Models\Seans sınıfı özelliklerine göre biçimlendirilir.
* Veriler veritabanına kayıt edilir.

# Not
* Veritabanına bir film, bir salon ve bir müşteri bilgisi kayıt edilmiştir.
