// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1
// String aboutme declared
String aboutme = "My name is Shawon Roberts and I plan on learing C# in this class.";

//Output to the screen
Console.WriteLine(aboutme);

// 2
int multiply(int a, int b)
{ return a * b; }

int product = multiply(1, 2);

// 3

for(int i = 0; i < product; i++)
{
    String x ="This loop has run " + i + " number of times";
    Console.WriteLine(x);
}

// 4 

String[] firstNameBestFriend = { "Sally", "Moe", "Billy Bob" };

foreach  (String name in firstNameBestFriend)
{
    Console.WriteLine(name + " ");
}
