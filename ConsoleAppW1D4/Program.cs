//Seehttps://aka.ms/new-console-templateformoreinformation

using System.ComponentModel;
using System.ComponentModel.Design;

Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Benvenuto nella pagina Login");


Console.WriteLine("Vuoi creare un account (s/n)");

var CreareAccount=Console.ReadLine();



if (CreareAccount == "s")
{
    Console.WriteLine("Perfetto creiamo account");

    Console.WriteLine("Inserisci Username");
    var InserireUsername = Console.ReadLine();

    if (InserireUsername != null && InserireUsername != "" &&  InserireUsername != " ") {
        Console.WriteLine("Username Valido");
        Console.WriteLine("Inserisci password");
        var Inserirepassword = Console.ReadLine();

        if (Inserirepassword != null && Inserirepassword != "", Inserirepassword != " "){

        } else {
            Console.WriteLine("Password non valida ricompilare");
            return;
        }
    } else
    {
        Console.WriteLine("Username non valida");
    }
        




}else if (CreareAccount == "n")
{
    Console.WriteLine("Arrivederci");
        return;
}



