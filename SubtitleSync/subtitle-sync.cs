
using System;
using System.IO;  
using System. Text;

namespace SubtitleSync;
public class SubtitleSyncObj{

    // Main Method
    public SubtitleSyncObj(){}

    public List<String> modifyFile(string text, double valor){
        string[] linhas = text.Split(new string[] { Environment.NewLine + Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
        List<string> grupoString = new List<string>();
        string horario = "";

        for(int i=0; i< linhas.Length; i++){
            string[] separada = linhas[i].Split(Environment.NewLine);
            for(int j =0; j < separada.Length;j++){
                if(j==1){
                    horario = formatDate(separada[j], valor);
                    separada[1] = horario;
                }     
                grupoString.Add(separada[j]);    
            }
            grupoString.Add(" ");
        };

        grupoString.RemoveAt(grupoString.Count - 1);
        return grupoString;
    }

    public string formatDate(string dateOriginal, double valor){
        string tempo = dateOriginal;
        tempo = tempo.Replace(',', '.');
        string[] doisTempos = tempo.Split(" --> ");

        DateTime dateValue = DateTime.Parse(doisTempos[0]);
        DateTime dateValue2 = DateTime.Parse(doisTempos[1]);

        dateValue = dateValue.AddSeconds(valor);
        dateValue2 = dateValue2.AddSeconds(valor);

        string dataFormat = dateValue.ToString("hh:mm:ss.fff");
        string dataFormat2 = dateValue2.ToString("hh:mm:ss.fff");

        string substr = dataFormat.Substring(2,10);
        string substr2 = dataFormat2.Substring(2,10);
        
        string tempoSomado = doisTempos[0].Substring(0,2) + substr;
        string tempoSomado2 = doisTempos[1].Substring(0,2) + substr2;
        dateOriginal = tempoSomado + " --> " + tempoSomado2;
        string dateChanged = dateOriginal.Replace('.',',');

        return dateChanged;
    }


    public void Sync(string entrada, string arquivo)
    {    
        try {
        string path = "./" + arquivo;
        double valor = Convert.ToDouble(entrada);
        string text = File.ReadAllText(path);
        string[] lines = text.Split(Environment.NewLine);
        List<String> textoFinal = modifyFile(text, valor);
        string result = String.Join(Environment.NewLine, textoFinal.ToArray());
        File.WriteAllText("./final.srt", result);}
        
        catch(FormatException){
            Console.WriteLine("Formato de tempo inválido");
        }
        catch(FileNotFoundException){
            Console.WriteLine("Nome do arquivo inválido");        }
        catch(Exception){
            Console.WriteLine("Não foi possivel performar a operação");        }
    }
}