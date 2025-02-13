//Seehttps://aka.ms/new-console-templateformoreinformation

Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Benvenuto nella pagina Login");


Console.WriteLine("Vuoi creare un account (s/n)");

var CreareAccount=Console.ReadLine();

var InserisciNome = "";

var InserisciCognome= "";


if( CreareAccount == "s")
{
    Console.WriteLine("Perfetto creiamo account");



}else if (CreareAccount == "n")
{
    Console.WriteLine("Arrivederci");
        return;
}



