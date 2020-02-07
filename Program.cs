using System;

namespace Inclass_Exercise_OOP
{

    //class Car
    //{
    //    string color;
    //    int maxSpeed;

    //    static void Main(string[] args)
    //    {
    //        Car myObj = new Car();
    //        myObj.color = "red";
    //        myObj.maxSpeed = 200;
    //        Console.WriteLine(myObj.color);
    //        Console.WriteLine(myObj.maxSpeed);
    //    }
    //}

    // Create a Car class
    class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; 
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();  
            Console.WriteLine(Ford.model);
        }
    }

    // Outputs "Mustang"






}
