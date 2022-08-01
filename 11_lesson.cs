using System;
using System.Runtime.Intrinsics.Arm;
using Internal;

int secret_num = 66;
int guess;
int guessCount = 0;
int guessLimit = 3;
bool win = false;

do
{
    Console.Write("enter a #");
    guess = Convert.ToInt32(Console.ReadLine());
    guessCount++;

    if (guess > secret_num)
    {
        Console.Write("smaller");
    }
    else if (guess < secret_num)
    {
        Console.Write("bigger");
    }
    else
    {
        Console.Write("won");
        win = true;
    }
}
while (guess != secret_num && guessCount < guessLimit);

if (!win)
{
    Console.Write("lost");
}