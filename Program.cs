using System; 
using System.IO;

class Program {

    public static void Main(string[] args){

        SerializeModelOwner serializeOwner = new();
        serializeOwner.OwnerSerializer();
        
        SerializeModelTower serializeTower = new();
        serializeTower.TowerSerializer();

        SerializeModelApartment serializeApartment = new();
        serializeApartment.ApartmentSerializer();

        SerializeModelResident serializeResident = new();
        serializeResident.ResidentSerializer();
    }
}