using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {

            int Student;

            //Console.WriteLine("Welcome to our C# class.");
            //string input = Console.ReadLine();

            //Console.WriteLine("Which student would you like to learn more about?");
            //int Student;

            List <string> Names = new List<string> {"Kim","Ray","Driscoll","Ronah","Ama","Caty","Katie","Babara","Oprah","Dan",
                "Cameroon","Kyle","Doreen","Stella","Dee","Shatty","Joan","Penny","Mike","Ian" };

            List <string> Hometown = new List<string>  {"Detroit","Chicago","Boston","Washington","Southfield","Taylor",
                "Brownstown","Newyork","Uganda","London","Newcastle","Birmingham","Turkey","Lagos","Nashville","Dallas","Kampala","Mbarara",
            "Abuja","Sunderland"};

            List <string> FavFoods = new List<string> {"Rice","Posho","Matooke","Cassave","Chilli soup","Pizza","Fufu",
                "Grilled Chicken Salaads","Burger","Chocalate","Wheat Bread","Fish","Chicken","Goat Meat",
            "Bean soup","Cookies","Donuts","Sweet Chilli","Mash mellows","Bisquits"};

            List<string> FavColor = new List<string> { "Pink","Purple","Blue","Green","Orange","Black",
                "White","Navy blue","Green","Chocolate","Light blue","Red","Grey","indigo","Margita","Light green","Violent","Yellow","Brown","Light brown"};
            
            Console.WriteLine("Welcome to our C# class.");


            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Which student would you like to learn more about.? Please enter a number from 1-{Names.Count} to know about a student or enter ({Names.Count + 1}) to create a new student");
                
                while (!int.TryParse(Console.ReadLine(), out Student) || Student < 1 || Student > Names.Count + 1)
                {
                    Console.WriteLine($"That student does not exist. Please Try again. Enter a number from 1-{Names.Count + 1}");

                }

                if (Student == Names.Count + 1)
                {
                    Console.WriteLine("You chose to add a new student. Please go ahead.");

                    Console.WriteLine($"Enter student name:");
                    string name = Console.ReadLine().ToLower();

                    Console.WriteLine($"Enter {name}'s home town:");
                    string hometown = Console.ReadLine().ToLower();

                    Console.WriteLine($"Enter {name}'s favourite food:");
                    string favouriteFood = Console.ReadLine().ToLower();

                    Console.WriteLine($"Enter {name}'s favourite color:");
                    string favouriteColor = Console.ReadLine().ToLower();

                    Names.Add(name);
                    Hometown.Add(hometown);
                    FavFoods.Add(favouriteFood);
                    FavColor.Add(favouriteColor);

                    Console.WriteLine($"Successfully added {name}'s details to the list.");

                    repeat = GetResponce("Would you like to do something else? (y) or (n)");

                }
                else
                {
                    Console.WriteLine($"What would you like to know more about {Names[Student - 1]}");
                    Console.WriteLine("Would you like to know the hometown (h) or the favorite food (f) or the favorite color (fc)");
                    string input = Console.ReadLine().ToLower();

                    if (input != "h" && input != "f" && input != "fc" && input != "n")
                    {
                        Console.WriteLine("Please enter (h) or (f) or (fc) or (n) to choose another student");
                        input = Console.ReadLine().ToLower();
                    }

                    if (input == "fc")
                    {
                        Console.WriteLine($"{Names[Student - 1]}'s favorite color is {FavColor[Student - 1]}");
                        Console.WriteLine($"Would you like to know {Names[Student - 1]}'s hometown (h) or favorite food (f) or (n)");
                        input = Console.ReadLine().ToLower();

                        while (input != "f" && input != "h" && input != "n")
                        {
                            Console.WriteLine("Please enter (f) or (h), or (n) to choose another student");
                            input = Console.ReadLine().ToLower();
                        }
                        if (input == "f")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s favorite food is {FavFoods[Student - 1]}");
                            repeat = GetResponce("Would you like to know about another student? (y) or (n)");
                        }
                        else if (input == "h")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s Hometown is {Hometown[Student - 1]}");
                            repeat = GetResponce("Would you like to know about another student? (y) or (n)");

                        }
                        else
                        {
                            repeat = GetResponce("Would you like to know another student? (y) or (n)");
                        }
                    }
                    else if (input == "h")
                    {

                        Console.WriteLine($"{Names[Student - 1]}'s Hometown is {Hometown[Student - 1]} ");
                        Console.WriteLine($"Would you like to know {Names[Student - 1]}'s favourite food (f) or favorite color (fc) or (n)");
                        input = Console.ReadLine().ToLower();
                        //Console.WriteLine($"{Names[Student - 1]}'s FavFoods is {FavFoods[Student - 1]}");


                        while (input != "f" && input != "fc" && input != "n")
                        {
                            Console.WriteLine("Please enter (f) or (fc), or (n) to choose another student");
                            input = Console.ReadLine().ToLower();
                        }
                        if (input == "f")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s favorite food is {FavFoods[Student - 1]}");
                            repeat = GetResponce("Would you like to know about another student? (y) or (n)");
                        }
                        else if (input == "fc")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s Favorite Color is {FavColor[Student - 1]}");
                            repeat = GetResponce("Would you like to know about another student? (y) or (n)");

                        }
                        else
                        {
                            repeat = GetResponce("Would you like to know another student? (y) or (n)");
                        }
                    }
                    else if (input == "f")
                    {
                        Console.WriteLine($"{Names[Student - 1]}'s favorite food is {FavFoods[Student - 1]}");
                        Console.WriteLine($"Would you like to know {Names[Student - 1]} hometown (h) or favorite color (fc)");
                        input = Console.ReadLine().ToLower();

                        while (input != "h" && input != "fc" && input != "n")
                        {
                            Console.WriteLine("Please enter (h) or (fc), or (n) to choose another student");
                            input = Console.ReadLine().ToLower();
                        }

                        if (input == "h")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s Hometown is {Hometown[Student - 1]}");
                            repeat = GetResponce("Would you like to know more about another student? (y) or (n)");
                        }
                        else if (input == "fc")
                        {
                            Console.WriteLine($"{Names[Student - 1]}'s Favorite Color is {FavColor[Student - 1]}");
                            repeat = GetResponce("Would you like to know more about another student? (y) or (n)");

                        }
                        else
                        {

                            repeat = GetResponce("Would you like to know more about another student? (y) or (n)");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thanks");
                        repeat = false;
                    }
                }
            }
        }

        private static int or(object n)
        {
            throw new NotImplementedException();
        }

        public static bool GetResponce(string prompt)
        {

            while (true)
            {

                Console.WriteLine(prompt);
                string input = Console.ReadLine().ToLower();//method
                if (input == "n")
                {

                    return false;
                }

                else if (input == "y")
                {

                    return true;
                }
                else

                {

                    Console.WriteLine("The data does not exist. Please try again later");
                }
            }
        }

    }
}




       
    

