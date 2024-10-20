public class ModelApartment
{
    public string Id { get; set; }
    public string IdTower { get; set; }
    public int NumberAp { get; set; }
    public int Floor { get; set; }
    public double Size { get; set; }

    public ModelApartment(string id, string idTower, int numberAp, int floor, double size)
    {
        Id = id; 
        IdTower = idTower; 
        NumberAp = numberAp; 
        Floor = floor; 
        Size = size;
    }
}