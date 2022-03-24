//02  Arrays and Strings

/* Test your Knowledge
1.When to use String vs. StringBuilder in C# ?
If a string can change, then using a StringBuilder is the best option.
Otherwise, String is better. 

2.What is the base class for all arrays in C#?
Array class. 

3.How do you sort an array in C#?
Using Array. Sort method.

4.What property of an array object can be used to get the total number of elements in an array?
Length property.

5.Can you store multiple data types in System.Array?
No. 

6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
The CopyTo() method copies the elements into another existing array. 
The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
Both perform a shallow copy.

*/

Console.WriteLine("02 Arrays and Strings");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Practice Arrays");
Console.WriteLine("");

Console.WriteLine("1.Copying an Array");
Console.WriteLine("");

int[] Array1 = new int[10] { 1, 8, 3, 6, 9, 4, 7, 5, 2, 10 };

int[] Array2 = new int[Array1.Length];

for (int i = 0; i < Array1.Length; i++)
{
    Array2[i] = Array1[i];
}

foreach (var item in Array1)
{
    Console.Write(item + " ");
}

Console.WriteLine("");

foreach (var item in Array2)
{
    Console.Write(item + " ");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");



Console.WriteLine("2.Manage a list of elements");
Console.WriteLine("");

List<string> list = new List<string>();

for (; ; )
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string X = Console.ReadLine();
    if (X == "--")
    {
        list.Clear();
        Console.WriteLine("List is Cleared");
        Console.WriteLine("");
    }
    else if (X[0] == '+')
    {
        string x = X.Substring(2);
        list.Add(x);
        Console.WriteLine("Added; Display the List:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }
    else if (X[0] == '-')
    {
        string x = X.Substring(2);
        if (list.Contains(x) == true)
        {
            list.Remove(x);
            Console.WriteLine("Substracted; Display the List:");
        }
        else
        {
            Console.WriteLine("Can't Find it! Display the List:");
        }
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }

    else
    {
        Console.Write("Invalid Input");
        Console.WriteLine("");
    }
}




Console.WriteLine("3.Write a method");
Console.WriteLine("");

static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    for (int i = startNum; i <= endNum; i++)
    {
        int sum = 0;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                sum += 1;
            }
        }
        if (sum == 0)
        {
            primes.Add(i);
        }
    }
    return primes.ToArray();

}


int[] X1 = FindPrimesInRange(18, 96);

foreach (var item in X1)
{
    Console.Write(item + " ");
}
Console.WriteLine("");
Console.WriteLine("");