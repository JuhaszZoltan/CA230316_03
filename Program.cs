Console.Write("írd be a neved: ");

string? nev = Console.ReadLine();

Koszonj(nev);

Console.Write("x értéke: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("y értéke: ");
int y = int.Parse(Console.ReadLine()!);

double d = 11;
double r = 2;

int osszeg = Osszeadas(x, y);
Console.WriteLine($"{x} + {y} = {osszeg}");

Console.WriteLine("itt a vége!");

//-----------------------

int Osszeadas(int a, int b)
{
    return a + b;
}
void Koszonj(string nev)
{
    Console.WriteLine($"Szia {nev}!");
    Console.WriteLine("milyen szép neved van!");
}