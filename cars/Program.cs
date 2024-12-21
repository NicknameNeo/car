using System;

    namespace project
    {
        class Cars
        {
            public string Name { get; set; }
            public string Color { get; set; }
            protected string Model { get; set; }
            protected double Motor { get; set; }
            protected string MaxSpeed { get; set; }

            public string GetModel
            {
                get {return Model;}
                set {Model = value;}
            }

            public double GetMotor
            {
                get { return Motor; }
                set { Motor = value; }
            }

            public string GetMaxSpeed
            {
                get { return MaxSpeed; }
                set { MaxSpeed = value; }
            }

            
        }

        class Bmw : Cars
        {
            public Bmw()
            {
                Name = "BMW";
                Color = "Black";
                Model = "BMW M5 F90 CS";
                MaxSpeed = "305 km/h";
                Motor = 4.4;
            }

            
        }

        class Mercedes : Cars
        {
            public Mercedes()
            {
                Name = "Mercedes";
                Color = "White";
                Model = "Mercedes AMG One";
                MaxSpeed = "350 km/h";
                Motor = 4.1;
            }

            
        }

        class Program
        {
            static void Main(string[] args)
            {
                Bmw bmw = new Bmw();
                Mercedes mercedes = new Mercedes();

                Console.WriteLine($"{bmw.Name}:");
                Console.WriteLine($"Color: {bmw.Color}");
                Console.WriteLine($"Model: {bmw.GetModel}");
                Console.WriteLine($"Motor: {bmw.GetMotor} L");
                Console.WriteLine($"Max Speed: {bmw.GetMaxSpeed}");


                Console.WriteLine();

                Console.WriteLine($"{mercedes.Name}:");
                Console.WriteLine($"Color: {mercedes.Color}");
                Console.WriteLine($"Model: {mercedes.GetModel}");
                Console.WriteLine($"Motor: {mercedes.GetMotor} L");
                Console.WriteLine($"Max Speed: {mercedes.GetMaxSpeed}"); 
            }
            
        }
}