
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
        string tempo = null;
        //Console.WriteLine(text);

        foreach (string line in stringSeparada) {
            numLinha++;
            if(numLinha==2){
                tempo = line;
            }
            Console.WriteLine(line);
        }
        tempo = tempo.Replace(',', '.');
        str.Replace(',', ' ');       
        string[] doisTempos = tempo.Split(" --> ");
        Console.WriteLine(doisTempos[0]);
        DateTime dateValue = DateTime.Parse(doisTempos[0]);

        String dataFormatada;
        dataFormatada = dateValue.ToString("hh:mm:ss.fff");
        
        dateValue = dateValue.AddSeconds(131);
        dateValue = dateValue.AddHours(-12);
        string dataFormat = dateValue.ToString("hh:mm:ss.fff");
        Console.WriteLine(dataFormat);

}
    }
}