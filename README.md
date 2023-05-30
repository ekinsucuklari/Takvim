# Takvim

Bu takvim uygulaması aşağıdaki user storyler kapsamında geliştirilmiştir :

-Sisteme Kayıt olabilmesi ve bu bilgilerin veri tabanında tutulması,

-Takvim uygulamasını kullanacak olan kişi istediği zaman, bir olay tanımlaması yapabilmesi,

-Kullanıcı uygulamayı açtığında istediği bir güne gidebilecek ve o günü seçtiğinde o gün ile alakalı hangi toplantı ve/veya işleri var bunları görebilecek isterse silip, güncelleyebilmesi,

-Olay ile ilgili tanımladığımız zamanı geldiğinde bir çağrı sesi ile olayın hatırlatılması.

## Kurulum
1- Proje deposunu klonlayın

2- kullanici_bilgi.bacpac dosyasını kendi veritabanı uygulamanıza import edin

3- SignIn.cs'deki SQL bağlantısı kontrolünün adını değiştirin. Kendi bağlantınızı girin. 
## Kullanım
Gerekli kurulumlar yapıldıktan sonra programı derleyicinizde çalıştırın. Karşınıza gelen kayıt olma ekranında girecek kullanıcı adınız ve şifreniz yoksa "Kayıt Ol" yazısına tıklayarak kayıt olma ekraına geçin gerekli bilgileri doldurun. Programı tekrar çalıştırın. Kullanıcı adını ve şifreyi girin. Giriş butonuna tıklayın. Karşınıza sistem tarihinizi kullanarak oluşturulan bir takvim ekranı gelecek. Bu ekrandaki günlere tıklayarak etkinlik kaydı oluşturabilir, güncelleyebilir ve silebilirsiniz. Eğer bir etkinlik kaydettiyseniz ve saati geldiyse ekrana bir messagebox çıkıp alarm çalacaktır. "Tamam"a basıp kapatabilirsiniz.  
## Emeği Geçenler
Ahmet Melih KARA

Ekinsu Eylül ASLAN

Özlem ELMALI

## Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.
