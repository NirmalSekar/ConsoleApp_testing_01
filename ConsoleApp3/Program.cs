using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  
    class Car
    {
        static void Main(string[] args)
        {
            Hello_world exercise1 = new Hello_world();
            exercise1.title = "Hi Nirmal,"
            Console.WriteLine(exercise1.title);
        }
        string color = "Grey";
        string model;
        string year;
        public string name;
        //Constructor
        public Car()
        {
            model = "Kia";
        }

        /// <summary>
        /// this is a property 
        /// </summary>
        public string Names
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        

        class Animal
        {
            public void animalSound()
            {
                Console.WriteLine("the animal makes sound");
            }
        }
        //class Pig: Animal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("wee wee");
        //    }
        //}
        //class Dog: Animal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("bow bow");
        //    }
        //}

        class Bird
        {
            public virtual void birdSound()
            {
                Console.WriteLine("the animal makes sound");
            }
        }

        class Pigeon : Bird
        {
            public override void birdSound()
            {
                Console.WriteLine("ik ik");
            }
        }
        class Peacock : Bird
        {
            public override void birdSound()
            {
                Console.WriteLine("ink ink");
            }
        }

        public void MyObjectMethod()
        {
            Console.WriteLine("This is a method that has been called by using object");
        }

        class Wheeler       // parent class
        {
            public string brand = "Hyundai";
            public void mtype()
            {
                Console.WriteLine("Hybrid");
            }
        }
        class Fourwheeler: Wheeler
        {
            public string modelName = "sonata";
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi my name is nirmal");
            //Console.ReadKey();

            Console.WriteLine("Hello world!!!");
            Console.WriteLine("I am learining c#");
            Console.WriteLine("It is awesome");
            Console.Write(3 + 3);
            //testing write command as it does not add new line to the statement
            Console.WriteLine("I am learining c#");
           




            string name = "nirmal kumar sekar";
            Console.WriteLine(name);



            int integer = 150;
            Console.WriteLine(integer);

            //int can be changed
            integer = 200;
            Console.WriteLine(integer);

            //when using const keyword for type then it cannot be changed
            const int nump = 56;
            Console.WriteLine(nump);


            Console.WriteLine("This is " + name);

            string firstName = "nirmal";
            string lastName = "sekar";
            string fullName = firstName+ " " + lastName;
            Console.WriteLine(fullName);
            

            //implicit casting ---> Converting one data type to another---> implicit casting is converting smaller type to larger type
            int myInt = 10;
            double myDouble = myInt;  //autmatic casting
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //explicit casting  ---> converting one data type to another ----> explicit casting is converting longer type to smaller type

            double toDouble = 50;
            int toInt = (int)toDouble;  // manual casting

            Console.WriteLine(toDouble);
            Console.WriteLine(toInt);

            //type conversion methods

            int myInte = 55;
            double myDou = 65;
            bool myBool = false;
            Console.WriteLine(Convert.ToString(myInte));
            Console.WriteLine(Convert.ToDouble(myInte));
            Console.WriteLine(Convert.ToInt32(myDou));
            Console.WriteLine(Convert.ToString(myBool));

            //UserInput

            Console.WriteLine("Type you age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);


            //Math functions

            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(10.79));

            //string interpolation


            string fullNames = $"my fullName is {firstName} { lastName}";
            Console.WriteLine(fullNames);


            //access strings
            Console.WriteLine(fullName[0]);
            Console.WriteLine(fullName.IndexOf('a'));

            //arrays
            string[] cars = { "BMW","Volvo", "Audi", "Lexus" };
            Console.WriteLine(cars[3]);
            //Change an array element
            cars[1] = "Toyota";
            Console.WriteLine(cars[1]);

            for(int i=0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //sort arrays
            Array.Sort(cars);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }

            MyMethod();

            MyFunc("methods");

            MyFuncs("NIRMAL", "SEKAR", 26);

            MyFunction("USA");
            MyFunction();
            MyFunction("ENGLAND");
            Console.WriteLine(SampleFunction(6, 7));
            NamedArg(child1: "nirmal", child2: "Dharsha", child3: "subi");
            int myIntMethod = PlusMethod(5, 6);
            double myDoubleMethod = PlusMethod(5.0,4.6);

            Console.WriteLine(myIntMethod);
            Console.WriteLine(myDoubleMethod);



            //Creating object
            
            Car myCar1 = new Car();
            Car myCar2 = new Car();
            Console.WriteLine(myCar1.color);
            Console.WriteLine(myCar2.color);


            Car myLife = new Car();
            myLife.color = "midnight black";
            myLife.model = "lexussssss";
            myLife.year = "2012";

            Console.WriteLine(myLife.model);
            Console.WriteLine(myLife.year);

            //calling a method using object

            Car myObj = new Car();
            myObj.MyObjectMethod();


            //Constructors -----> constructor must match the class name, it cannot have a return type
            //Also note that constructor is called when the object is created
            //constructor have paramter similar to methods
            Car Seltos = new Car();// this will call the constructor
            Console.WriteLine(Seltos.model);///print the value of the model

            //access modifier ----> by default private is the access modifier
            //public, private, protected, internal


            //properties
            Car Person = new Car();
            Person.Names = "sekar";
            Console.WriteLine(Person.Names);




            //Inheritance

            Fourwheeler myWheels = new Fourwheeler();
            myWheels.mtype();

            Console.WriteLine(myWheels.brand + " " + myWheels.modelName);


            //polymorphism---> means many forms, and it occurs when we have many classes that are related to each other by inheritance



            Animal myAnimal = new Animal();
            Animal myPig = new Animal();
            Animal myDog = new Animal();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Bird myBird = new Bird();
            Pigeon myPigeon = new Pigeon();
            Peacock myPeacock = new Peacock();

            myBird.birdSound();
            myPigeon.birdSound();
            myPeacock.birdSound();



            //Data abstraction   ---> the process of hiding certain details and showing only essential information to the user.
            //Abstraction can be achieved with either abstract classes or interfaces.
            //cannot be called inside an object











            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            Console.ReadKey();
        }
        //Method or function
        static void MyMethod()
        {
            Console.WriteLine("This is a method that has been called and printed inside the class");
        }

        //Methods with parameters
        static void MyFunc(string fname)
        {
            Console.WriteLine("This methods get the parameter string name is fname");
            Console.WriteLine(fname + " paramter");
        }

        static void MyFuncs(string firstN, string lastN, int age)
        {
            Console.WriteLine(firstN + "kumar" + lastN);
            Console.WriteLine("My age is " + age);
        }


        //Default Parameter in method
        static void MyFunction(string country = "India")
        {
            Console.WriteLine(country);
        }

        //RETURN values in methods

        static int SampleFunction(int x, int y)
        {
            return x + y;
        }


        //Named Arguements
        static void NamedArg(string child1, string child2, string child3)
        {
            Console.WriteLine("The Youngest child is : " + child2);
        
        }

        //method overloadind -----> Multiple methods can have the same name as long as the number and/or type of parameters are different
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        //class is a template for objects and an object is an instance of a class
        //When the individual objects are created, they inherit all the variables and methods from the class

    }
}
