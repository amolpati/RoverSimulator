using RoverDomain.Enum;
using RoverDomain.MarsSurface;

namespace RoverDomain.Interfaces
{
    public interface IPlateau
    {
        int Size { get; set; }
        Cell getNeighbour(Direction dir, Cell c);
    }
}
