using System;
using System.Formats.Asn1;
using System.IO;

public class SerializeModelTower
{
  
    SerializeWriteModel writer = new();

    ModelTower tower = new(Guid.NewGuid(),2,15,false,true,1000);

    public void TowerSerializer(string path)
    {
        writer.WriteFile(path, writer.SerializeToString(tower));
    }
}