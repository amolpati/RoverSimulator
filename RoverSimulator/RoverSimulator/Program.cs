
using RoverDomain;
using RoverDomain.Enum;
using RoverDomain.Interfaces;
using RoverDomain.MarsSurface;
using RoverDomain.Validation;
using System;


namespace RoverSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            int sidePlateau = ValidationInput.getValidatedNumber("Please enter side of Plateau Square(positive integer only):");
            IPlateau marsPlateau = new Plateau(sidePlateau);

            string[] directionArray = { "N", "S","E","W" };
            string dir = ValidationInput.getValidatedText("Enter the direction the rover is Headed(N,S,E,W):", "Please enter valid value for Direction(N,S,E,W)", directionArray);

            int x = ValidationInput.getValidatedNumber("Enter the Initial XLocation:",true,sidePlateau);
            int y = ValidationInput.getValidatedNumber("Enter the Initial YLocation:",true,sidePlateau);

            string[] commandArray = { "L", "R", "A" };
            string instrSet = ValidationInput.getValidatedText("Enter the Commands(L,R,A): ", "Please enter valid value for Commands(L,R,A)", commandArray,false);

   
            Direction direction = (Direction)System.Enum.Parse(typeof(Direction), dir);

            IMarsRover massRover = new MarsRover(marsPlateau, x, y, direction, instrSet);


             massRover.executeInstruction();
             massRover.showCurrentLocation();

            Console.WriteLine("\n Press any key to exit.");
            Console.ReadKey();

        }
    }
}
