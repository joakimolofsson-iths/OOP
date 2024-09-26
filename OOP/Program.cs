namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarOwner carOwner = new CarOwner();
            Console.WriteLine(carOwner.carA.manufacturer);
            Console.WriteLine($"Current speed is: {carOwner.carA.currentSpeed} km/h! Change the speed:");
            carOwner.carA.GoFaster(Console.ReadLine());
        }
    }

    class CarA
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
    }

    class CarB
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
    }

    class CarOwner
    {
        public CarA carA = new CarA();
        public CarB carB = new CarB();
    }
}
