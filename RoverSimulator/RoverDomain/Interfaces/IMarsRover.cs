using RoverDomain.Enum;
using RoverDomain.MarsSurface;

namespace RoverDomain.Interfaces
{
    public interface IMarsRover
    {
        string InstructionSet{get;set;}
        bool IsValid {get;set;}

        IPlateau mars_Plateau {get;set;}
        Direction setDirection(Direction dir, char inst);

        Cell CurrentLocation{get;set;}

        Direction Dir { get; set; }
         void showCurrentLocation();
         void executeInstruction();
    }
}
