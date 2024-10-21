public class SerializeModelResident
{
  
    SerializeWriteModel writer = new();
    Resident resident =  new(Guid.NewGuid(), "777","51564",true);

    public void ResidentSerializer(string path)
    {
        writer.WriteFile(path, writer.SerializeToString(resident));
    }
}