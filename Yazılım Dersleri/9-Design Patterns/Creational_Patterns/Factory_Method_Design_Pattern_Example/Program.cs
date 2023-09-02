

#region Eski Hali
//GarantiBank garantiBank = new GarantiBank("asd", "123");
//garantiBank.ConnectGaranti();


//VakifBank vakifBank = new VakifBank(
//    new CredentialVakifBank()
//    {
//        Mail = "cobanyasin1998@gmail.com",
//        UserCode = "yasin"
//    }, "coban");
//vakifBank.ValidateCredential();


//HalkBank halkBank = new HalkBank("Coban");
//halkBank.Password = "123";

#endregion

#region Yeni Hali

BankCreater.Create(IBankType.Garanti);
BankCreater.Create(IBankType.VakifBank);
BankCreater.Create(IBankType.HalkBank);

BankCreater.Create(IBankType.Garanti);
BankCreater.Create(IBankType.VakifBank);
BankCreater.Create(IBankType.HalkBank);
#endregion







#region Concrete Products
class GarantiBank : IBank
{
    string _userCode, _password;

    public static GarantiBank GetInstance => _garantiBanka;
    static GarantiBank _garantiBanka;
    static GarantiBank() => _garantiBanka = new GarantiBank("asd", "123");
    private GarantiBank(string userCode, string password)
    {
        Console.WriteLine($"{nameof(GarantiBank)} nesnesi üretildi");
        _userCode = userCode;
        _password = password;
    }
    public void ConnectGaranti() => Console.WriteLine($"{nameof(GarantiBank)} - Connected");
    public void SendMoney(int amount) => Console.WriteLine($"{amount} money sent.");
}
class HalkBank : IBank
{
    string _userCode, _password;
    private HalkBank(string userCode)
    {
        Console.WriteLine($"{nameof(HalkBank)} nesnesi üretildi");

        _userCode = userCode;

    }
    public static HalkBank GetInstance => _halkBanka;

    static HalkBank _halkBanka;
    static HalkBank() => _halkBanka = new HalkBank("asd");
    public string Password { set => _password = value; }

    public void Send(int amount, string accountNumber) => Console.WriteLine($"{amount} money sent.");
}
class CredentialVakifBank : IBank
{
    public string? UserCode { get; set; }
    public string? Mail { get; set; }
}
class VakifBank : IBank
{
    string _userCode, _email, _password;
    public bool IsAuthentication { get; set; }
    static VakifBank _vakifBankBanka;
    static VakifBank() => _vakifBankBanka = new VakifBank(new CredentialVakifBank()
    {
        Mail = "cobanyasin1998@gmail.com",
        UserCode = "yasin"
    }, "coban");
    public static VakifBank GetInstance => _vakifBankBanka;

    private VakifBank(CredentialVakifBank credential, string password)
    {
        Console.WriteLine($"{nameof(VakifBank)} nesnesi üretildi");

        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;
    }
    public void ValidateCredential()
    {
        if (true)//Validating
        {
            IsAuthentication = true;
        }

    }
    public void SendMoneyToAccountNumber(int amount, string recipientName, string accountNumber) =>
        Console.WriteLine($"{amount} money sent.");
}

#endregion

#region Abstract Product
interface IBank
{

}

#endregion

#region  Abstract Factory
interface IBankFactory
{
    IBank CreateInstance();
}
#endregion

#region Concrete Factories

//Bunlarda singleton'a çekilebilir.
class GarantiFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        GarantiBank garanti = GarantiBank.GetInstance;
        garanti.ConnectGaranti();
        return garanti;
    }
}
class HalkBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        HalkBank halkBankasi = HalkBank.GetInstance;
        halkBankasi.Password = "123";
        return halkBankasi;
    }
}
class VakifBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {

        VakifBank vakifBank = VakifBank.GetInstance;
        vakifBank.ValidateCredential();

        return vakifBank;
    }
}
#endregion

#region Creater
enum IBankType
{
    Garanti, HalkBank, VakifBank
}
static class BankCreater
{
    public static IBank Create(IBankType bankType)
    {
        IBankFactory _bankFactory = bankType switch
        {
            IBankType.VakifBank => new VakifBankFactory(),
            IBankType.HalkBank => new HalkBankFactory(),
            IBankType.Garanti => new GarantiFactory(),
        };
        return _bankFactory.CreateInstance();
    }
}

#endregion