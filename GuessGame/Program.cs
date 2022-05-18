bool isCorrectNumber = false;
Random random = new Random();
int randomNumber = random.Next(10, 101);
Console.WriteLine("please enter a number between 10-100");

while (!isCorrectNumber)
{
    int guess = Convert.ToInt32(Console.ReadLine());

        if (guess == randomNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("you win :) ");
            Console.ResetColor();
            isCorrectNumber = true;
        }else if (guess < randomNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("say higher number ");
            Console.ResetColor();
        }
        else if (guess > randomNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("say lower number ");
            Console.ResetColor();
        }
        else if (Math.Abs(randomNumber - guess) < 10 && randomNumber != guess)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("to close");
            Console.ResetColor();
        }
}

Console.ReadKey();
