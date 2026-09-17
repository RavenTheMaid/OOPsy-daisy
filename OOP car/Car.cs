using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_car
{
    internal class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public double NewPrice { get; set; }
        public double DrivenKM { get; set; }

        public double CalculateCarPrice()
        {
            double priceOfCar = NewPrice;
            TimeSpan calculateCarAge = DateTime.Today - DateOfManufacture;
            double yearsOld = Math.Truncate(calculateCarAge.TotalDays) / 365;
            int carAge = (int)yearsOld;
            double avgDrivenKM = DrivenKM / carAge;
            if (avgDrivenKM >= 25000)
            {
                for (int currentYear = 0; currentYear < carAge; currentYear++)
                {
                    if (currentYear <= 5)
                    {
                        priceOfCar = priceOfCar * 0.85;
                        priceOfCar = priceOfCar * 0.925;
                    }
                    else if (currentYear <= 35)
                    {
                        priceOfCar = priceOfCar * 0.9;
                        priceOfCar = priceOfCar * 0.925;
                    }
                    else
                    {
                        priceOfCar = priceOfCar * 1.05;
                        priceOfCar = priceOfCar * 0.925;
                    }
                }
            }
            else
            {
                for (int currentYear = 0; currentYear < carAge; currentYear++)
                {
                    if (currentYear <= 5)
                    {
                        priceOfCar = priceOfCar * 0.85;
                    }
                    else if (currentYear <= 35)
                    {
                        priceOfCar = priceOfCar * 0.9;
                    }
                    else
                    {
                        priceOfCar = priceOfCar * 1.05;
                    }
                }
            }
            
            return priceOfCar;


        }
    
        
    
    
    }
}
