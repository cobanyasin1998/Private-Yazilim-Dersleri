using System.Xml;
using System.Xml.Serialization;

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;


string xmlFile = @"Settings.xml";
XmlTextReader xmlReader = new XmlTextReader(xmlFile);
Settings settings = new Settings();
try
{
    while (xmlReader.Read())
    {
        switch (xmlReader.Name)
        {
            case "QMSHost":
                settings.QMSHost = Convert.ToString(xmlReader.ReadString());
                break;
            case "QMSPort":
                settings.QMSPort = Convert.ToInt32(xmlReader.ReadString());
                break;
            case "QMSUsername":
                settings.QMSUsername = Convert.ToString(xmlReader.ReadString());
                break;
            case "QMSPass":
                settings.QMSPass = Convert.ToString(xmlReader.ReadString());
                break;
        }
    }
    xmlReader.Close();
    Console.WriteLine("QMS Login Info Details");
    Console.WriteLine("QMS Host - > {0}", settings.QMSHost);
    Console.WriteLine("QMS Port - > {0}", settings.QMSPort);
    Console.WriteLine("QMS Username - > {0}", settings.QMSUsername);
    Console.WriteLine("QMS Pass - > {0}", settings.QMSPass);


    Settings s1 = new Settings
    {
        QMSUsername = "Admin",
        QMSPort = 7000,
        QMSHost = "212.158.95.60",
        QMSPass = "pass123"
    };

    // Verileri Değiştirip Kaydeder
    FileStream fileStream = new FileStream(xmlFile, FileMode.Open);
    XmlSerializer xmlSerializer = new XmlSerializer(s1.GetType());
    xmlSerializer.Serialize(fileStream, s1);
    fileStream.Close();

    Console.ReadLine();

}
catch (Exception e)
{

    xmlReader.Close();
    Console.BackgroundColor = ConsoleColor.Red;

    Console.WriteLine("Xml Dosyası Bulunamadı veya xml dosyasının içeriği yanlış {0}", e.Message);
    Console.ReadLine();
}













public class Settings
{
    public string QMSHost { get; set; }
    public int QMSPort { get; set; }
    public string QMSUsername { get; set; }
    public string QMSPass { get; set; }

}