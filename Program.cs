// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Solving the Surface Area of a Sphere");

//Calculate the Surface Area of a Sphere. (Will Require PI)
const double pi = 3.14;

//User Input
Console.WriteLine("Enter the Radius for a Sphere");

double radius = Convert.ToDouble(Console.ReadLine());

do
{

//Checking for Valid User Input
if(radius < 0)
{
    Console.WriteLine("Invalid Choice");
    continue;
}
else
{
    Console.WriteLine("You entered " + radius);
}
}while(radius < 0);

//Calculating Surface Area
double surfaceArea;

surfaceArea= 4*pi*Math.Pow(radius,2);

//Format to 4 decimals
Console.WriteLine("Surface Area of the Sphere is " + "{0:F04}", surfaceArea);



