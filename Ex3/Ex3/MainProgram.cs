using System;

namespace Ex3
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            {
                int option = 6;
                Garage g1 = new Garage();
                Console.WriteLine("---------------------------------Welcome to KirilChen's garage----------------------------------------");
                while (option != 5)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("Add car:(1) \nFix the car(2)\nPrint cars(3)\nTake car(4)\nExit(5)\n" );
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            g1.addCar(inputCar());
                            break;
                        case 2:
                            Console.WriteLine("Enter your license for ");
                            int license = int.Parse(Console.ReadLine());
                            if(g1.inProcess(license))
                                Console.WriteLine("The process is done");
                            else
                                Console.WriteLine("No car waiting with this number");
                            break;
                        case 3:
                            Console.WriteLine("----------------------The cars in the garage-----------------------------");
                            g1.printAll();

                            break;
                        case 4:
                            Console.WriteLine("Enter license:");
                            license = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter id:");
                            string id = Console.ReadLine();
                            if(g1.remove(license,id))
                                Console.WriteLine("You took the car");
                            else
                                Console.WriteLine("The car is not ready / there is no match id to license");
                            break;
                        case 5:
                            Console.WriteLine("----------------------Goddbye-----------------------");
                            break;

                        default:
                            Console.WriteLine("Enter number between 1-5");
                            break;
                    }
                }
            }

            static Customers inputCustomers()
            {
                Console.WriteLine("Enter your id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your name:");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter your last name:");
                string lName = Console.ReadLine();
                Console.WriteLine("Enter your phone number:");
                string phone = Console.ReadLine();
                Console.WriteLine("Enter your address:");
                string address = Console.ReadLine();
                return new Customers(id, fName, lName, phone, address);

            }

            static Car inputCar()
            {
                Console.WriteLine("Enter license:");
                int license = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter maker:");
                string maker=Console.ReadLine();
                Console.WriteLine("Enter year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter engine's size:");
                int engine = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter model:");
                string model = Console.ReadLine();
                Customers owner = inputCustomers();
                return new Car(license, maker, year, engine, model, owner);
            }
        }
    }
}


    //Customers customer1 = new Customers("20938477", "kiril", "yermulin", "0546677324", "migadal");
    //Customers customer2 = new Customers("12345677","chen","ahrak","0502611022","pardesiiyaay");
    //customer1.toString();
    //Car car1 = new Car(12345566, "Toyota", 2016, 1700, "corola", customer1);
    //Car car2 = new Car(23434445, "Siat", 2017, 1400, "Ibiza", customer2);
    //car1.toString();
    //Garage garages = new Garage();
    //garages.addCar(car1);
    //garages.addCar(car2);

    //Console.WriteLine(garages.INGARAGE);
    //Console.WriteLine(garages.STATUS[1]);
    //Console.WriteLine(garages.inProcess(car1.LICENSE));
    //Console.WriteLine(garages.STATUS[0]);
    //Console.WriteLine(garages.inProcess(car2.LICENSE));
    //Console.WriteLine(garages.STATUS[1]);
    //Console.WriteLine("-------------Before change---------------");
    //garages.printAll();
    //garages.remove(12345566, "20938477");
    //Console.WriteLine( "-------------After change---------------");
    //garages.printAll();



        

