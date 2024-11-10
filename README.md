<h1>RentCar - Araç Kiralama Sitesi</h1>


* Araç kiralama sürecini verimli bir şekilde yönetmek için tasarlanmış, kapsamlı bir .Net Core projesidir. Sistem, kullanıcılar için geniş araç yelpazesinden araçları görüntüleyebilecekleri ve tercih ettikleri araçları belirlemek için özel filtreleme seçenekleri sunar. 
* RentCar, araç kiralama süreçlerini modern bir altyapı ile yönetmeyi hedefleyen kapsamlı 
bir .NET Core uygulamasıdır. Uygulama, kimlik doğrulama ve rol tabanlı erişim yönetimi ile admin ve kullanıcılar için ayrı paneller sunmaktadır.
* Ayrıca, admin panelinde rezervasyonlar, araçlar ve kullanıcılar hakkında istatistiksel analizler yaparak verileri anlamlı grafikler ve raporlar ile görselleştirir. Bu sayede, araçların 
popülerliği, rezervasyon yoğunluğu ve kullanıcı tercihleri gibi bilgileri analiz ederek iş süreçlerini optimize edebilir. 


![1](https://github.com/user-attachments/assets/599ae3fe-8ee6-4361-8c98-9660e9a63c6b)


### Admin/Yönetici Rolü 
---
* 📜 **Anasayfa İşlemleri :** Yönetici sitedeki görünür tüm sayfaları admin panelinden düzenleyebilir, güncelleme yapabilir ve kontrol edebilir.
* 🚗 **Araç İşlemleri :** Admin, sisteme eklenen araçların tüm özelliklerini (model, marka, fiyat, motor tipi, yakıt türü vb.) yönetebilir, yeni araç ekleyebilir ve mevcut araçların bilgilerini dilediği zaman güncelleyebilir.
* 📊 **Analiz İşlemleri :** Admin panelde rezervasyonlar, araçlar ve kullanıcılar hakkında istatistiksel analizler yaparak verileri anlamlı grafikler ve raporlar ile görselleştirir.
* 💬 **Değerlendirme İşlemleri :** Yönetici bloglara ve kiralama işlemlerine yapılan genel yorumlarla ilgili tüm işlemleri yapabilir.
* 🚖 **Rezervasyon İşlemleri :** Admin tüm araçların rezervasyon geçmişini görüntüleyebilir, araçların müsaitlik durumlarını değiştirebilir; tüm araçlara kiralama periyoduna göre fiyat belirleyebilir.
* :telephone: **İletişim İşlemleri :** Yönetici iletişim bilgilerini listeleyebilir, konum bilgisi ekleyebilir, silebilir ve düzenleyebilir.

### Ziyaretçi Rolü 
---
* 📌 **Rezervasyon** : Kullanıcılar, sisteme giriş yaparak geniş bir araç yelpazesinden seçim yapabilir, filtreleme özellikleri ile ihtiyaçlarına uygun araçları hızla bulup çevrimiçi rezervasyon işlemlerini gerçekleştirebilirler
* 💭 **Değerlendirme** : Kullanıcılar, deneyimlerini diğer kullanıcılarla paylaşarak araçlara yorum yapabilir, aynı zamanda okudukları bloglara değerlendirme yapabilirler.

</br>

### Kullanılan Teknolojiler
___
**Backend**
___
- **Asp.Net Core 8.0:** Backend tarafı C# dili ile yazılmıştır.
- **MSSQL:** Veritabanı olarak Microsoft SQL Server kullanılmıştır.
- **Swagger:** API dökümantasyonu için Swagger kullanılmıştır.
- **Onion Architecture Mimarisi:** Backend tarafında Onion Architecture mimarisi kullanılmıştır.
- **CQRS:** Onion Architecture'da statik tablolar için CQRS tasarım deseni kullanılmıştır.
- **Mediator:** Onion Architecture'da düzenleme işlemlerinin olduğu tablolar için Mediator tasarım deseni kullanılmıştır.
- **Fluent Validation:** Validasyon işlemleri için Fluent Validation kullanılmıştır.
- **JSON Web Token:** Kullanıcının yetki işlemleri için JSON Web Token kullanılmıştır.
- **Entity Framework Code First Yaklaşımı:** Veritabanı tabloları Code First yaklaşımı ile oluşturulmuştur.
- **SignalR:** Araç sayılarını güncel listelemek için kullanılmıştır.

**Frontend**
___
- **HTML:** Sitenin temel yapısı için HTML kullanılmıştır.
- **CSS:** Sitenin stil işlemleri için CSS kullanılmıştır.
- **Bootstrap:** Hoş bir arayüz için Bootstrap kullanılmıştır.
- **JavaScript:** Sayfa etkileşimleri için JavaScript kullanılmıştır.

&nbsp;

**Proje Yapısı ve Katmanlı Mimarisi**
___
Proje aşağıdaki katmanlı mimarisi takip eder:
- **Core:** Bu katmanda Application ve Domain alt katmanları bulunur.
- **Domain:** Bu katmanda veritabanı tablosundaki Entity'ler yer alır.
- **Application:** Bu katman iş katmanıdır. Tasarım desenleri olan CQRS ve Mediator temel yapıları yer alır.
- **Infrastructure:** Bu katmanda veritabanı dosyası ve Repository'ler bulunur.
- **Presentation:** Bu katman sunum katmanıdır. Bu katmanda Web API bulunur.


### Proje Görselleri
---

![2](https://github.com/user-attachments/assets/b278cfe2-27e6-4df4-9efc-2538c6f228cb)

![3](https://github.com/user-attachments/assets/d589a4e8-ff24-456e-8617-0843efa1c635)

![4](https://github.com/user-attachments/assets/4422da0a-7af4-48e0-b270-01d4da895150)

![5](https://github.com/user-attachments/assets/fabcf0a3-7c8c-4d1c-a73a-6864999372af)

![6](https://github.com/user-attachments/assets/3a5112ca-4b07-41d6-b045-0823f9e8cdfe)

![7](https://github.com/user-attachments/assets/05feaa0e-4a40-4996-ae6e-44b015df344c)

![8](https://github.com/user-attachments/assets/49121758-5ef9-4efb-8c20-1f83062792e4)

![9](https://github.com/user-attachments/assets/f5b36115-4cca-4ecc-aa51-b2a9ddc270b9)

![10](https://github.com/user-attachments/assets/e4735da6-e76e-4fae-900a-0df707d28db3)

![11](https://github.com/user-attachments/assets/d176d548-d0bf-4302-9187-08d3a568a723)

![a1](https://github.com/user-attachments/assets/2d3481b1-ffa8-42a7-ac33-7c0f3b9d7816)

![a1new](https://github.com/user-attachments/assets/49cc08d2-01b2-40b6-8aea-714b193934b3)

![a2](https://github.com/user-attachments/assets/da876c22-32f4-486f-b98e-5c388e32dcf3)

![Screenshot_1](https://github.com/user-attachments/assets/20ba4a75-1487-4b32-911f-f0269a8f1c68)

![a3](https://github.com/user-attachments/assets/2b1acbef-fae1-438d-9e71-51ebe6c27cfa)

![a4](https://github.com/user-attachments/assets/e7dd4631-6919-4dda-93cf-396f47a87d7f)

![Screenshot_5](https://github.com/user-attachments/assets/2ed80ac8-f26a-4baa-9f85-9b0a827232b8)
