



#region Futbol Attack Strategy

var ch = new Character(new AgressiveCombatStrategy());
ch.ApplyAttackStrategy();

ch.SetCombatStrategy(new DefensiveCombatStrategy());
ch.ApplyAttackStrategy();

Console.ReadLine();

interface ICombatStrategy
{
    void Attack();
}

class AgressiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine("Agressive Attack");
    }
}

class DefensiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine("Defensive Attack");
    }
}

class Character
{
    private ICombatStrategy combatStrategy;

    public Character(ICombatStrategy combatStrategy)
    {
        this.combatStrategy = combatStrategy;
    }
    public Character()
    {

    }

    public void SetCombatStrategy(ICombatStrategy combatStrategy)
    {
        this.combatStrategy = combatStrategy;
    }


    public void ApplyAttackStrategy()
    {
        combatStrategy.Attack();
    }
}

#endregion




#region E-Commerce Payment Methods (Real)







interface IPaymentService
{
    bool Pay(PaymentOptions paymentOptions);
}

class PaymentOptions
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }

    public string ExpirationDate { get; set; }

    public string Cvv { get; set; }

    public decimal Amount { get; set; }

}

public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("GarantiBankası ile ödendi");
        return true;
    }
}
public class YapiKrediBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("YapiKrediBankası ile ödendi");
        return true;
    }
}
public class IsBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("IsBankası ile ödendi");
        return true;
    }
}


class PaymentService
{
    private IPaymentService paymentService;

    public PaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }
    public PaymentService()
    {

    }
    public void SetPaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    public bool PayViaStrategy(PaymentOptions paymentOptions)
    {
        return paymentService.Pay(paymentOptions);
    }

}
partial class Program
{
    static void Main()
    {
        PaymentOptions paymentOptionsClass = new()
        {
            CardNumber = "1234-1234-1234-1234",
            CardHolderName = "YASİN ÇOBAN",
            ExpirationDate = "12/23",
            Cvv = "123",
            Amount = 1000

        };

        var paymentService = new PaymentService();

        do
        {
            Console.WriteLine("Ödeme Yapılacak Bankayı Seçiniz (1.Garanti 2.Yapı Kredi 3.İş Bankası)");
            var bank = Console.ReadLine();

            IPaymentService bankPaymentService = null;

            switch (bank)
            {
                case "1":
                    bankPaymentService = new GarantiBankPaymentService();
                    break;
                case "2":
                    bankPaymentService = new YapiKrediBankPaymentService();
                    break;
                case "3":
                    bankPaymentService = new IsBankPaymentService();
                    break;
                default:
                    Console.WriteLine("Geçersiz Banka Seçimi");
                    break;
            }


            paymentService.SetPaymentService(bankPaymentService);
            paymentService.PayViaStrategy(paymentOptionsClass);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);


    }
}



#endregion

