// See https://aka.ms/new-console-template for more information
//using ConsoleApp3;
//using ConsoleApp3.AccessModifiers_extended_;
//using ConsoleApp3.Inheritance_Extended_;
//using ConsoleApp3.Inheritance_Extended_.Practical_exercise;
using ConsoleApp3.Polymorphism_Extended_;

//Bank
//var bankCustomer1 = new Customer("John");
//BankAccount account1 = new BankAccount(bankCustomer1.Name, 1000);
//BankAccount account2 = new BankAccount(bankCustomer1.Name, 2000);
//bankCustomer1.AddBankAccount(account1);
//bankCustomer1.AddBankAccount(account2);
//bankCustomer1.InfoDisplay();

//Shapes
//var circle1 = new Circle("red", 23);
//circle1.GetColor();

//Base class and Derived class Constructor
//var manager1 = new Manager("John", 2, "H", 5);

//Method hiding
//var engineCar = new Vehicle();
//var electricCar = new ElectricCar();z
//engineCar.StartEngine();
//electricCar.StartEngine();


//Abstract Class and Methods
//var myCircle = new Circle2(6.56);
//var myRectangle = new Rectangle(5, 20);
//Console.WriteLine($"Shape:{myCircle.Name} Area: {myCircle.CalculateArea()}");
//Console.WriteLine($"Shape:{myRectangle.Name} Area: {myRectangle.CalculateArea()}");


//Multiple Levels of inheritance
//var manager2 = new Manager2("John", 2, "Logistics", 10);
//manager2.Introduce();
//manager2.Work();
//manager2.LeadTeam();


//Inheritance with Method Overriding
//Animal2[] animal2s = { new Animal2(), new Dog2(), new Cat2() };
//foreach(var animal in animal2s)
//{
//    animal.MakeSound();
//}

//Inheritance Practical Exercise
//var manager = new Manager("John", 2, "HR", 5);
//var developer = new Developer("Steve", 3, "Logistics", "C#");
//manager.Work();
//developer.Work();

//Method Overloading
//var myCalculator = new Calculator();
//myCalculator.Add(2,3);
//myCalculator.Add(2.2, 3.5);
//myCalculator.Add("hello", "world");

//Using Interfaces for Polymorphism
//List<IPlayable> playables = new List<IPlayable>
//{
//    new FootballPlayer(),
//    new Guitarist()
//};
//foreach(var player in playables)
//{
//    player.Play();
//}

//Polymorphism with Abstract Classes
//List<Shape> shapes = new List<Shape>
//{
//    new Circle(3),
//    new Rectangle(5,4)
//};
//foreach(var shape in shapes)
//{
//    Console.WriteLine($"{shape.Name} area :{shape.Area()}");
//}

//Polymophism with Collections
//List<IShape> shapes = new List<IShape>
//{
//    new Circle(3),
//    new Rectangle(5,4)
//};
//foreach(var shape in shapes)
//{
//    shape.GetInfo();
//}

//Polymorphism with Dynamic Types
//dynamic person = new Person("Steve", 18);
//dynamic employee = new Employee("John", 25, "YouTube");
//person.Introduce();
//employee.Introduce();