using System;
using System.IO;

public class View  {

    public void ShowMenu(List<string> options){
        foreach(string option in options){
            int i = 0;
            System.Console.WriteLine($"{i}: {options}");
            i++;
        }
    }

}