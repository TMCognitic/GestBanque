using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBanque.Models.Divers
{
    public class Fahrenheit
    {
        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius() { Temperature = (fahrenheit.Temperature - 32) / 1.8 };
        }

        public double Temperature { get; set; }
    }
}
