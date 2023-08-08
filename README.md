# InfoTechHrApp



InfoTechHrApp, insan kaynakları yönetimi için çok katmanlı mimari kullanılarak C# dilinde geliştirilmiş bir web uygulamasıdır. Bu uygulama, iş başvurularını yönetmek, çalışanları takip etmek, maaş hesaplamalarını yapmak ve diğer insan kaynakları süreçlerini kolaylaştırmak için tasarlanmıştır.

## Başlangıç

Bu talimatlar, projeyi yerel makinenizde çalıştırmak ve geliştirmek için size yardımcı olacaktır. 

### Gereksinimler

Bu projeyi çalıştırmak için aşağıdaki yazılımların yüklü olduğundan emin olun:

- Visual Studio (2017 veya daha yeni sürüm)
- .NET Core SDK (https://dotnet.microsoft.com/download)
- MSSQL Server (veya başka bir veritabanı yönetim sistemi)

### Kurulum

1. Bu projeyi klonlayın:

Save to grepper
git clone https://github.com/MelihOzaslan01/InfoTechHrApp.git
cd InfoTechHrApp
 Visual Studio ile projeyi açın.

3. Veritabanı bağlantı ayarlarınızı düzenleyin:

Veritabanı bağlantı ayarlarınızı `appsettings.json` dosyasında yapılandırın:

Save to grepper
"ConnectionStrings": {
"DefaultConnection": "Your_Connection_String"
}
