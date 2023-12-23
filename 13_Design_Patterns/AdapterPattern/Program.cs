using System.Text;


var trans = new TransferTransaction()
{
    Amount = 10,
    FromIBAN = "TR10",
    ToIBAN = "TR20"
};

var adapter = new JsonBankApiAdapter();
var result = BankApiAdapterFactory.CreateAdapter("json");

Console.WriteLine(result.ToString());



class BankApiAdapterFactory//Factory Pattern
{
    public static IBankApi CreateAdapter(string adapterType)
    {
        switch (adapterType)
        {
            case "json":
                return new JsonBankApiAdapter();
            case "xml":
                return new XmlBankApiAdapter();
            // Add more cases as needed
            default:
                throw new ArgumentException("Invalid adapter type");
        }
    }
}

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi jsonBankApi;

    public JsonBankApiAdapter()
    {
        this.jsonBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
       return jsonBankApi.ExecuteTransaction(transaction);
    }
}
class XmlBankApiAdapter : IBankApi
{
    private readonly XMLBankApi xmlBankApi;

    public XmlBankApiAdapter()
    {
        this.xmlBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return xmlBankApi.ExecuteTransaction(transaction);
    }
}

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("{");
        sb.Append("\"FROMIBAN\"" + ":" + "\"" + transaction.FromIBAN + "\"");
        sb.Append("\"ToIBAN\"" + ":" + "\"" + transaction.ToIBAN + "\"");
        sb.Append("\"FROMIBAN\"" + ":" + "\"" + (transaction.Amount) + ":C2" + "\"");
        sb.Append("}");
        Console.WriteLine($"{GetType().Name} Worked");

        var json = sb.ToString();

        return true;
    }
}
class XMLBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"<TransferTransaction>" +
            $"<FromIBAN>{transaction.FromIBAN}</FromIBAN>" +
            $"<ToIBAN>{transaction.ToIBAN}</ToIBAN>" +
            $"<Amount>{transaction.Amount:C2}</Amount>" +
            $"</TransferTransaction";

        //Call Bank api with xml

        Console.WriteLine($"{GetType().Name} Worked");
        return true;
    }


}

interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}
class TransferTransaction
{
    public string FromIBAN { get; set; }
    public string ToIBAN { get; set; }

    public decimal Amount { get; set; }

}





