public class SerializeModelApartment
{
    SerializeWriteModel writer = new();
    ModelApartment apartment = new(Guid.NewGuid(),"12",124,12,63);

    public void ApartmentSerializer(string path)
    {
        writer.WriteFile(path, writer.SerializeToString(apartment));
    }
}