using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Animal
    {
        string name;
        int weight;
        bool isPredator;
        int cage;

       public void setName(string name)
        {
            this.name = name;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public void setIsPredator(bool isPredator)
        {
            this.isPredator=isPredator;
        }
        public void setCage(int cage)
        {
            this.cage = cage;
        }

        public string getName()
        {
            return this.name;
        }
        public int getWeight()
        {
            return weight;
        }

        public bool getIsPredator()
        {
            return isPredator;
        }
        public int getCage()
        {
            return cage;
        }

        public Animal(string name,int weight,bool isPredator,int cage)
        {
            this.name = name;
            this.weight = weight;
            this.isPredator = isPredator;
            this.cage = cage;

        }
        public Animal():this("lebron",105,true,6){}

        public int compareMaxWeight(Animal ani)
        {
            if (this.weight == ani.weight)
            {
                return 0;
            }
            else
            {
                if (this.weight > ani.weight)
                    return 1;
                else
                    return -1;
                }

            }
        public void show()
        {
            Console.WriteLine("name: " + name + " " + " weight: " + weight + " " + "isPredator? " + isPredator + " " + "cage: " + cage);

        }

        public string ifSafe(Animal ani)
        {
            if (this.isPredator == ani.isPredator)
                return "safe";
            return "unsafe";
        }

        public bool compareName(Animal ani)
        {
            if (this.name == ani.name)
                return true;
            return false;

        }
    }           
}    

