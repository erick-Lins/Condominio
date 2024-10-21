using System;
using System.IO;

public class ModelOwner{

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string DateBirth { get; set; }
    public string Pronoun { get; set; }

    public ModelOwner(Guid id, string name, string dateBirth, string pronoun){
        Id = id;
        Name = name; 
        DateBirth = dateBirth;
        Pronoun = pronoun;
    }

}