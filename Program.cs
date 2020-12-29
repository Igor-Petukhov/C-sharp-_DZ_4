using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Const vehicle_type: {Car.vehicle_type}");
            Console.WriteLine($"Firstly, best car is static: {Car.best_car}");
            Console.WriteLine($"Worest car is static: {Car.worest_car}\n");

            Car MyCar = new Car()
            {
                mark = "ziguli"
            };
            
            MyCar.tirazh = 15000;
            MyCar.Set_length((float)3500.15);
            MyCar.Set_model("model-X");
            MyCar.Set_passangeer_places(12);
            MyCar.Set_is_new(true);
            MyCar.Set_buildDate(new DateTime(1980, 8, 27));
            MyCar.Set_maxSpeed(380);
            MyCar.Set_maxPower(700);

            MyCar.Print();
            MyCar.Boost();
            MyCar.Print();
            MyCar.Crash();
            MyCar.Print();
            MyCar.Repair();
            MyCar.Print();
            MyCar.Repair();
            MyCar.Print();
            MyCar.Boost();
            MyCar.Print();
            MyCar.Boost(); MyCar.Boost(); MyCar.Boost(); MyCar.Boost(); MyCar.Boost(); MyCar.Boost();
            MyCar.Print();

            //Автомобиль подвозит людей с остановки. Там стоит 100 человек.
            int number_people_on_the_station = 100;
            int people_vipal_iz_avto_po_doroge;
            Console.WriteLine($"There are: {number_people_on_the_station} people on the station.");
            MyCar.Give_a_ride(ref number_people_on_the_station, out people_vipal_iz_avto_po_doroge);
            Console.WriteLine($"There are: {number_people_on_the_station} people on the station.");
            Console.WriteLine($"По дороге выпало {people_vipal_iz_avto_po_doroge} людей из авто.");

            Car HisCar = new Car();
            HisCar.Print();

            Car HerCar = new Car("Cadillac");
            HerCar.Print();

            Car OurCar = new Car("Cadillac", "Escalade");
            OurCar.Print();

            Car[] arrCar = new Car[5];
            arrCar[0] = MyCar;
            arrCar[1] = HisCar;
            arrCar[2] = HerCar;
            arrCar[3] = OurCar;
            arrCar[4] = new Car();

            Console.WriteLine("-------------------");
            foreach (var item in arrCar)
            {
                item.Print();
            }
            Console.WriteLine("-------------------");

            MyCar.Partial_Print_is_ok();
            
            Console.ReadKey();
        }
    }
}
