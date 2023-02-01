using System.Reflection.Metadata.Ecma335;

string[] studentNames = new string[5];
string[] favoriteFood = new string[studentNames.Length];
string[] homeTown = new string[studentNames.Length];

studentNames[0] = "Chase";
studentNames[1] = "Nik";
studentNames[2] = "Andrew";
studentNames[3] = "Steven";

favoriteFood[0] = "Pizza";
favoriteFood[1] = "Sesame Chicken";
favoriteFood[2] = "Ramen";
favoriteFood[3] = "Pho";

homeTown[0] = "Lake Orion";
homeTown[1] = "Grand Rapids";
homeTown[2] = "Royal Oak";
homeTown[3] = "Grand Rapids";

bool keepGoing =  false;    // loop for user input at the end

do
{                                       
    bool validNumber = false;   // loop to get valid number for initial array space

    while (validNumber == false)
    {
        Console.WriteLine("\nPlease enter a number between 1 & 4 to learn about a student\n");
        string student = Console.ReadLine();
        int studentNumber = int.Parse(student);
        int realNumber = studentNumber - 1; // subtracts 1 from the user input to get the accurate array space

        if (studentNumber >= 1 && studentNumber <= 4)
        {
            bool validAnswer = false;

            do
            {
                Console.WriteLine($"\nAwesome you've chosen {studentNames[realNumber]}! What would you like to find out? enter either \"Hometown\" or \"Favorite food\"\n");
                string userAnswer = Console.ReadLine();
                string userAnswerToLower = userAnswer.ToLower();
                if (userAnswerToLower == "hometown" || userAnswerToLower == "home" || userAnswerToLower == "town")
                {
                    Console.WriteLine($"\n{studentNames[realNumber]} is from {homeTown[realNumber]}\n");
                    validAnswer = true;
                }
                else if (userAnswerToLower == "favorite food" || userAnswerToLower == "favorite" || userAnswerToLower == "food")
                {
                    Console.WriteLine($"\n{studentNames[realNumber]}s favorite food is {favoriteFood[realNumber]}\n");
                    validAnswer = true;
                }
                else
                {
                    Console.WriteLine("Please enter \"Hometown\" or \"Favorite food\"\n");
                }



            } while (validAnswer == false);
            validNumber = true; 
        }
        else
        {
            Console.WriteLine("please enter a valid number between 1 & 4\n");
            validNumber = false;
        }
        
    }





    Console.WriteLine("Would you like to Learn about another student? Type Yes to continue or any other key to exit\n");
    string userInput = Console.ReadLine();
    string goAgain = userInput.ToLower();
    if (goAgain == "yes")
    {
        keepGoing = false;
    }
    else
    { 
        keepGoing = true;
    }




} while (keepGoing == false);

