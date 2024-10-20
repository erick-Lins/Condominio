using System; 
using System.IO; 

public class SerializeModelOwner
{ 

    string path = "D:/site/Condominio/OwnerData.txt";
    SerializeWriteModel writer = new();
    SerializeWriteModel serializeWriteModel = new();
    
    ModelOwner owner = new("777", "Erick", "28/01/2004","He");
    
    public void OwnerSerializer() 
    {
        writer.WriteFile(path,serializeWriteModel.SerializeToString(owner));
    }


}