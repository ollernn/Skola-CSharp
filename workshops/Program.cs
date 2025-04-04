/* 1.
Console.WriteLine("Ange pris exklusive moms:");
string input  = Console.ReadLine();
int inputInt = int.Parse(input);
double Moms = inputInt * 1.25;
Console.WriteLine(Moms);
*/

/* 2.
Console.WriteLine("Ange pris inklusive moms:");
    string input  = Console.ReadLine();
    int inputInt = int.Parse(input);
Double noMoms = inputInt * 0.8;
Console.WriteLine(noMoms);
*/

/* 3.
const decimal Moms = 0.25m;

Console.WriteLine("Ange pris exklusive moms:");
decimal input = decimal.Parse(Console.ReadLine());

decimal MomsTot = input * Moms;
decimal totpris = MomsTot + input;

Console.WriteLine(totpris);
*/

/* 4.
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

/* 5.
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

/* 6.
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


/* 7.
Console.WriteLine("Skriv en mening: ");
string mening = Console.ReadLine();
Console.WriteLine("Välj en bokstav att räkna förekomsten av: ");
string bokstav = Console.ReadLine();

char sökBokstav = bokstav[0];
int antal = 0;

foreach (char tecken in mening)
{
    if (tecken == sökBokstav)
    { 
        antal++; 
    }
}

Console.WriteLine($"{sökBokstav} förekommer {antal} gånger");
*/

/* 8.
Console.WriteLine("Skriv en mening: ");
string mening = Console.ReadLine().ToLower();
int antalA = 0;
int antalE = 0;
int antalI = 0;
int antalO = 0;
int antalU = 0;
int antalY = 0;

foreach (char tecken in mening)
{
    switch (tecken)
    {
        case 'a':
            antalA++;
            break;
        case 'e':
            antalE++;
            break;
        case 'i':
            antalI++;
            break;
        case 'o':
            antalO++;
            break;
        case 'u':
            antalU++;
            break;
        case 'y':
            antalY++;
            break;
    }
}

Console.WriteLine($"I Strängen finns:");
Console.WriteLine($"a:{antalA}");
Console.WriteLine($"e:{antalE}");
Console.WriteLine($"i:{antalI}");
Console.WriteLine($"o:{antalO}");
Console.WriteLine($"u:{antalU}");
Console.WriteLine($"y:{antalY}");
*/

/* 9
Console.WriteLine("Skriv ett tal:");
int tal = int.Parse(Console.ReadLine());

bool prim = true;

if (tal <= 1) 
{
    prim = false; 
}

else
{
    for (int i = 2; i <= Math.Sqrt(tal); i++)
    {
        if (tal % i == 0)
        {
            prim = false;
            break;
        }
    }
}

if (prim)
{
    Console.WriteLine($"{tal} är ett primtal");
}
else
{
    Console.WriteLine($"{tal} är inte ett primtal");
}
*/

/* 10.
Console.WriteLine("Hur många tal vill du mata in (Max 30)?");
int antal = int.Parse(Console.ReadLine());

if ( antal > 30 || antal < 0)
{
    Console.WriteLine("Du måste skriva ett tal mellan 1 och 30");
    return;
}

int[] tal = new int[antal];

for (int i = 0; i < tal.Length; i++)
{
    Console.WriteLine($"Tal {i + 1}: ");
    tal[i] = int.Parse(Console.ReadLine());
}

int summa = 0;
int min = tal[0];
int max = tal[0];

for (int i = 0; i < antal; i++)
{
    summa += tal[i];

    if (tal[i] < min)
        min = tal[i];

    if (tal[i] > max)   
        max = tal[i];
}

double medel = (double)summa / antal;

Console.WriteLine($"\nSumma: {summa}");
Console.WriteLine($"\nMedelvärde: {medel}");
Console.WriteLine($"\nMinsta värde: {min}");
Console.WriteLine($"\nStörsta värde: {max}");
*/

/* 11.
Console.WriteLine("Hur många studenter ska betyget matas in för?");
int antalStudenter = int.Parse(Console.ReadLine()); 

int[] betyg = new int[antalStudenter];

for (int i = 0; i < antalStudenter; i++)
{
    Console.WriteLine($"Ange betyget för student {i + 1}:");
    betyg[i] = int.Parse(Console.ReadLine());   
}

int summa = 0;
for (int i = 0;i < antalStudenter; i++)
{
    summa += betyg[i];
}

double medel = (double)summa / antalStudenter;

Console.WriteLine($"Det genomsnittliga betyget för gruppen är: {medel}:");
*/

/* 12.
Console.WriteLine("Ange en sträng:");
string input  = Console.ReadLine();

Console.WriteLine($"Antal tecken i strängen: {RäknaTecken(input)}");
Console.WriteLine($"Strämngen i versaler: {TillVersaler(input)}");
Console.WriteLine($"Strängen i gemener: {TillGemener(input)}");

if (palindrom(input))
{
    Console.WriteLine("Strängen är en palindrom");
}
else
{
    Console.WriteLine("Strängen är inte en palindrom");
}

static int RäknaTecken(string input)
{
    return input.Length;
}

static string TillVersaler(string input)
{
    return input.ToUpper();

}

static string TillGemener(string input)
{
    return input.ToLower();

}

static bool palindrom (string input)
{
    string små = input.ToLower();
    char[] tecken = små.ToCharArray();
    Array.Reverse(tecken);
    string baklänges = new string(tecken);

    return små == baklänges;
}
*/