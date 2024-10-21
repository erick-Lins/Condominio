using System; 
using System.IO;

class Program {

    public static void Main(string[] args){

        string[] paths = { "D:/site/Condominio/OwnerData.txt", "D:/site/Condominio/TowerData.txt" 
        ,"D:/site/Condominio/ApartmentData.txt", "D:/site/Condominio/ResidentData.txt" };

        SerializeModelOwner serializeOwner = new();
        serializeOwner.OwnerSerializer(paths[0]);
        
        SerializeModelTower serializeTower = new();
        serializeTower.TowerSerializer(paths[1]);

        SerializeModelApartment serializeApartment = new();
        serializeApartment.ApartmentSerializer(paths[2]);

        SerializeModelResident serializeResident = new();
        serializeResident.ResidentSerializer(paths[3]);
    }
}