using System;
//Create an Object
namespace OOppractise
{

    //class1 def
    class Car
    {
        public string color = "red";


    }

    //class2 def
    class Carcolor
    {
        public string color1 = "red";
    }
    //class3 def
    class MyClass
    {
        // Class members-declaring new fields
        public string color = "red";        // field
        public int maxSpeed = 200;          // field
        //declaring a method
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    //class4 def
    class Car1
    {
        public string model;
        public string color;
        public int year;


    }

    //class5 def

    // Create a Car class
    class Carmodel
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Carmodel()
        {
            model = "Mustang"; // Set the initial value for model
        }


    }
    //
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            //sigle object creation
            Console.WriteLine(myObj.color);
            //multiple object creation
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

            //using new field and method
            MyClass myObj3 = new MyClass();
            Console.WriteLine(myObj3.color);
            Console.WriteLine(myObj3.maxSpeed);
            myObj3.fullThrottle();

            //Creating multiple objects
            Car1 Ford = new Car1();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car1 Opel = new Car1();
            Opel.model = "Astra";
            Opel.color = "whit";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            //
            Carmodel Ford1 = new Carmodel();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford1.model);  // Print the value of model
        }
    }
}