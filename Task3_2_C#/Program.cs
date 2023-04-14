namespace Task3_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int way = 0;

            Wheel[] wheels = 
            { 
                new Wheel(4, true, 3, 6, "summer "), 
                new Wheel(4, true, 3, 6, "summer "), 
                new Wheel(4, true, 3, 6, "summer"), 
                new Wheel(4, true, 3, 6, "summer") 
            };            
            Engine engine = new Engine("150 л.с.", "2.4 литра", "Бензин");
            Car car = new Car(engine, "Nisan", 5, wheels);

            car.WriteNameModel();
            Console.WriteLine(car.GetCarInfo());
            Console.WriteLine("\n");

            car.Drive();
            Console.WriteLine("\n");
            Console.WriteLine("Проехали 1 км!");
            way += 1;
            car.Refuel(way);
            car.testMethod(wheels, way);
            car.testingWeals(wheels);
            Console.WriteLine("\n");
            
            Console.WriteLine("Проехали 99 км!");
            way += 99;
            car.Refuel(way);
            car.testMethod(wheels, way);
            car.testingWeals(wheels);
            
            Console.WriteLine("\n");
            car.StopDrive();
        } 
    }
}