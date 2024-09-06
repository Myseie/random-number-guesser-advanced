Console.WriteLine("Välj svårighetsgrad 1. Lätt");
Console.WriteLine("Välj svårighetsgrad 2. Medel");
Console.WriteLine("Välj svårighetsgrad 3. Svårt");

Console.Write("Ditt val (1-3) : ");

int maxNumber = 0;
int maxGuess = 0;

int choice  = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Du valde lätt");
        maxNumber = 10;
        maxGuess = 5;
        break;
    case 2:
        Console.WriteLine("Du valde medel");
        maxNumber = 50;
        maxGuess = 7;
        break;
    case 3:
        Console.WriteLine("Du valde svårt");
        maxNumber = 100;
        maxGuess = 10;
    break;
    default:
        Console.WriteLine("Ogiltligt val. programmet avslutas");
        return;

}
Random rnd  = new Random();
int randomNumber = rnd.Next(1, maxNumber + 1);

Console.WriteLine($"Jag har valt 1 tal mellan {maxNumber}. Du har {maxGuess} gissningar.");

for (int i = 0; i < maxGuess; i++)
{
    Console.WriteLine($"Gissningar {i +1} / {maxGuess}:");
    int playerGuess;

    while (!int.TryParse(Console.ReadLine(), out playerGuess) || playerGuess < 1 || playerGuess > maxNumber)
    {
        Console.WriteLine($"Ogiltligt gissning. Var snäll och gissa ett tal mellan 1 och {maxNumber}");

    }
    if (playerGuess == randomNumber)
    {
        Console.WriteLine("Grattis du gissa rätt!");
        return;
    }
    else if (playerGuess < randomNumber)
    {
        Console.WriteLine("För lågt! gissa igen!");
    }
    else
    {
        Console.WriteLine("För högt! Försök igen");
    }
    Console.WriteLine();
}
Console.WriteLine("Tack för att du spela!");
Console.WriteLine($"Tyvärr, du har inga fler gissningar kvar, det rätta talet var {randomNumber}");