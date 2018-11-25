using RoverDomain.Enum;
using RoverDomain.Interfaces;

namespace RoverDomain.MarsSurface
{
    public class Plateau : IPlateau
    {
        public int Size  { get; set; }


        public Plateau(int size)
        {

            this.Size = size;

        }

        
        public Cell getNeighbour(Direction dir, Cell c)
        {
            Cell neighbour = null;

            switch (dir)
            {

                case Direction.N:
                    neighbour = new Cell(c.X, c.Y + 1);
                    break;
                case Direction.W:
                    neighbour = new Cell(c.X - 1, c.Y);
                    break;
                case Direction.S:
                    neighbour = new Cell(c.X, c.Y - 1);
                    break;
                case Direction.E:
                    neighbour = new Cell(c.X + 1, c.Y);
                    break;

                default: neighbour = null; break;
            }

            if ((neighbour.X >= 0) && (neighbour.Y >= 0) && (neighbour.X < Size) && (neighbour.Y < Size))
                return neighbour;

            return null;
        }
    }
}
