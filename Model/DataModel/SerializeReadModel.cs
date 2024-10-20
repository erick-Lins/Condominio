using System;
using System.IO;

public class SerializeReadModel{

    public void ReadFile(string filePath) {

    using(StreamReader reader = new StreamReader(filePath)){
        string line; 
        while((line = reader.ReadLine()) != null){
            Console.WriteLine(line);
        }
    }
    }

    
}