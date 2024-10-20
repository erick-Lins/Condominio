using System;
using System.IO;

public class SerializeWriteModel() {

    public void WriteFile(string filePath, string dataInsert)
    {
        using(StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(dataInsert);
        }

        System.Console.WriteLine("File written succesfully");
    }
    
    public string SerializeToString(object obj)
    {
        var type = obj.GetType();
        string serializedString = "";

        foreach(var p in type.GetProperties())
        {
            serializedString += $"{p.Name}:{p.GetValue(obj)};";
        }

        return serializedString.TrimEnd();
    }
}