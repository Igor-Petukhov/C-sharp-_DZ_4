using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    partial class Car
    {
        public void Partial_Print_is_ok()
        {
            Console.WriteLine($"\nIt's partial method! {vehicle_type} {best_car} {worest_car} {mark} {model} {buildDate.ToShortDateString()} {length} {is_new} {passangeer_places} {maxSpeed} {maxPower} {tirazh}");
        }
    }
}
