Console.WriteLine("Add meg a termék nevét:");
string termek = Console.ReadLine();
Console.WriteLine("Add meg a termék árát:");
int termekar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add meg a termék darabszámát:");
int termekdb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add meg a termék nevét:");
string termek2 = Console.ReadLine();
Console.WriteLine("Add meg a termék árát:");
int termekar2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add meg a termék darabszámát:");
int termekdb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A termékek nevei: {termek}, {termek2}");
Console.WriteLine($"összesen: {termekdb + termekdb2} darab");
int osszar = (termekar * termekdb) + (termekar2 * termekdb2);
int kedvezmeny = osszar / 10;
if (osszar > 10000)
{
    Console.WriteLine($"ár: {osszar - kedvezmeny} Ft kedvezménnyel");
}
else
{
    Console.WriteLine($"ár: {osszar} Ft kedvezménynélkül");
}
int kellék = 10000 - osszar;
if (osszar < 10000)
{
    Console.WriteLine($"Még {kellék} Ft kell a kedvezményhez");
}