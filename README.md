# SinemaYonetimPaneli
 Onion Architecture ile MVC kullanılmıştır.<br>
<br>
Login Page bulunmamaktadır.<br>
<br>
<br>
Kullanım Talimatları:<br>
<br>
1- Uygulamanın appsettings.json dosyası üzerinden "ConnectionStrings:" kısmı ayarlanmalıdır. Değiştirilirse Program.cs dosyasından GetConnectionString("XYZ") içerisindeki XYZ yerine yeni ConnectionString belirtilmelidir.<br>
2- Package Manager Console üzerinden add-migration mig_4, sonrasında da update-database işlemleri yapılmalıdır.<br>
3- Soldaki navigasyondan Filmler sayfasına girilebilir.<br>
4- Filmler sayfasında Filmler görüntülenebilir, eklenebilir, düzenlenebilir ve silinebilir.<br>
<br>
<br>
Bilinen sorunlar:<br>
<br>
Gosterim entity'si alınırken yanında Film ile Salon entity'lerini almıyor (null geçiyor). Bu sebeple gösterimlerin listelendiği sayfa çalışmıyor.<br>
<br>
<br>
Soru ve önerilerinizi PM, Mail, LinkedIn gibi yollardan iletebilirsiniz.<br>
<br>
Mail: batuhan22.ozdemir@gmail.com<br>
LinkedIn: linkedin.com/in/batuhanozdemir22<br>
