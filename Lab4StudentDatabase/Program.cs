
string[] studentNames = new string[] { "Sasha", "Fiona", "Jordan", "Terry", "Monica" };
string[] studentHometowns = new string[] { "San Francsisco", "Detroit", "Tampa Bay", "Kansas City", "Chicago" };
string[] favoriteFoods = new string[] { "Pizza", "Chicken Alfredo", "Cheeseburger", "Ceaser Salad", "Ice Cream :)" };

bool goAgain = true;

do
{
    Console.WriteLine("Hello and welcome to Grand Circus' Student Database. To search for a student, please input their student ID number (#s 1-5): ");
    int userIndex = Convert.ToInt32(Console.ReadLine());

    while (userIndex <= 0 || userIndex > studentNames.Length)
    {
        Console.WriteLine($"We do not have any students with that ID number. Currently, our database does not exceed {studentNames.Length}.");
        Console.WriteLine();
        Console.WriteLine("Please input a different student ID number: ");
        userIndex = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine();
    Console.WriteLine($"Student ID #{userIndex}: {studentNames[userIndex - 1]}");

    Console.WriteLine();
    Console.WriteLine($"Please select which category of information you would like to access about {studentNames[userIndex - 1]}: Hometown or Favorite Food?");
    string userCategory = Console.ReadLine();

    while (userCategory.ToLower() != "hometown" && userCategory.ToLower() != "favorite food")
    {
        Console.WriteLine("Sorry, we do not host that student information.");
        Console.WriteLine();
        Console.WriteLine("Please select from a valid category: Hometown or Favorite Food");
        userCategory = Console.ReadLine();
    }

    if (userCategory.ToLower() == "hometown")
    {
        Console.WriteLine();
        Console.WriteLine($"{studentNames[userIndex - 1]}'s hometown is {studentHometowns[userIndex - 1]}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"{studentNames[userIndex - 1]}'s favorite food is {favoriteFoods[userIndex - 1]}.");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for accessing Grand Circus' Student Database today!");
    Console.WriteLine("Would you like to learn about a different student (y/n)?");
    string input = Console.ReadLine();
    goAgain = input.ToLower() == "y";

} while (goAgain);

Console.WriteLine();
Console.WriteLine("Have a great day!");