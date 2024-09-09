// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Solving the Surface Area of a Sphere");

//Calculate the Surface Area of a Sphere. Using 4 decimals (Will Require PI)
const double pi = 3.1415;

while(true)
{

//User Input
Console.WriteLine("Enter the Radius for a Sphere");

double radius = Convert.ToDouble(Console.ReadLine());

//Checking for Valid User Input
if(radius < 0)
{
    Console.WriteLine("Invalid Choice");
}
else
{
    Console.WriteLine("You entered " + radius);
}

//Calculating Surface Area
double surfaceArea;

surfaceArea= 4*pi*Math.Pow(radius,2);

//Format to 4 decimals
Console.WriteLine("Surface Area of the Sphere is " + "{0:F04}", surfaceArea);

Console.WriteLine("Would you like to continue? Type yes or no");
if(Console.ReadLine().ToLower() != "yes")
break;

}