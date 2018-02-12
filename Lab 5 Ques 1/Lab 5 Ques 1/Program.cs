using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5_Ques_1
{
    public class information
    {
        public String naam, model_location;
        public int weight_speed;
            public information(string name, string location)
            {
                this.naam = name;
                this.model_location = location;
            }
            public information(string driver, string model, int spd_wgh)
            {
                this.naam = driver;
                this.model_location = model;
                this.weight_speed = spd_wgh;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                information cycle = new information("Rider", "NIPA"); 
                information car = new information("Zain","R-4348",200);
                information lorry = new information("Zain","T-7854",234);
                Console.WriteLine("Cycle name is " + cycle.naam + " and location is " + cycle.model_location);
                Console.WriteLine("Driver name is " + car.naam + " and model is " + car.model_location + " and speed is" + car.weight_speed+" km/h");
                Console.WriteLine("Driver name is " + lorry.naam + " and model is " + lorry.model_location + "and weight is " + lorry.weight_speed+" KG");
                Console.ReadKey();
            }
        }
    }
