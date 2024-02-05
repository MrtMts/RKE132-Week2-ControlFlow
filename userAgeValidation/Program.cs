// See https://aka.ms/new-console-template for more information
// rakendus palub kasutajal sisestada oma vanus
// kui kasutaja vanus on väiksem, kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagaram"
//muul juhul
//kuvatakse konsoolis "Welcome to Instagaram"

Console.WriteLine("Enter your age:"  );

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean true/false

bool isAgeNumber = Int32.TryParse( userAge, out userAgeNum );

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if( isAgeNumber )
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagaram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagaram!");
    }
}
else
{
    Console.WriteLine("Could not read your age!");
}


//int userAge = Int32.Parse(Console.ReadLine()); // "13" - string 13 - heap 

//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome to Instagaram!");
//}
//else //(userAge < 13)
//{
//    Console.WriteLine("You are too young to use Instagaram!");
//}