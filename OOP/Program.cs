using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CarOwner carOwner = new CarOwner();
            Console.WriteLine(carOwner.carA.manufacturer);
            Console.WriteLine($"Current speed is: {carOwner.carA.currentSpeed} km/h! Change the speed:");
            carOwner.carA.GoFaster(Console.ReadLine());*/

            /*Person person1 = new Person("Joakim", "Olofsson", 37, "Gatan");*/

            /*Car car1 = new Car("Volvo", "V70", "Silver");
            Console.WriteLine($"Tillverkare: {car1.manufacturer}\n" +
                $"Modell: {car1.model}\n" +
                $"Färg: {car1.color}\n" +
                $"Hastighet: {car1.ChangeSpeed()}");*/

            /*Person person1 = new Person("Joakim", "Olofsson");
            Console.WriteLine(person1.FullName);*/

            Car myCar = new Car("Car", "Ground", "Drivers License", "Volvo", "V70", "Red");
            Boat myBoat = new Boat("Sailboat", "Water", "Boat License", true, false, 3);
            Console.WriteLine($"{myCar.Type} | {myBoat.Type}" );
        }
    }


    class Vehicle
    {
        public string Type { get; set; }
        public string WayOfTravel { get; set; }
        public string LicenseType { get; set; }

        public Vehicle(string type, string wayOfTravel, string licenseType)
        {
            Type = type;
            WayOfTravel = wayOfTravel;
            LicenseType = licenseType;
        }
    }

    class Car : Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(string type, string wayOfTravel, string licenseType, string manufacturer, string model, string color)
            : base(type, wayOfTravel, licenseType)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
        }
    }

    class Boat : Vehicle
    {
        public bool Sail { get; set; }
        public bool Engine { get; set; }
        public int Cabins { get; set; }

        public Boat(string type, string wayOfTravel, string licenseType, bool sail, bool engine, int cabins)
            : base(type, wayOfTravel, licenseType)
        {
            Sail = sail;
            Engine = engine;
            Cabins = cabins;
        }
    }

    /*class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = HandleInput(value);
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = HandleInput(value);
        }
        public string FullName { get => $"{_firstName} {_lastName}"; }

        private string HandleInput(string value)
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                return "Dont leave this empty!";
            }

            return value;
        }
    }*/

    /*class Car
    {
        public string manufacturer;
        public string model;
        public string color;
        private int _speed;
        private int _maxSpeed;

        public Car(string manufacturer, string model, string color)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
            _speed = 50;
            _maxSpeed = 200;
        }

        public int ChangeSpeed()
        {
            return _speed = 100;
        }
    }*/

    /*class Person
    {
        public string name;
        public string lastname;
        public int age;
        public string address;

        public Person(string name, string lastname, int age, string address)
        {
            name = name;
            lastname = lastname;
            age = age;
            address = address;
        }
    }*/

    /*class CarA
    {
        public string manufacturer = "Volvo";
        public string model = "V70";
        public string color = "red";
        public int currentSpeed = 50;
        public int maxSpeed = 200;

        public void GoFaster(string inputSpeed)
        {
            int newSpeed = int.Parse(inputSpeed);

            if(newSpeed < maxSpeed)
            {
                currentSpeed = newSpeed;
                Console.WriteLine($"The car is now going {currentSpeed} km/h!");
            }
            else
            {
                Console.WriteLine("The car can't go that fast!");
            }
        }
    }*/

    /*class CarB
    {
        public string manufacturer = "Audi";
        public string model = "A3";
        public string color = "Silver";
        public int currentSpeed = 50;
        public int maxSpeed = 200;

        public void GoFaster(string inputSpeed)
        {
            int newSpeed = int.Parse(inputSpeed);

            if (newSpeed < maxSpeed)
            {
                currentSpeed = newSpeed;
                Console.WriteLine($"The car is now going {currentSpeed} km/h!");
            }
            else
            {
                Console.WriteLine("The car can't go that fast!");
            }
        }
    }*/

    /*class CarOwner
    {
        public CarA carA = new CarA();
        public CarB carB = new CarB();
    }*/
}
