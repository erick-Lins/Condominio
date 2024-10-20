using System;
using System.Formats.Asn1;
using System.IO;

public class SerializeModelTower
{
    string path = "D:/site/Condominio/TowerData.txt";
    SerializeWriteModel writer = new();

    ModelTower tower = new("12",2,15,false,true,1000);

    public void TowerSerializer()
    {
        writer.WriteFile(path, writer.SerializeToString(tower));
    }
}