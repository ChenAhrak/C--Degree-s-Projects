using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class Car
    {
        int license;
        string maker;
        int year;
        int engine;
        string model;
        Costumers owner;

        public Car(int license, string maker, int year, int engine, string model, Costumers owner)
        {
            this.license = license;
            this.maker = maker;
            this.year = year;
            this.engine = engine;
            this.model = model;
            this.owner = owner;
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
        public Costumers OWNER
        {
            get => owner;
            set => owner = value;
        }

        public string toString()
        {
            string o = owner.toString();
            return($"license: {license} \tmaker: {maker} \tyear: {year}\tengine: {engine}\tmodel: {model}\towner: {o}\t");
        }

    }
}
