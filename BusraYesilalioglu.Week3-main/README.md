# 3. Hafta Ödev

Veritabanı
- *sp_student_education : Öğrencinin aldığı eğitimi,eğitmenini ve başarı durumu görünür.
- *sp_assistant_education : Hangi asistanın hangi eğitimde görevli olduğu görünür.
- *sp_participant_education : Katılımcının bulunduğu eğitimleri gösterir.
- *sp_student_attendance : Öğrencinin yoklama durumu görünür.
- *sp_education_add_student : Mevcut bir öğrenciyi bir eğiteme atar.(Öğrencinin başka bir eğitim almaması şartı ile).Ek olarak yoklama listesi ve başarı id oluşturur.(3.Maddeyi karşılıyor.)
- *sp_new_student_add : Yeni bir öğrenci ekler.(Aynı id'ye sahip öğrenci varsa eklemez ve mesaj verir.)
- *sp_new_teacher_add : Yeni bir eğitmen ekler.(Aynı id'ye sahip öğrenci varsa eklemez ve mesaj verir.)
- *Trigger: attendance_success_status : Bu trigger ile girilen yoklama durumuna göre başarı durumu belirlenir.
- *View: view_students_group_education: select * from view_students_group_education ile öğrencileri eğitim bazlı sıralar


Veritabanı 
1. Patikadev yapısını düşünerek bir db oluşturun
  - eğitimler, öğrenciler,katılımcılar,eğitmenler,asistanlar, eğitimde öğrencilerin yoklamalarının ve başarı durumlarının tutulduğu tablolar olacaktır.
  - veritipleri ve ilişkiler belirtilmelidir.
2. trigger yazın
  - öğrenci yoklaması girildiğinde. yoklama durumuna göre başarı durumunu hafta bazlı olarak güncelleyin.(Örn: eğitim 7 hafta olsun. ilk iki hafta derslere katıldı ise başarı oranı 2/7 nin % olarak karşılı olmalı.)
3. stored procedure yazın
  - öğrencileri eğitimlere ekleyen bir procedure olacak. öğrenci belirtilen eğitim tarihinde herhangi başka bir eğitime kayıtlı olmamalıdır.
4. view yazın
  - eğitim bazlı öğrencileri listeleyin(gruplu olarak)

# Bonus
- Aynı yapıyı ef code first olarak sadece model bazında oluşturun
