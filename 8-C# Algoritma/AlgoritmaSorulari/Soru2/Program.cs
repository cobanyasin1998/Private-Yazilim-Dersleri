
//Kullanıcının girdiği iki sayının karelerinin
//toplamını veren uygulamayı yazınız?

#region Çözüm 1

//Console.WriteLine("Lütfen birinci sayıyı giriniz");
//int sayi1 = int.Parse(Console.ReadLine());



//Console.WriteLine("Lütfen ikinci sayıyı giriniz");
//int sayi2 = int.Parse(Console.ReadLine());


//int sonuc = sayi1 * sayi1 + sayi2 * sayi2;
//Console.WriteLine(sonuc);

//Console.ReadLine();

#endregion

#region Çözüm 2
//Console.WriteLine("Lütfen birinci sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine("Lütfen ikinci sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());


//double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
//Console.WriteLine(sonuc);

//Console.ReadLine();

#endregion

#region Çözüm 3
Console.WriteLine("Lütfen birinci ve ikinci sayıyı giriniz");
Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2));


#endregion

