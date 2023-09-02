//Doğum Tarihi girilen kişinin yaşını hesaplayan
//uygulamayı yazınız

Console.WriteLine("Lütfen doğum tarihinizi giriniz");

string yil = Console.ReadLine();

bool res = DateTime.TryParse(yil, out DateTime date);
if (res)
{
    int totalDays = (DateTime.Now - date).Days;
    Console.WriteLine(totalDays / 365 + " yaşındasınız.");
}

else
{
    Console.WriteLine("Doğru formatta tarih girmediniz");
}