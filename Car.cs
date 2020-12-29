using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    partial class Car
    {
        public const string vehicle_type = "Car";
        public static string best_car;
        public static string worest_car;
        public string mark;

        private string model;
        private DateTime buildDate;
        private float length;
        private bool is_new;
        private int passangeer_places;
        private int maxSpeed;
        private int maxPower;
        

        public int tirazh { get; set; }

        

        public void Print()
        {
            Console.WriteLine($"\nvehicle_type: {vehicle_type}");
            Console.WriteLine($"best_car: {best_car}");
            Console.WriteLine($"worest_car: {worest_car}");
            Console.WriteLine($"mark: {mark}");
            Console.WriteLine($"model: {model}");
            Console.WriteLine($"buildDate: {buildDate.ToShortDateString()}");
            Console.WriteLine($"length: {length} (mm)");
            Console.WriteLine($"is_new: {is_new}");
            Console.WriteLine($"passangeer_places: {passangeer_places}");
            Console.WriteLine($"tirazh: {tirazh}");
            Console.WriteLine($"maxSpeed: {maxSpeed} (км/ч)");
            Console.WriteLine($"maxPower: {maxPower} (hp)");
        }

        public void Crash()
        {
            length -= 250;
            is_new = false;
            maxSpeed = 0;
            maxPower = 0;
        }

        public void Repair()
        {
            if (length <= 3250.15)
                length += 250;
            maxSpeed = 120;
            maxPower = 250;
        }

        public void Boost()
        {
            maxSpeed += 75;
            maxPower += 50;
        }

        //Метод в котором передаются аргументы по ссылке
        //"подвезти людей"
        public void Give_a_ride(ref int number_all_people, out int vipal_iz_avto)
        {
            number_all_people -= passangeer_places;
            Console.WriteLine($"Give a ride to {passangeer_places}! Sorry, but I can't take {number_all_people}");
            vipal_iz_avto = new Random().Next(passangeer_places);
        }

        public void Set_model(string input) => model = input;
        public void Set_buildDate(DateTime input) => buildDate = input;
        public void Set_length(float input) => length = input;
        public void Set_is_new(bool input) => is_new = input;
        public void Set_passangeer_places(int input) => passangeer_places = input;
        public void Set_maxSpeed(int input) => maxSpeed = input;
        public void Set_maxPower(int input) => maxPower = input;

        public Car()
        {
            this.model = "STANDART";
        }

        public Car(string mark)
        {
            this.mark = mark;
        }

        public Car(string mark, string model)
        {
            this.mark = mark;
            this.model = model;
        }

        static Car()
        {
            best_car = "Static ctor best car value";
            worest_car = "Static ctor worest car value";
        }
    }
}
