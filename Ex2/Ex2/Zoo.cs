using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Zoo
    {
        string address;
        string[] workers = new string[20];
        Animal[] animals = new Animal[20];
        int bank = 100000;
        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setWorkers(string [] workers)
        {
            this.workers = workers;
        }
        public void setAnimals(Animal[] animals)
        {
            this.animals = animals;
        }
        public void setBank(int bank)
        {
            this.bank = bank;
        }
        public string getAddress()
        {
            return address;
        }
        public string[] getWorkers()
        {
            return workers;
        }
        public Animal[] getAnimals()
        {
            return animals;
        }
        public int getBank()
        {
            return bank;
        }
        
        public Zoo(string address,string[] workers,Animal[] animals,int bank)
        {
            this.address = address;
            this.workers = workers;
            this.animals = animals;
            this.bank = bank;
        }

        public Zoo()
        {
            this.address = "PArdesya";
            this.workers = new string[20] ;
            this.animals =  new Animal[20] ;
            this.bank = 20000;
        }

        public bool containAnimal(string aniName)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (aniName == animals[i].getName())
                    return true;
                
            }
            return false;
        }

        public bool addAnimal()
        {
            Console.WriteLine("Enter an animal:");
            int i = 0;
            while (animals[i] != null && i<animals.Length)
             {
                i++;
            }

            if (i >= animals.Length)
            {
                Console.WriteLine("The zoo is full!!");
                return false;
             }   
            animals[i] = new Animal(Console.ReadLine(), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            return true;
        }

        public bool removeAnimal(string aniName)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].getName() == aniName)
                {
                    animals[i] = null;
                    Console.WriteLine("found");
                    return true;
                }
            }
            Console.WriteLine("Not found");
            return false;
            
        }


    }

}
