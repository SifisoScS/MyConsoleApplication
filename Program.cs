// See https://aka.ms/new-console-template for more information
using System.Text;

// Building this C# Console Application Step-by-Step:

// 1. Open a terminal or command prompt.

// 2. Create a new Console App project using the following commands:
// dotnet new console -n MyConsoleApplication -o "<YourDesiredDirectory>"

// 3. Change into the project directory:
// cd "<YourDesiredDirectory>"

// 4. Open the project in Visual Studio or your preferred code editor.

// 5. Write or paste the provided C# code into the 'Program.cs' file.

// 6. Save the changes.

// 7. In the terminal, run the project using the command:
// dotnet run

// 8. Observe the output in the console.

// Feel free to experiment, modify, and learn from the code below. Happy coding!

// ------------------------------------------------------------------------//

// Creating and printing a string variable:
// 'string' is a data type in C# for representing text or character sequences.
// 'aFriend' is the name of the variable storing the string value "Simangaliso".
string aFriend = "Simangaliso";
// Console.WriteLine is a method for displaying text in the console.
// It's used here to print the value stored in the 'aFriend' variable.
Console.WriteLine(aFriend);

// Reassigning the value of aFriend and printing:
// The value of 'aFriend' is changed to "Simangaliso" again, and it's printed.
aFriend = "Simangaliso";
Console.WriteLine(aFriend); // As mentioned in the above comments

// Creating two string variables and using string interpolation:
// 'firstFriend' and 'secondFriend' are two string variables with specific names.
Console.WriteLine("Hello " + aFriend);

// Creating a string variable 'firstFriend' and assigning it the value "Dumisani"
string firstFriend = "Dumisani";
// Creating another string variable 'secondFriend' and assigning it the value "Thebe"
string secondFriend = "Thebe";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Printing the length of the first and second friend's names:
// 'Length' is a property of the string class that returns the number of characters in the string.
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
// Printing a message using string interpolation
// The values of 'firstFriend' and 'secondFriend' are inserted into the string.
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// Using an example string for demonstrating character indexing:
// Creating a string variable 'myName' and assigning it the value "Sifiso Cyprian Shezi"
var myName = "Sifiso Cyprian Shezi";

// Accessing the first letter of the string using character indexing
var firstLetterOfMyName = myName[0];
// Accessing the second letter of the string using character indexing
var secondLetterOfMyName = myName[1];
// Accessing the eigth letter of the string using character indexing
var eigthLetterOfMyName = myName[7];

// Printing the first, second, and eighth letters of myName:
// Using an example string for demonstrating character indexing
// 'myName' is a string variable representing a full name.
/* 'firstLetterOfMyName', 'secondLetterOfMyName', and 'eighthLetterOfMyName' 
are variables storing specific letters from 'myName'. */
Console.WriteLine("The first letter of my name is: " + firstLetterOfMyName);

Console.WriteLine("The second letter of my name is: " + secondLetterOfMyName);

Console.WriteLine("The eighth letter in my name is: " + eigthLetterOfMyName);

string hello = "Hello";
string world = "SDET";
string result = string.Concat(hello, ", ", world, "!");
Console.WriteLine(result);

string firstName = "Sifiso";
string lastName = "Shezi";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);  // Output: "Sifiso Shezi"

string userName = "Sifiso";
string dateString = DateTime.Today.ToShortDateString();
string message = $"Hello {userName}. Today is {dateString}.";
Console.WriteLine(message);

StringBuilder sb = new StringBuilder();
sb.Append("I");
sb.Append(" ");
sb.Append("am");
sb.Append("!");
string finalMessage = sb.ToString();

Console.WriteLine(finalMessage);
