
using System;
using System.IO;  
using System.Collections.Generic;
using System. Text;  
  
namespace Mindminers {        
  
class Subtitle {
    // Main Method
    static void Main(string[] args)
    {
        string str = "Getting string";
        string path = "./legenda.srt";
        
        Console.WriteLine("Insira o tempo em segundo");
        string entrada = Console.ReadLine();
        double valor = Convert.ToDouble(entrada);
        Console.WriteLine(valor);
        string text = File.ReadAllText(path);
        string[] lines = text.Split(Environment.NewLine);
        int i = 0 ;
        string[] linhas = text.Split(new string[] { Environment.NewLine + Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
        string[] stringSeparada = linhas[0].Split(Environment.NewLine);
        string[] stringSeparada2 = linhas[1].Split(Environment.NewLine);
        int numLinha = 0;
        string tempo = null;
        List<string> tudoJunto = new List<string>();
        string[] bloco = linhas;
        List<string> teste = new List<string>();

        for(i=0; i< linhas.Length; i++){
            string[] separada = linhas[i].Split(Environment.NewLine);
            for(int j =0; j < separada.Length;j++){
                if(j==1){
                    //Console.WriteLine(separada[j]);
                    tempo = separada[j];
                    tempo = tempo.Replace(',', '.');
                    string[] doisTempos = tempo.Split(" --> ");
                    DateTime dateValue = DateTime.Parse(doisTempos[0]);
                    DateTime dateValue2 = DateTime.Parse(doisTempos[1]);
                    //Console.WriteLine(dateValue.ToString("hh:mm:ss.fff"));
                    dateValue = dateValue.AddSeconds(valor);
                    dateValue2 = dateValue2.AddSeconds(valor);
                    string dataFormat = dateValue.ToString("hh:mm:ss.fff");
                    string dataFormat2 = dateValue2.ToString("hh:mm:ss.fff");
                    string substr = dataFormat.Substring(2,10);
                    string substr2 = dataFormat2.Substring(2,10);
                    //Console.WriteLine(doisTempos[0].Substring(0,2) + substr );
                    string tempoSomado = doisTempos[0].Substring(0,2) + substr;
                    string tempoSomado2 = doisTempos[1].Substring(0,2) + substr2;
                    separada[1] = tempoSomado + " --> " + tempoSomado2;
                    separada[1] = separada[1].Replace('.',',');
                }         
                teste.Add(separada[j]);
                //Console.WriteLine(separada.Length);
            }
                teste.Add(" ");

        };
        Console.WriteLine(linhas[0]);
        Console.WriteLine(teste[1]);  
        //Console.WriteLine(bloco[0]);
        for(int k =0; k < bloco.Length; k++){
            tudoJunto.Add(bloco[k]);
            tudoJunto.Add("");
        }
        teste.RemoveAt(teste.Count - 1);
        string result = String.Join(Environment.NewLine, teste.ToArray());

        //Console.WriteLine(result);
        File.WriteAllText("./final.txt", result);  
    }
    }
}