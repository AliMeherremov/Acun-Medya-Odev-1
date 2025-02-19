// ALI MEHERREMOV
//-----------------------------------------------------

using System.Text.RegularExpressions;

//-----------------------------------------------------
Console.Write(" Ödev: 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else) "); 
//-----------------------------------------------------

Console.WriteLine("Lütfen sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi == 0)
{
    Console.WriteLine("Girdiğiniz sayı 0'dır.");
}
else if (sayi > 0)
{
    Console.WriteLine("Girdiğiniz sayı pozitiftir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı negatiftir.");
}

//-----------------------------------------------------
Console.Write(" Ödev: 2: Gün İsmi Belirleme (switch-case) ");
//-----------------------------------------------------

Console.Write("Lütfen gün seçiniz:");
int gun = Convert.ToInt32(Console.ReadLine());

switch (gun)
{
    case 1:
        Console.WriteLine("Seçilen Gün: Pazartesi");
        break;
    case 2:
        Console.WriteLine("Seçilen Gün: Salı");
        break;
    case 3:
        Console.WriteLine("Seçilen Gün: Çarşamba");
        break;
    case 4:
        Console.WriteLine("Seçilen Gün: Perşembe");
        break;
    case 5:
        Console.WriteLine("Seçilen Gün: Cuma");
        break;
    case 6:
        Console.WriteLine("Seçilen Gün: Cumartesi");
        break;
    case 7:
        Console.WriteLine("Seçilen Gün: Pazar");
        break;
}

//-----------------------------------------------------
Console.Write(" 3: Basit Hesap Makinesi(switch-case) ");
//-----------------------------------------------------

Console.WriteLine("Birinci sayiyi giriniz");
double sayi01 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayiyi giriniz");
double sayi02 = Convert.ToDouble(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
char islem = Convert.ToChar(Console.ReadLine());

double sonuc;


switch (islem)
{
    case '+':
        sonuc = sayi01 + sayi02;
        Console.WriteLine("Sonuç:" + sonuc);
        break;

    case '-':
        sonuc = sayi01 - sayi02;
        Console.WriteLine("Sonuç:" + sonuc);
        break;

    case '*':
        sonuc = sayi01 * sayi02;
        Console.WriteLine("Sonuç:" + sonuc);
        break;

    case '/':
        if (sayi02 != 0)
        {
            sonuc = sayi01 / sayi02;
            Console.WriteLine("Sonuç:" + sonuc);
        }
        else
        {
            Console.WriteLine("Hata: 1 Sayı sıfıra bölünemez");
        }
        break;

    default:
        Console.WriteLine("Hata: Lütfen +, -, *, / işlemlerinden birini giriniz.");
        break;
}

//-----------------------------------------------------
Console.Write(" Ödev: 4-Üç Sayının En Büyüğünü Bulma (if-else) ");
//-----------------------------------------------------

Console.WriteLine("1. Sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Sayıyı giriniz:");
int sayi3 = Convert.ToInt32(Console.ReadLine());

int enbuyuksayi;

if (sayi1 >= sayi2 && sayi1 >= sayi3)
{
    enbuyuksayi = sayi1;
}
else if (sayi2 >= sayi1 && sayi2 >= sayi3)
{
    enbuyuksayi = sayi2;
}
else
{
    enbuyuksayi = sayi3;
}

Console.WriteLine("En büyük sayı:" + enbuyuksayi);

//-----------------------------------------------------
Console.Write(" Ödev: 5 - Şifre Güçlülüğünü Kontrol Etme (if-else) ");
/*🎯 Amaç: Kullanıcının girdiği şifrenin güçlü olup olmadığını kontrol eden program yaz.
📌 Koşullar:

Şifre en az 8 karakter uzunluğunda olmalı.
Şifre içinde @, #, $, % gibi özel karakterler içermeli.
Şifre en az 1 büyük harf içermeli.*/

//-----------------------------------------------------

Console.WriteLine("Şifreniz en az 8 karakter uzunluğunda olmalı.");
Console.WriteLine("Şifre içinde @, #, $, % gibi özel karakterler içermeli.");
Console.WriteLine("Şifre en az 1 büyük harf içermeli.");
Console.Write("Şifreyi girin: ");
string sifre = Console.ReadLine();

if (sifre.Length >= 8 &&
    Regex.IsMatch(sifre, @"[A-Z]") &&
    Regex.IsMatch(sifre, @"[@#$%]"))
{
    Console.WriteLine("Şifre güçlü.");
}
else
{
    Console.WriteLine("Şifre zayıf.");
}


