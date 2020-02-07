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
            model = "Mustang"; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }

    // Outputs "Mustang"






}
