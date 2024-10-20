public class SerializeModelResident
{
    string path = "D:/site/Condominio/ResidentData.txt";
    SerializeWriteModel writer = new();
    Resident resident =  new("5728625762", "777","51564",true);

    public void ResidentSerializer()
    {
        writer.WriteFile(path, writer.SerializeToString(resident));
    }
}