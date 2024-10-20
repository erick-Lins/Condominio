public class SerializeModelApartment
{
    string path = "D:/site/Condominio/ApartmentData.txt";
    SerializeWriteModel writer = new();
    ModelApartment apartment = new("51564","12",124,12,63);

    public void ApartmentSerializer()
    {
        writer.WriteFile(path, writer.SerializeToString(apartment));
    }
}