Random random = new Random();
int randomNumber = random.Next(10, 100);
Console.WriteLine("Enter a number between 10 to 99");
var countGuess = 7;

for (int i = 0; i <= countGuess; i++)
{
    int randomnuber1 = int.Parse(Console.ReadLine());
    if (countGuess <= 7)
    {
      
        if (randomNumber == randomnuber1 && countGuess <= 7)
        {
            Console.WriteLine("congratulations you win :)");
            Console.ReadKey();
        }
        else if (randomNumber > randomnuber1)
        {
            Console.WriteLine("NOPE! Say it higher");
        }
        else if(randomNumber < randomnuber1)
        {
            Console.WriteLine("NOPE! Say it lower");
        }

        if (Math.Abs(randomNumber - randomnuber1) < 10 && randomNumber != randomnuber1)
        {
            Console.WriteLine("too close ");
        }
    }

    else  
    {
        Console.WriteLine("Sorry You Lose :/");
        Console.ReadKey();
        break;
    }
   
}


Console.ReadKey();