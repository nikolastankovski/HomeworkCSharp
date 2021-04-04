using System;
using CarExercise.Classes;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Driver driver1 = new Driver("Bob", 1);
                Driver driver2 = new Driver("Greg", 2);
                Driver driver3 = new Driver("Jill", 3);
                Driver driver4 = new Driver("Anne", 4);

                Car car1 = new Car("Hyandai", 200);
                Car car2 = new Car("Mazda", 210);
                Car car3 = new Car("Ferrari", 220);
                Car car4 = new Car("Porsche", 230);

                Driver[] drivers = { driver1, driver2, driver3, driver4 };
                Car[] cars = { car1, car2, car3, car4 };

                Driver[] selectedDrivers = ChooseDrivers(drivers);
                Car[] selectedCars = ChooseCars(cars, selectedDrivers);

                Car winner = Car.RaceCars(selectedCars);
                Console.WriteLine("");
                Console.WriteLine($"The winner is {winner.Driver.Name}, driving the {winner.Model}, top speed {winner.CalculateSpeed()}");
                Console.WriteLine("");

                Console.Write("Do you want to race again? (Y/N): ");
                string answer = Console.ReadLine();

                while (true)
                {
                    if (answer.ToLower() != "y" && answer.ToLower() != "n")
                    {
                        Console.WriteLine("Invalid answer! Try again!");
                        Console.Write("Do you want to race again? (Y/N): ");
                        answer = Console.ReadLine();
                        continue;
                    }
                    break;
                }
                if (answer.ToLower() == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        static Driver[] ChooseDrivers(Driver[] drivers)
        {
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Name: {drivers[i].Name}, Skill: {drivers[i].Skill}");
            }
            Console.WriteLine("");

            int numDriversSelected = 0;
            Driver[] selectedDrivers = new Driver[0];
            int driverNumber = 0;
            while (numDriversSelected < 2)
            {
                Console.Write($"Select {Ordinal(numDriversSelected + 1)} driver (write it's number): ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out int num);
                if (isOkNum && num > 0 && num <= drivers.Length)
                {
                    if (driverNumber != num)
                    {
                        Array.Resize(ref selectedDrivers, selectedDrivers.Length + 1);
                        driverNumber = num;
                        numDriversSelected++;
                        selectedDrivers[selectedDrivers.Length - 1] = drivers[num-1];
                    }
                    else
                    {
                        Console.WriteLine("You can't select the same driver!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid driver number.");
                }
            }
            return selectedDrivers;
        }

        static Car[] ChooseCars(Car[] cars, Driver[] drivers)
        {
            Console.WriteLine("");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Model: {cars[i].Model}, Speed: {cars[i].Speed}");
            }
            Console.WriteLine("");

            int numSelectedCars = 0;
            Car[] selectedCars = new Car[0];
            int carNumber = 0;
            while (numSelectedCars < 2)
            {
                Console.Write($"Select {Ordinal(numSelectedCars + 1)} car (write it's number): ");
                bool isOkCarNum = int.TryParse(Console.ReadLine(), out int num);
                if (isOkCarNum && num > 0 && num <= cars.Length)
                {
                    if (carNumber != num)
                    {
                        Array.Resize(ref selectedCars, selectedCars.Length + 1);
                        carNumber = num;
                        numSelectedCars++;
                        selectedCars[selectedCars.Length - 1] = cars[num - 1];
                    }
                    else
                    {
                        Console.WriteLine("You can't select the same car!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid car number.");
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Name: {drivers[i].Name}, Skill: {drivers[i].Skill}");
            }
            Console.WriteLine("");

            while (true)
            {
                Console.Write($"Select driver for {selectedCars[selectedCars.Length - 1].Model}: ");
                bool isOkDriverNum = int.TryParse(Console.ReadLine(), out int driverNum);
                if (isOkDriverNum && driverNum > 0 && driverNum <= drivers.Length)
                {
                    if (driverNum == 1)
                    {
                        selectedCars[selectedCars.Length - 1].Driver = drivers[driverNum - driverNum];
                        selectedCars[selectedCars.Length - 2].Driver = drivers[driverNum];
                        break;
                    }
                    else
                    {
                        selectedCars[selectedCars.Length - 1].Driver = drivers[driverNum - 1];
                        selectedCars[selectedCars.Length - 2].Driver = drivers[driverNum - driverNum];
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid driver number");
                }
            }

            return selectedCars;
        }

        static string Ordinal(int num)
        {
            
            int ones = num % 10;
            int tens = (num / 10 % 10);
            string suff = "";

            if (tens == 1) {
                    suff = "th";
            } else
            {
                switch (ones) {
                    case 1: 
                        suff = "st"; 
                        break;
                    case 2: 
                        suff = "nd"; 
                        break;
                    case 3: 
                        suff = "rd"; 
                        break;
                    default:
                        suff = "th";
                        break;
                }
            }
            return $"{num}{suff}";
        
        }
    }
}
