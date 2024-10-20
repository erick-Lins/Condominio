using System; 
using System.IO;

public class ModelTower 
{
    public string Id { get; set; }
    public int NumberTow { get; set; }
    public int Floors { get; set; }
    public bool HasRooftop { get; set; }
    public bool HasElevator { get; set; }
    public int PerimeterSquare { get; set; }

    public ModelTower(string id, int numberTow, int floors, bool hasRooftop, bool hasElevator, int perimeterSquare)
    {
        Id = id; 
        NumberTow = numberTow; 
        Floors = floors; 
        HasRooftop = hasRooftop; 
        HasElevator = hasElevator; 
        PerimeterSquare = perimeterSquare;
    }
}