# 🛵 KuryeLojistikSistemi - Canlı Kurye Takip ve Akıllı Dağıtım Sistemi

Lojistik ve kurye firmaları için geliştirilmiş, kurye yönetimi, sipariş kabul ve rota mesafe takibini ilişkisel veritabanı mimarisiyle anlık olarak yöneten kurumsal bir operasyon otomasyonudur.

## 🛠️ Kullanılan Teknolojiler
* **C# 13** & .NET 9.0 (Blazor Server State Machine Altyapısı)
* **JavaScript** (Tarayıcı Seviyesinde RegEx Telefon Filtreleme Motoru)
* **HTML5** & Bootstrap CSS (Lojistik Dashboard Arayüz Tasarımı)
* Entity Framework Core & SQLite Veritabanı

## 🚀 Ne Yapıyor?
* **Kalıcı Lojistik Veri Tabanı:** Tüm kurye, restoran sipariş ve teslimat verileri SQLite veritabanında (`kurye_lojistik.db`) güvenli ve kalıcı olarak saklanır.
* **Canlı Kurye Durum Yönetimi:** Saha kuryelerini araç türlerine ve canlı durumlarına (Boşta, Dağıtımda) göre SQL şemasında haritalandırır.
* **Akıllı Kurye Atama Algoritması:** Yeni sipariş girildiği an sistemdeki boştaki kuryeleri tarar, otomatik olarak siparişe atar ve kurye durumunu anlık kilitler.
* **Süreç ve Durum Takibi:** Siparişlerin "Hazırlanıyor", "Yolda" ve "Teslim Edildi" aşamalarını yönetir. Sipariş teslim edildiği an kuryeyi otomatik olarak "Boşta" durumuna geri çeker.
