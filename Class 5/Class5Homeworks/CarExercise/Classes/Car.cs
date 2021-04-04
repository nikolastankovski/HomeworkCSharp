using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise.Classes
{
    class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }

        public static Car RaceCars(Car[] cars)
        {
            Car winner = new Car("", 0);
            int highestSpeed = 0;
            foreach(Car x in cars)
            {
                if(x.CalculateSpeed() > highestSpeed)
                {
                    winner = x;
                    highestSpeed = x.CalculateSpeed();
                }
            }

            return winner;
        }
    }
}
