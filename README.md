# dbQuery — C# ile Veritabanı Sorgu Yönetimi

Bu proje, C# dilinde yazılmış basit bir veritabanı sorgu yönetim uygulamasıdır. Kullanıcıların SQL sorgularını hazırlamalarına, çalıştırmalarına ve sonuçları görselleştirmelerine olanak tanır.

## Özellikler

- **SQL Sorgu Çalıştırma**: Kullanıcılar, veritabanına bağlanarak SQL sorgularını çalıştırabilirler.
- **Sonuç Görselleştirme**: Sorgu sonuçları, kullanıcı dostu bir arayüzle görselleştirilir.
- **Veritabanı Bağlantı Yönetimi**: Farklı veritabanı bağlantılarını yönetme imkanı sunar.

## Gereksinimler

- .NET Framework 4.7.2 veya daha yeni bir sürüm
- Microsoft SQL Server veya uyumlu bir veritabanı sunucusu
- Visual Studio 2019 veya daha yeni bir sürüm (geliştirme için)

## Başlangıç

### 1. Projeyi Klonlayın

```bash
git clone https://github.com/IbrahimYasinInan/dbQuery.git
```

### 2. Bağımlılıkları Kurun

Proje, NuGet paket yöneticisi aracılığıyla gerekli bağımlılıkları otomatik olarak yükler. Visual Studio kullanıyorsanız, projeyi açtığınızda bağımlılıklar otomatik olarak yüklenecektir.

### 3. Veritabanı Bağlantı Ayarlarını Yapılandırın

`appsettings.json` dosyasını açın ve aşağıdaki bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyDatabase;User Id=myuser;Password=mypassword;"
  }
}
```

### 4. Uygulamayı Çalıştırın

Visual Studio'da projeyi açın ve "Çalıştır" butonuna tıklayarak uygulamayı başlatın.

## Kullanım

- Uygulama açıldığında, ana ekran üzerinden veritabanı bağlantınızı seçin veya yeni bir bağlantı ekleyin.
- SQL sorgunuzu yazın ve "Çalıştır" butonuna tıklayarak sorguyu çalıştırın.
- Sorgu sonuçları, tablolar veya grafikler şeklinde görselleştirilir.

## Katkı

Bu projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları izleyin:

1. Bu repository'yi fork'layın.
2. Yeni bir dal (branch) oluşturun (`git checkout -b feature/ÖzellikAdi`).
3. Değişikliklerinizi yapın ve commit edin.
4. Değişikliklerinizi kendi fork'ınıza push'layın.
5. Pull request (PR) gönderin.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

