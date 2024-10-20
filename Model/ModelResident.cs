public class Resident 
{
    public string Id { get; set; }
    public string IdOwner { get; set; }
    public string IdApartment { get; set; }
    public bool IsOwner { get; set; }

    public Resident(string id, string idOwner, string idApartment, bool isOwner)
    {
        Id = id; 
        IdOwner = idOwner; 
        IdApartment = idApartment; 
        IsOwner = isOwner;
    }

}