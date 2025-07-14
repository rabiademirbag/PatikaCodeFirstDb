# 🧪 Pratik - Code First Relation

Bu örnek projede, Entity Framework Core kullanılarak **Code First** yaklaşımı ile ilişkili iki tablo (User ve Post) oluşturulmuştur.

---

## 🎯 Amaç

Bir kullanıcının birden fazla gönderisi (Post) olabilir, ancak her gönderi yalnızca bir kullanıcıya aittir. Bu, klasik bir **bire-çok (one-to-many)** ilişkidir.

---

## 🧱 Veritabanı Yapısı

**Veritabanı Adı**: `PatikaCodeFirstDb2`  
**Context Sınıfı**: `PatikaSecondDbContext`  
**Tablolar**: `Users`, `Posts`
