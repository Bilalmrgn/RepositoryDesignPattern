🧅 Onion Architecture + Generic Repository

Bu proje, Onion Architecture yapısını öğrenmek ve Generic Repository Pattern’i uygulamak amacıyla geliştirilmiştir.
ASP.NET Core Web API ve Entity Framework Core kullanılmıştır.

🏗️ Mimari Yapı

Proje Onion Architecture prensiplerine göre katmanlara ayrılmıştır:

📌 Domain

Entity sınıfları burada bulunur.

En iç katmandır.

Hiçbir katmana bağımlı değildir.

📌 Application

Interface’ler (IRepository vb.)

Soyutlamalar

İş kurallarının kontratları

📌 Infrastructure

EF Core

DbContext

Repository implementasyonu

Veritabanı işlemleri

📌 Presentation (WebAPI)

Controller sınıfları

API endpoint’leri

Dış dünya ile iletişim

🔄 Bağımlılık Prensibi

Bağımlılıklar içe doğrudur:

Presentation → Application → Domain

Infrastructure, Application katmanındaki interface’leri implement eder.

🛠️ Kullanılan Teknolojiler

ASP.NET Core Web API

Entity Framework Core

SQL Server

Generic Repository Pattern

Onion Architecture

🎯 Amaç

Bu proje ile:

Katmanlı mimariyi öğrenmek

Bağımlılıkların nasıl yönetildiğini görmek

Repository Pattern kullanımını anlamak

hedeflenmiştir.
