CodeFirstRelation Week12
🎯 Amaç

Bu proje, Entity Framework Core Code First yaklaşımı ile ilişkisel veritabanı modellemesini göstermektedir.
Örnekte User ve Post tabloları arasında 1 -> N (bir kullanıcının birden çok postu olabilir) ilişkisi kurulmuştur.

📂 Proje Yapısı

Context/

PatikaSecondDbContext.cs → Veritabanı bağlantısı ve DbSet tanımları

Entities/

UserEntity.cs → Kullanıcı tablosunu temsil eder

PostEntity.cs → Post tablosunu temsil eder

🏗️ İlişkiler

UserEntity → PostEntity

Bir kullanıcı birden fazla post paylaşabilir (1 -> N ilişki).

UserEntity.Posts → Navigation property

PostEntity.User → Navigation property

PostEntity.UserId → Foreign Key

🚀 Migration ve Veritabanı Güncelleme

Migration oluşturma:

dotnet ef migrations add InitialCreate


Veritabanı güncelleme:

dotnet ef database update
