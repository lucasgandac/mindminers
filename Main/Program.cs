using SubtitleSync;
using System;
using System.IO;  
using System. Text;

class Program
{ 
    static void Main(string[] args)
    {
        SubtitleSyncObj teste = new SubtitleSyncObj();  
        Console.WriteLine("Insira o tempo em segundo(se necessário milissegundos utilize vírgula)");
        string? entrada = Console.ReadLine();
        Console.WriteLine("Insira o nome do arquivo com formato");
        string? arquivo = Console.ReadLine();
        if(entrada==null || arquivo ==null){
            Console.WriteLine("Por favor inserir entradas válidas");
        }else{
        teste.Sync(entrada, arquivo);};

    }
}