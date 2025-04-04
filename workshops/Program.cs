/*
Console.WriteLine("Ange pris exklusive moms:");
string input  = Console.ReadLine();
int inputInt = int.Parse(input);
double Moms = inputInt * 1.25;
Console.WriteLine(Moms);
*/

/*
Console.WriteLine("Ange pris inklusive moms:");
    string input  = Console.ReadLine();
    int inputInt = int.Parse(input);
Double noMoms = inputInt * 0.8;
Console.WriteLine(noMoms);
*/

/*
const decimal Moms = 0.25m;

Console.WriteLine("Ange pris exklusive moms:");
decimal input = decimal.Parse(Console.ReadLine());

decimal MomsTot = input * Moms;
decimal totpris = MomsTot + input;

Console.WriteLine(totpris);
*/

/*
int x, y;

x=4; y=2;
y=x++;
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
y=++x;
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
y*=x;
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
y+=(x+2);
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
y+=--x;
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
y+=x++;
Console.WriteLine($"y={y}    x={x}");

x=4; y=2;
x=-y;
Console.WriteLine($"y={y}    x={x}");
*/

/*
Console.WriteLine("Skriv ditt första tal:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt andra tal:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt tredje tal:");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt fjärde tal:");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt femte tal:");
int e = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt sjätte tal:");
int f = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ditt sjunde tal:");
int g = int.Parse(Console.ReadLine());

int[] tal = {a, b, c, d, e, f, g};
Array.Sort(tal);

int middle = tal[3];

Console.WriteLine($"Talet i mitten är {middle}");
*/

/*
 bool spelaIgen = true;

while (spelaIgen)
{
    Random slump = new Random();
    int tal = slump.Next(1, 101);
    int antalgissningar = 0;
    bool korrekt = false;

    Console.WriteLine("Välkommen till gissa-talet-spelet!");
    Console.WriteLine("Du ska gissa på ett tal mellan 1 och 100");


    while (!korrekt)
    {
        Console.Write("Gissa ett tal: ");
        int gissning = int.Parse(Console.ReadLine());

        antalgissningar++;

        if (gissning == tal)
        {
            Console.WriteLine($"Du gissade rätt! Du har gissat {antalgissningar} gånger");
            korrekt = true;
        }

        else if (gissning > tal)
        {
            Console.WriteLine("Du gissade för högt!");
        }

        else
        {
            Console.WriteLine("Du gissade för lågt!");
        }
    }
    Console.Write("Spela en gång till (y/n):");
    string svar = Console.ReadLine().ToLower();

    if (svar != "y")
    {
        spelaIgen = false;
        Console.WriteLine("Adjö");
    }

}
*/


