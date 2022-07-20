using FactoryPattern;

Console.WriteLine("Lets create a new vehicle! \n");

Console.WriteLine("How many wheels will your new vehicle have?");
int userInput = Convert.ToInt32(Console.ReadLine());
var userVehicle = VehicleFactory.GetVehicle(userInput);
userVehicle.Drive();