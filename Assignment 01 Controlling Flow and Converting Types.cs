//Controlling Flow and Converting Types 

/*
Test your Knowledge

1.What happens when you divide an int variable by 0? 
It will throw a DivideByZeroException. 

2.What happens when you divide a double variable by 0? 
It will result in infinity. 

3.What happens when you overflow an int variable, that is, set it to a value beyond its range? 
It will become a negative value. 

4.What is the difference between x = y++; and x = ++y;? 
If y=1: for x=y++: y=2,X=1; for x = ++y: y=2, x=2.

5.What is the difference between break, continue, and return when used inside a loop statement? 
Break is used to exit from a loop or a switch-case. 
Continue is used to move the control to the next iteration of the loop. 
Return is used to return a value from a function.

6.What are the three parts of a for statement and which of them are required? 
Initialize, test, and update.

7.What is the difference between the = and == operators? 
= is used for assigning the value to a variable.
== is used for comparing two values. It returns 1 if both the values are equal otherwise returns 0.

8.Does the following statement compile? for ( ; true; ) ; 
Yes, it will result in an infinite loop. 

9.What does the underscore _ represent in a switch expression? 
The underscore character replaces the default keyword to signify that it should match anything if reached.

10.What interface must an object implement to be enumerated over by using the foreach statement?
The IEnumerable interface.

*/



Console.WriteLine("Controlling Flow and Converting Types");
Console.WriteLine("");
Console.WriteLine("Practice loops and operators");
Console.WriteLine("");
Console.WriteLine("Question 1");
Console.WriteLine("");
Console.WriteLine("FizzBuzz");

for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Console.Write("fizzbuzz; ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("fizz; ");
    }
    else if (i % 5 == 0)
    {
        Console.Write("buzz; ");
    }
    else
    {
        Console.Write(i + "; ");
    }

}

Console.WriteLine("");
Console.WriteLine("");




/*Code Execution:

When I execute the following code, it enters an infinite loop. Because i is a byte type, so it's maximum value is 127, it will never break the loop. 

I can add an additional integer to count the loop: 

int max = 500;
int j = 0;
for (byte i= 0; i < max; i++)
{
    Console.WriteLine(i);
    j++;
    if (j >= 500)
    {
        Console.WriteLine("Error: Data Overflow");
        break;
    }
 }

*/





Console.WriteLine("Question 2: Print-a-Pyramid");

Console.WriteLine("");

for (int i = 1; i <= 9; i += 2)
{
    int K = (9 - i) / 2;
    if (K == 0)
    {
        Console.WriteLine("*********");
    }
    else
    {
        string A = "";
        string B = "";
        for (int j = 1; j <= K; j++)
        {
            A += " ";
        }

        for (int l = 1; l <= i; l++)
        {
            B += "*";
        }
        Console.WriteLine(A + B + A);
    }
}

Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Question 3: Guess Random Number");
int correctNumber = new Random().Next(3) + 1;

Console.Write("Input your guess: ");
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber < 1)
{
    Console.WriteLine("Wrong: Less than 1");
}
else if (guessedNumber > 3)
{
    Console.WriteLine("Wrong: Larger than 3");
}
else
{
    if (guessedNumber > correctNumber)
    {
        Console.WriteLine("Guessed too High: Correct is " + correctNumber);
    }
    else if (guessedNumber < correctNumber)
    {
        Console.WriteLine("Guessed too Low: Correct is " + correctNumber);
    }
    else
    {
        Console.WriteLine("Correct!");
    }
}

Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Question 4: Calculate Birthday");

Console.Write("Input Birthday: ");
DateTime Birthday = Convert.ToDateTime(Console.ReadLine());


DateTime NowTime = DateTime.Now;

//DateTime NowTime = Convert.ToDateTime(DateTime.Now.ToShortDateString);

TimeSpan dayCount = NowTime.Subtract(Birthday);

string DayCount = dayCount.Days.ToString();

int day = Convert.ToInt32(DayCount);

Console.WriteLine("This Person is {0} Days old", DayCount);

int daysToNextAnniversary = 10000 - (day % 10000);

DateTime NextAn = NowTime.AddDays(daysToNextAnniversary);

String Anniversary = NextAn.ToShortDateString();

Console.WriteLine("Next Anniversary is " + Anniversary);

Console.WriteLine("");
Console.WriteLine("");



Console.WriteLine("Question 5: Greetings");

Console.WriteLine("");

string hour = DateTime.Now.ToString("HH");

int Hour = Convert.ToInt32(hour);

if (Hour >= 5 && Hour < 12)
{
    Console.WriteLine("Good Morning");
}

if (Hour >= 12 && Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}

if (Hour >= 17 && Hour < 20)
{
    Console.WriteLine("Good Evening");
}

if (Hour >= 20 || Hour < 5)
{
    Console.WriteLine("Good Night");
}


Console.WriteLine("");
Console.WriteLine("");



Console.WriteLine("Question 6: Count to 24");

Console.WriteLine("");

for (int i = 1; i <= 4; i++)
{
    string A = "";
    for (int j = 0; j <= 24; j += i)
    {
        if (j == 24)
        {
            A = A + j;
        }
        else
        {
            A = A + j + ",";
        }

    }
    Console.WriteLine(A);
}



Console.WriteLine("");