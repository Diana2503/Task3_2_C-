using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3_2_C_
{
    internal class Car
    {
        private string model;
        private int isFuel;
        private bool isGood;
        private Engine engine;
        private Wheel[] wheels;
        
        public Car(Engine engine, string model, int isFuel, Wheel[] wheels)
        {
            this.engine = engine;
            this.model = model;
            this.isFuel = isFuel;
            this.wheels = wheels;
        }

        public void Drive()
        {
            Console.WriteLine("Поехали!");
        }

        public void StopDrive()
        {
            Console.WriteLine("Поездка завершена!");
        }

        public void WriteNameModel()
        {
            Console.WriteLine("Марка автомобиля:" + " " + model);
        }
               
        public void Refuel(int way)
        {
            if(way % 100 == 0)
            {
                Console.WriteLine("Необходимо заправить автомобиль.");
            }
            else
            {
                Console.WriteLine("Автомобиль заправлен.");
            }
        }

        public void testingWeals(Wheel[] wheels)
        {
            for (int i = 0; i < this.wheels.Length; i++)
            {
                if (!wheels[i].IsGood)
                {
                    Console.WriteLine("Пробито колесо: " + (i + 1));
                }
            }
        }

        public void testMethod(Wheel[] wheels, int way)
        {
            bool flag;
            if (way % 100 == 0)
            {
                Random rnd = new Random();
                flag = rnd.Next(0, 2) == 1;
                if (flag)
                {
                    int randNum = rnd.Next(0, 4);
                    wheels[randNum].IsGood = false;
                }
                else
                {
                    Console.WriteLine("Смена колес не требуется. Все целы!");
                }
            }
            else
            {
                Console.WriteLine("Смена колес не требуется. Все целы!");
            }
        }

        public string GetCarInfo()
        {
            string info = "Характеристики автомобиля:\n";
            info += "Мощность двигателя: " + engine.GetInfoPower() + "\n";
            info += "Объем двигателя: " + engine.GetInfoVolume() + "\n";
            info += "Тип топлева: " + engine.GetInfoFuel() + "\n";
            return info;
        }

        public Wheel[] Wheel
        {
            get { return wheels; }
            set { wheels = value; }
        }
     }
}

