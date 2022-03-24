//01 Introduction to C# and Data Types

/*Understanding Data Types

1.What type would you choose for the following “numbers”? 

A person’s telephone number:  String.
A person’s height:  Float.
A person’s age:  Integer. 
A person’s gender (Male, Female, Prefer Not To Answer):  String. 
A person’s salary:  Float.
A book’s ISBN:  String. 
A book’s price:  Float. 
A book’s shipping weight:  Float. 
A country’s population:  Integer, May need to use Long in the future. 
The number of stars in the universe:  Long. 
The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) :  Enum. 



2.What are the difference between value type and reference type variables? What is boxing and unboxing?

A variable of a value type contains an instance of the type, while a variable of a reference type contains a reference to an instance of the type.
Boxing is the process of converting a value type to the reference type. Unboxing converts reference type back into value type. 



3.What is meant by the terms managed resource and unmanaged resource in .NET

Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. 
Unmanaged resources are those that are not. 



4.Whats the purpose of Garbage Collector in .NET?

.NET's garbage collector manages the allocation and release of memory for the application. 


*/



Console.WriteLine("Practice number sizes and ranges");

Console.WriteLine("");

Console.WriteLine("Question 1");


Console.WriteLine("sbyte: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);

Console.WriteLine("byte: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(byte), byte.MinValue, byte.MaxValue);

Console.WriteLine("short: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(short), short.MinValue, short.MaxValue);

Console.WriteLine("ushort: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);

Console.WriteLine("int: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(int), int.MinValue, int.MaxValue);

Console.WriteLine("uint: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(uint), uint.MinValue, uint.MaxValue);

Console.WriteLine("long: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(long), long.MinValue, long.MaxValue);

Console.WriteLine("ulong: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);

Console.WriteLine("float: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(float), float.MinValue, float.MaxValue);

Console.WriteLine("double: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(double), double.MinValue, double.MaxValue);

Console.WriteLine("decimal: Number of Bytes: {0}, Minimum Value: {1}, Maximum Value: {2}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

Console.WriteLine("");

Console.WriteLine("Question 2:");

Console.Write("Input: ");
string input = Console.ReadLine();

long Input = Convert.ToInt64(input);

long Years = Input * 100;

var Days = Math.Floor(Input * 36524.2);

TimeSpan hours = TimeSpan.FromDays(Days);

var Hours = hours.TotalHours;

TimeSpan minutes = TimeSpan.FromHours(Hours);

var Minutes = minutes.TotalMinutes;

TimeSpan seconds = TimeSpan.FromMinutes(Minutes);

var Seconds = seconds.TotalSeconds;

string S = Convert.ToString(Seconds);

string Milli = S + "000";

string Micro = Milli + "000";

string Nano = Micro + "000";


Console.WriteLine("Output: " + Input + " centuries = " + Input * 100 + " years = " + Days + " days = " + Hours + " hours = " + Minutes + " minutes = " + Seconds + " seconds= " + Milli + " milliseconds = " + Micro + " microseconds = " + Nano + " nanoseconds");

Console.WriteLine("");

Console.WriteLine("");
