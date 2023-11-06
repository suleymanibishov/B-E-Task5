using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task5
{
    public class Car
    {
        public short Year;
        public string Brend;
        public string Model;
        public string FuelType;
        public string Color;
        public void PrintInfo()
        {
            Console.WriteLine($"\n\n\t Brend: {Brend}\n\n\t Model: {Model}\n\n\t Year: {Year}\n\n\t FuelType: {FuelType}\n\n\t Color: {Color}\n\n");
        }
    }
}
