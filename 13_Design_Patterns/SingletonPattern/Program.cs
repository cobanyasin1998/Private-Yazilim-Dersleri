




using SingletonPattern;
#region ESKİ HALİ
var countryProvider = new Countries();

var countries = await countryProvider.GetCountries();

foreach (var item in countries)
{
    Console.WriteLine(item.Name);
}




//Another Service

var countryProvider1 = new Countries();

var countries1 = await countryProvider1.GetCountries();

foreach (var item in countries1)
{
    Console.WriteLine(item.Name);
}
#endregion


#region YENİ HALI

var countries3 = await Countries.Instance.GetCountries();

foreach (var item in countries3)
{
    Console.WriteLine(item.Name);
}

//Another Service

var countries4 = await Countries.Instance.GetCountries();

foreach (var item in countries4)
{
    Console.WriteLine(item.Name);
}
#endregion