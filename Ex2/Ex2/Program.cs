using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lebron = new Animal();
            Animal kobe = new Animal("kobe",95,true,8);
            Zoo ramtGan = new Zoo();
            lebron.show();
            ramtGan.addAnimal();
            foreach(var item in ramtGan.getAnimals())
            {
                Console.WriteLine(item.getName());
            }
            
           

        }
    }
}
    //    {
    //        Zoo ourZoo = new Zoo();
    //        int option = 7;
    //        int price = 0;
    //        Animal animal1, animal2;
    //        while (option != 6)
    //        {
    //            Console.WriteLine("Enter an option: \n (1) Buy animal \n (2) Sell animal \n (3) is safe \n (4) max weight \n (5) print all animals \n (6) Exit");
    //            option = int.Parse(Console.ReadLine());
    //            switch (option)
    //            {
    //                case 1:
    //                    Console.WriteLine("Enter the price");
    //                    price = int.Parse(Console.ReadLine());
    //                    if (!ourZoo.BuyAnimal(inputAnimalDetails(), price))
    //                        Console.WriteLine("Can not be added to the zoo");
    //                    break;
    //                case 2:
    //                    Console.WriteLine("Enter the price");
    //                    price = int.Parse(Console.ReadLine());
    //                    Console.WriteLine("Enter animal name");
    //                    string name = Console.ReadLine();
    //                    ourZoo.SellAnimal(name, price);
    //                    break;
    //                case 3:
    //                    animal1 = inputAnimalDetails();
    //                    animal2 = inputAnimalDetails();
    //                    if (animal1.isSafe(animal2))
    //                        Console.WriteLine("Safe");
    //                    else
    //                        Console.WriteLine("Not Safe");
    //                    break;
    //                case 4:
    //                    animal1 = inputAnimalDetails();
    //                    animal2 = inputAnimalDetails();
    //                    int ans = animal1.CompareMaxWeight(animal2);
    //                    if (ans == 0)
    //                        Console.WriteLine("Equal");
    //                    else if (ans == 1)
    //                        Console.WriteLine(animal1.Name);
    //                    else
    //                        Console.WriteLine(animal2.Name);
    //                    break;
    //                case 5:
    //                    ourZoo.printAll();
    //                    break;
    //                case 6:
    //                    Console.WriteLine("GoodBye");
    //                    break;
    //                default:
    //                    Console.WriteLine("Enter number between 1-6");
    //                    break;
    //            }
    //        }
    //    }

        //    static Animal inputAnimalDetails()
        //    {
        //        Console.WriteLine("Enter animal name");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("Enter animal max weight");
        //        int maxWeight = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter cage num");
        //        int cage = int.Parse(Console.ReadLine());
        //        Console.WriteLine("is Predator? enter  0- for No, 1-for yes");
        //        int isPredator = int.Parse(Console.ReadLine());
        //        if (isPredator == 1)
        //            return (new Animal(name, maxWeight, true, cage));
        //        else
        //            return (new Animal(name, maxWeight, false, cage));
        //    }
        //}
        //}
   
