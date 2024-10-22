using System;
using System.Collections.Generic;
using E41Owusu;

class Program
{
    static void Main(string[] args)
    {
        // instantiate an object of the Employee class
        Employee employee = new Employee();
        LinkedList<int> a = new LinkedList<int>();


        Console.Write("Enter firstname: ");
        employee.setFirstName(Console.ReadLine());

        Console.Write("Enter lastname: ");
        employee.setLastName(Console.ReadLine());

        Console.Write("Enter salary: ");
        employee.setSalary(double.Parse(Console.ReadLine()));

        // Loop to continue displaying options
        bool continueProgram = true;

        while (continueProgram)
        {
            // Display the menu options
            DisplayMenu();

            // Read user input
            Console.Write("\nEnter action: ");
            string input = Console.ReadLine();

            // Validate and convert input to an integer
            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Name: " + employee.getFirstName() + " " + employee.getLastName());
                        Console.WriteLine("Current Salary is " + employee.getSalary());
                        Console.WriteLine("Annual Salary is " + employee.getAnnualSalary());
                        break;
                    case 2:
                        Console.Write("Enter increase in percent(%): ");
                        employee.setPercentage(double.Parse(Console.ReadLine()));
                        Console.WriteLine("New salary is " + employee.getNewPercentageIncrease());
                        break;
                    case 3:
                        // Enter details for a new employee
                        Console.WriteLine("\nEntering new employee information...");
                        employee = new Employee();  // Reinitialize the Employee object
                        Console.Write("Enter first name: ");
                        employee.setFirstName(Console.ReadLine());

                        Console.Write("Enter last name: ");
                        employee.setLastName(Console.ReadLine());

                        Console.Write("Enter salary: ");
                        employee.setSalary(double.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        continueProgram = false; 
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to display the menu options
    static void DisplayMenu()
    {
        Console.WriteLine("\n[1] Display Annual Salary");
        Console.WriteLine("[2] Raise Salary");
        Console.WriteLine("[3] Enter Another Employee");
        Console.WriteLine("[4] Exit");
    }

}
