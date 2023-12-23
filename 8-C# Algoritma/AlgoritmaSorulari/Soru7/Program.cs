


//Girilen pozitif sayının kaç basamaklı olduğunu söyleyen uygulamayı yazınız?

Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
int sayi = int.Parse(Console.ReadLine());

int sonuc = 1;
while (true)
{
    sayi /= 10;
    sonuc++;
    if (sayi < 10)
        break;
}
Console.WriteLine(sonuc);