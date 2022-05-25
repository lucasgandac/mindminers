
using System;
using System.IO;  
using System. Text;  
  
namespace Mindminers {
  
class Subtitle {


    // Main Method
    static void Main(string[] args)
    {
        string str = "Getting string";
        string path = "./legenda.srt";
        
        string text = File.ReadAllText(path);
        string[] lines = text.Split(Environment.NewLine);
        int i = 0 ;
        string[] linhas = text.Split(new string[] { Environment.NewLine + Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
        string[] stringSeparada = linhas[0].Split(Environment.NewLine);
        int numLinha = 0;
        Console.WriteLine(text);
}
    }
}