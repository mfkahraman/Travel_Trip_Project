Proje, iki ana bölümden oluşuyor:
Anasayfa: Herkesin erişebileceği kısmı, şehirler, restoranlar ve otellerle ilgili blog yazıları içeriyor. Kullanıcılar, blog sayfalarına yorum ekleyebiliyor ve yorumlar ilgili bloglarda listeleniyor. Ayrıca, kullanıcılar iletişim formu aracılığıyla bana mesaj gönderebiliyor ve bu mesajlara Admin panelinden erişebiliyorum.
Admin Paneli: Yalnızca yetkilendirilmiş adminlerin erişebileceği panelde, anasayfadaki her sekme için (Bloglar, Restoranlar, Oteller) CRUD işlemleri, görsel ekleme ve güncelleme işlemleri yapılabiliyor. Gelen mesajlar yönetilebiliyor.

Projede yer alan bazı özellikler:
İzinsiz giriş yapmaya çalışan kullanıcılar, admin sayfalarına erişmek istediklerinde login ekranına yönlendiriliyor.
Görsel eklerken, her görsel GUID ile isimlendirilip projeye dahil ediliyor ve görsel silme altyapısı kuruluyor. Bir blog silindiğinde veya güncellendiğinde eski görselin sistemden kaldırılması sağlanıyor.
PartialView yapısı kullanarak, projenin her bölümünü modüler hale getirdim ve daha temiz bir yapı elde ettim.

Kullanılan teknolojiler:
.NET MVC
HTML, CSS, Bootstrap, JavaScript, jQuery
Entity Framework (Code First)
PagedList NuGet (Paging)
Modal Yapısı (Mesaj Görüntüleme)
GUID ile isimlendirme
PartialView, PartialClass
Authorization, Session, Login, Logout

![Ekran görüntüsü 2024-12-19 194756](https://github.com/user-attachments/assets/3144aeca-df7e-49de-8300-1f148c79102e)
![Ekran görüntüsü 2024-12-19 194947](https://github.com/user-attachments/assets/116686ba-a743-4f66-9f31-678888331b8f)
![Ekran görüntüsü 2024-12-19 194925](https://github.com/user-attachments/assets/9617d48e-69b8-4cf0-980d-b6ff874fb7f5)
![Ekran görüntüsü 2024-12-19 200547](https://github.com/user-attachments/assets/3b03f7a8-02a5-4410-ba38-934d872b15bd)
![Ekran görüntüsü 2024-12-19 200538](https://github.com/user-attachments/assets/d0e130dc-2224-4b56-82bc-2c21b0af90eb)
![Ekran görüntüsü 2024-12-19 200528](https://github.com/user-attachments/assets/cac7721e-d656-4e17-b262-56ae2c4519ec)
![Ekran görüntüsü 2024-12-19 200508](https://github.com/user-attachments/assets/209fa687-8ea7-46e7-b9f5-8a017f96c2db)
![Ekran görüntüsü 2024-12-19 200501](https://github.com/user-attachments/assets/b61c74ef-1a99-47f6-bf16-5de537d664f3)
![Ekran görüntüsü 2024-12-19 200453](https://github.com/user-attachments/assets/34b9bc78-387e-4062-aeaa-7d74a6065f09)
![Ekran görüntüsü 2024-12-19 200439](https://github.com/user-attachments/assets/3e2f4923-36cd-4fc3-8052-98a3fbc03a81)
![Ekran görüntüsü 2024-12-19 200422](https://github.com/user-attachments/assets/b5626422-ec4e-46c7-aa73-de57b8a7498a)
![Ekran görüntüsü 2024-12-19 200413](https://github.com/user-attachments/assets/3be42330-3a3f-4178-8c9a-ccdf774fbc58)
![Ekran görüntüsü 2024-12-19 200353](https://github.com/user-attachments/assets/c485602d-1512-4f5c-8127-b7c041c8c76a)
![Ekran görüntüsü 2024-12-19 195318](https://github.com/user-attachments/assets/dd20dc97-34a2-4e48-a9e1-1524d1d01bda)
![Ekran görüntüsü 2024-12-19 195035](https://github.com/user-attachments/assets/5992752c-3ea2-4167-a49e-3c139fa772f4)
![Ekran görüntüsü 2024-12-19 195021](https://github.com/user-attachments/assets/1b1b0dbb-dfdc-446f-b04f-dd0f79f4b7c3)

![Ekran görüntüsü 2024-12-19 194716](https://github.com/user-attachments/assets/69079b4d-4cb3-4f36-a929-056c705003fd)
![Ekran görüntüsü 2024-12-19 203252](https://github.com/user-attachments/assets/25a43325-ff3f-48da-add7-302c3de85624)
![Ekran görüntüsü 2024-12-19 195002](https://github.com/user-attachments/assets/43c0bf08-c1f0-482d-bcfe-127d5ef10aa9)
