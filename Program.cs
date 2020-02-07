using System;

namespace Inclass_Exercise_OOP
{

    class Car
    {
        string color;
        int maxSpeed;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}

namespace Inclass_Exercise_OOP_a
{
    // create a car class
    class car
    {
        public string model;  // create a field

        // create a class constructor for the car class
        public car()
        {
            model = "mustang"; 
        }

       static void main(string[] args)
        {
            car ford = new car();  
            Console.WriteLine(ford.model);
        }
    }
}

namespace Inclass_Exercise_OOP_b
{ 
class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }


}
