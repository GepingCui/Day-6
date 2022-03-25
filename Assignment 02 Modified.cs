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

Console.WriteLine("Original Array: ");
Console.WriteLine("");

foreach (var item in Array1)
{
    Console.Write(item + " ");
}

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("New Array: ");

Console.WriteLine("");

foreach (var item in Array2)
{
    Console.Write(item + " ");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");



//Console.WriteLine("2.Manage a list of elements");
//Console.WriteLine("");

//List<string> list = new List<string>();

//for (; ; )
//{
//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//    string X = Console.ReadLine();
//    if (X == "--")
//    {
//        list.Clear();
//        Console.WriteLine("List is Cleared");
//        Console.WriteLine("");
//    }
//    else if (X[0] == '+')
//    {
//        string x = X.Substring(2);
//        list.Add(x);
//        Console.WriteLine("Added; Display the List:");
//        foreach (var item in list)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine("");
//        Console.WriteLine("");
//    }
//    else if (X[0] == '-')
//    {
//        string x = X.Substring(2);
//        if (list.Contains(x) == true)
//        {
//            list.Remove(x);
//            Console.WriteLine("Substracted; Display the List:");
//        }
//        else
//        {
//            Console.WriteLine("Can't Find it! Display the List:");
//        }
//        foreach (var item in list)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine("");
//        Console.WriteLine("");
//    }

//    else
//    {
//        Console.Write("Invalid Input");
//        Console.WriteLine("");
//    }
//}




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


int Number1 = 18;
int Number2 = 96;

int[] X1 = FindPrimesInRange(Number1, Number2);

Console.WriteLine("Prime numbers between {0} and {1} are: ",Number1,Number2);
Console.WriteLine("");

foreach (var item in X1)
{
    Console.Write(item + " ");
}
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("");





Console.WriteLine("4. Rotate");
Console.WriteLine("");

static int[] Rotate(int[] Arr, int R)
{
    int[] Arr1 = new int[Arr.Length];
    for (int i = 0; i < Arr.Length; i++)
    {
        int IndexValue = (i + R) % Arr.Length;
        Arr1[IndexValue] = Arr[i];
    }
    return Arr1;
}

static void SumRotate(int[] Arr, int R)
{
    int[] Arr1 = new int[Arr.Length];
    for (int i = 1; i <= R; i++)
    {
        int[] Arr2 = Rotate(Arr, i);

        Console.Write("Rotate Array: ");
        foreach (var item in Arr2)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");

        for (int j = 0; j < Arr.Length; j++)
        {
            Arr1[j] += Arr2[j];
        }

    }
    Console.Write("Sum Array: ");
    foreach (var item in Arr1)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("");
}

int[] ArrayTest1 = { 1, 2, 3, 4, 5 };

Console.Write("Origin Array: ");

foreach (var item in ArrayTest1)
        {
    Console.Write(item + " ");
}
Console.WriteLine("");
Console.WriteLine("");



SumRotate(ArrayTest1, 7);


Console.WriteLine("");
Console.WriteLine("");



Console.WriteLine("5. Longest sequence of equal elements");
Console.WriteLine("");

static void LongestSequence(int[] Arr)
{
    string Longest = Convert.ToString(Arr[0]);
    string temp = Convert.ToString(Arr[1]);

    Console.Write("Input: ");
    foreach (var item in Arr)
    {
        Console.Write(item + " ");
    }
    Console.Write("   ");


    if (Longest == temp)
    {
        temp += Longest;
    }

    for (int i = 2; i < Arr.Length; i++)
    {
        if (Arr[i] == Arr[i - 1])
        {
            temp = temp + Arr[i];
        }
        else
        {
            if (temp.Length > Longest.Length)
            {
                Longest = temp;
            }
            temp = Convert.ToString(Arr[i]);
        }
    }
    if (temp.Length > Longest.Length)
    {
        Longest = temp;
    }
    Console.Write("Output: ");
    Console.WriteLine(Longest);

    Console.WriteLine("");
    Console.WriteLine("");

}

int[] Arraytest1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int[] Arraytest2 = { 1, 1, 1, 2, 3, 1, 3, 3 };
int[] Array3 = { 4, 4, 4, 4 };
int[] Array4 = { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

LongestSequence(Arraytest1);

LongestSequence(Arraytest2);

LongestSequence(Array3);

LongestSequence(Array4);

Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("7. Most frequent number");
Console.WriteLine("");

static int FindMostFrequency(int[] Arr)
{
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();

    foreach (int item in Arr)
    {
        if (list1.IndexOf(item) == -1)
        {
            list1.Add(item);
            list2.Add(1);
        }
        else
        {
            list2[list1.IndexOf(item)] += 1;
        }
    }

    int INDEX = list2.IndexOf(list2.Max());

    return list1[INDEX];

}

int[] ARRAY1 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

Console.Write("Input: ");
foreach (var item in ARRAY1)
{
    Console.Write(item + " ");
}
Console.Write("   ");

Console.Write("Output: ");

Console.WriteLine(FindMostFrequency(ARRAY1));

int[] ARRAY2 = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };

Console.Write("Input: ");
foreach (var item in ARRAY2)
{
    Console.Write(item + " ");
}
Console.Write("   ");

Console.Write("Output: ");

Console.WriteLine(FindMostFrequency(ARRAY2));


Console.WriteLine("");
Console.WriteLine("");