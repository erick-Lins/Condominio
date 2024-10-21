using System; 
using System.IO; 

public class SerializeModelOwner
{ 
    SerializeWriteModel writer = new();
    
    ModelOwner owner = new(Guid.NewGuid(),"Luanderson","01/06/2001","They");
    
    public void OwnerSerializer(string path) 
    {
        writer.WriteFile(path,writer.SerializeToString(owner));
    }


}