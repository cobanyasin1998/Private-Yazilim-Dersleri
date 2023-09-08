static int MutlakDeger(int n)
{
    if (n > 0)
        return n;
    else if (n < 0)
        return n * -1;
    else
        return 0;
}
Console.WriteLine(MutlakDeger(-5));
Console.ReadLine();
