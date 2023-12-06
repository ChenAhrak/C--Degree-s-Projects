using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Car
    {
        int license;
        string maker;
        int year;
        int engine;
        string model;
        Customers own;

        public Car(int license, string maker, int year, int engine, string model, Customers own)
        {
            this.license = license;
            this.maker = maker;
            this.year = year;
            this.engine = engine;
            this.model = model;
            this.own = own;
        }

        public int LICENSE
        {
            get => license;
            set => license = value;
        }

        public string MAKER
        {
            get => maker;
            set => maker = value;
        }

        public int YEAR
        {
            get => year;
            set => year = value;
        }

        public int ENGINE
        {
            get => engine;
            set => engine = value;
        }

        public string MODEL
        {
            get => model;
            set => model = value;
        }

        public Customers OWN
        {
            get => own;
            set => own = value;
        }

        public void toString()
        {
            Console.WriteLine($"Licence: {license}\tMaker: {maker}\tYear: {year}\tEngine: {engine}\tModel: {model}");
            own.toString();
        }
    }
}
