# SignalR ile Restoran Yönetim Projesi

![slider](https://github.com/user-attachments/assets/91923854-68cb-435d-ac1a-fff0394635b0)

## 🟢 Projenin Temel Amacı

Geliştirdiğim SignalR projesi, restoran rezervasyonları ve online sipariş işlemlerini kapsamlı bir şekilde yönetir. Kullanıcılar, restorana online olarak sipariş verebilir veya rezervasyon oluşturabilirler. Sipariş vermek için kullanıcıların önce giriş yapmaları gerekmektedir. Giriş yaptıktan sonra, menüdeki yiyecek ve içecekleri seçip sepetlerine ekleyebilirler.

Siparişler ve rezervasyonlar, admin panelinde SignalR teknolojisi kullanılarak gerçek zamanlı olarak görüntülenir. Bu sayede adminler, siparişler ve rezervasyonlar üzerinde anlık olarak işlem yapabilir, onaylayabilir veya iptal edebilirler. Kullanıcılar ve adminler, herhangi bir durum değişikliğinde, ilgili e-posta adreslerine otomatik olarak bilgilendirme alırlar. Bu özellik, tüm işlemlerin hızlı ve etkili bir şekilde takip edilmesini sağlar.
## 🟢 Teknik Detaylar

Bu projeyi ASP.NET Core 6.0 ve SignalR teknolojileri kullanarak geliştirdim. Tüm CRUD işlemlerini API üzerinden gerçekleştirdim ve bu işlemleri MVC tarafında tüketerek dinamik bir yapı oluşturduk. Dinamik veritabanı yönetimi için Entity Framework Code First kullandım. Projeyi daha modüler ve sürdürülebilir kılmak için N Katmanlı mimari yapısına yer verdim. DTO katmanıyla, verileri daha güvenli bir şekilde işledim.

### 📌 Kullanılan Teknolojiler

- ASP.NET Core 6.0
- ASP.NET Core Web API
- SignalR
- PagedList
- MSSQL
- Identity
- AutoMapper
- MailKit
- AutoMapper
- Entity Framework Code First
- HTML, CSS, JavaScript
- Ajax
- Bootstrap

### 📌 Katmanlar

- UI Layer
- Entity Layer
- DataAccess Layer
- Business Layer
- Dto Layer
- Web Api Layer

### 📌 Öne Çıkan Özellikler


- Restorana rezervasyon yapma özelliği
- Rezervsyonları detaylı bir şekilde admin panelinde yönetebilme özelliği
- MSSQL ile ilişkili tablolar
- Online sipariş verme seçeneği
- Identity kütüphanesi kullanarak giriş yapma
- Admin paneli
- Adminlere mesaj ile bilgilendirme
- SignalR ile canlı mesajlaşma (chatbox benzeri)
- SignalR ile masa durumlarını gerçek zamanlı görüntüleme
- Anlık istatistiklerin görüntülenmesi
- E-posta gönderme özellikleri
- Ürünlerde indirim uygulama


###  📌 Admin Panel Özellikler

- Ürünler CRUD işlemler
- Kategoriler CRUD işlemler
- Site üzerinden diğer veriler için CRUD işlemler
- Rezervasyonları sayfa yenilemeden görüntüleme
- Bildirim oluşturma
- Masa durumlarını sayfa yenilemeden görüntüleme
- İndirim oluştruma
- İstatistik görüntüleme


### 📌 Teknik Özellikler

- Asp.net core 6.0
- MSSQL Veritabanı
- N Katmanlı Mimari Yapı
- Web API
- Identity
- AutoMapper
- MailKit
- PagedList
- SignalR ile canlı veri takibi
- Entity Framework Code First LINQ
