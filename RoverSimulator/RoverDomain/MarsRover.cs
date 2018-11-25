using RoverDomain.Enum;
using RoverDomain.Interfaces;
using RoverDomain.MarsSurface;
using System;

namespace RoverDomain
{
    public class MarsRover : IMarsRover
    {
        public string InstructionSet { get; set; }
        public bool IsValid { get; set; }
        public IPlateau mars_Plateau { get; set; }
        public Cell CurrentLocation { get; set; }

        public Direction Dir { get; set; }

        public MarsRover(IPlateau marsPlateau, int x, int y, Direction dir, String instSet)
        {

            mars_Plateau = marsPlateau;
            InstructionSet = instSet;
            this.Dir = dir;
            CurrentLocation = new Cell(x, y);
            IsValid = true;

        }


        public Direction setDirection(Direction dir, char inst)
        {

            if (inst == 'L')
            {
                switch (dir)
                {
                    case Direction.N:
                        dir = Direction.W;
                        break;
                    case Direction.W:
                        dir = Direction.S;
                        break;
                    case Direction.S:
                        dir = Direction.E;
                        break;
                    case Direction.E:
                        dir = Direction.N;
                        break;
                }
            }

            else if (inst == 'R')
            {

                switch (dir)
                {
                    case Direction.N:
                        dir = Direction.E;
                        break;
                    case Direction.W:
                        dir = Direction.N;
                        break;
                    case Direction.S:
                        dir = Direction.W;
                        break;
                    case Direction.E:
                        dir = Direction.S;
                        break;
                }
            }

            return dir;

        }

        public void showCurrentLocation()
        {
            Console.Write(IsValid + "," + "" + Dir + "," + "(" + CurrentLocation.X + "," + CurrentLocation.Y + ")");

        }

        public void executeInstruction()
        {

            foreach (char c in InstructionSet)
            {
                if (c == 'A')
                {
                    Cell nextCell = mars_Plateau.getNeighbour(Dir, CurrentLocation);
                    if (nextCell != null) CurrentLocation = nextCell;
                    else
                    {
                        IsValid = false;
                        break;
                    }
                }

                if (c == 'L' || c == 'R') Dir = setDirection(Dir, c);

            }

        }
    }
}
