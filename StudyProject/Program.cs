using System.ComponentModel;

namespace StudyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing out the menu 

            ShowMenu();
            //Letting user type in choice, and saving it as a string input

            try
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                // input.ToUpper(); The console wouldn't take a lowercase a b or c even when i used this one :c
                Console.WriteLine("------------------------------------");
                //If statements for if the user chooses a or b, calling out respective methods
                if (input == "A" || "a")
                {
                    Console.Write("Whats the celsius you want to convert? ");



                    double userInputA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("So you want to convert " + userInputA + " to Fahrenheit? Let me cook..");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("That would be " + ConvertToFahrenheit(userInputA) + "°F");

                }

                else if (input == "B" || "b")
                {
                    Console.Write("Whats the fahrenheit you want to convert? ");


                    double userInputB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("So you want me to convert " + userInputB + " to celcius? aight then..");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("That would be " + ConvertToCelcius(userInputB) + "°C");

                }

                // If the user types in c, the program closes with a goodbye text
                else if (input == "C" || "c")
                {
                    Console.WriteLine("Don't leave yet - there's a bug around that corner! Press any key to leave..");
                    ShowMenu();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input not in correct format.. Please type a number instead.");  
            }
        }


        //Method for Showmenu()
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome! You have the following options:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("A. Convert Celcius to Fahrenheit ");
            Console.WriteLine("B. Convert Fahrenheit to Celsius ");
            Console.WriteLine("C. exit ");
            Console.WriteLine("------------------------------------"); 
        }

        // Method for when the user chooses a (convert to fahrenheit from celcius)
        public static double ConvertToFahrenheit(double userChoiceCelsius)
        {
            return (userChoiceCelsius * 9 / 5) + 32;
        }

        //Method for when the user chooses b (convert to celcius from fahrenheit) 
        public static double ConvertToCelcius(double userChoiceFahrenheit) 
        {
            return (userChoiceFahrenheit - 32) * 5 / 9;
        }
    }
}