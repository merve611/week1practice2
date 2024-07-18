

int sayi;

Console.Write("Lütfen bir sayi giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi == 10)
{
    Console.WriteLine(" sayi 10'a eşittir");
}
else if (sayi < 10)
{
    Console.WriteLine("Sayi 10'dan küçüktür");
}
else
{
    Console.WriteLine("Sayi 10 dan büyüktür");
}


if (sayi % 2 ==0)
{
    Console.WriteLine("Sayi çifttir");
}
else
{
    Console.WriteLine("sayi tektir");
}