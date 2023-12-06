using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class Garage
    {
        const int MAX_CARS = 10;
        public enum Status { empty, waiting, done};

        Car[] cars = new Car[MAX_CARS];
        Status[] status = new Status[MAX_CARS];
        int inGarage;

        public Garage()
        {
            this.cars = new Car[MAX_CARS];
            this.status = new Status[MAX_CARS];
            //for (int i = 0; i < MAX_CARS; i++)
            //{
            //    status[i] = Status.empty;
            //}
            this.inGarage = 0;
        }
        public Car[] CARS
        {
            get => cars;
            set => cars = value;
        }
        public Status[] STATUS
        {
            get => status;
            set => status = value;
        }
        public int INGARAGE
        {
            get => inGarage;
            set => inGarage = value;
        }

        public bool addCar(Car car)
        {
            if (inGarage>=MAX_CARS)
            {
                Console.WriteLine("The garage is full");
                return false;
            }
            cars[inGarage] = car;
            status[inGarage] = Status.waiting;
            Console.WriteLine("Car added Successfully");
            inGarage++;
            return true;
        }
        public bool inProcess(int license)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].LICENSE == license && status[i] == Status.waiting)
                {
                    status[i] = Status.done;
                    return true;
                }   
            }
            return false;
        }

        public void printAll()
        {

            foreach (var item in cars)
            {
                if (item != null) item.toString();
            }
        }

        public bool remove(int license, string id)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                {
                    if (cars[i].LICENSE == license && cars[i].OWNER.ID == id && status[i]==Status.done)
                    {
                        cars[i] = null;
                        for (int j = i; j < cars.Length-1; j++)
                        {
                            cars[j] = cars[j + 1];
                        }
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
