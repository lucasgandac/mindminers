using SubtitleSync;

namespace SubtitleSyncTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodformatDate()
    {
        string dataEntrada = "00:20:41,150 --> 00:20:45,109";
        double val =  2;
        string dataSaida = "00:20:43,150 --> 00:20:47,109";
        SubtitleSyncObj teste = new SubtitleSyncObj(); 
        string format = teste.formatDate(dataEntrada, val);

        Assert.AreEqual(format, dataSaida);
    }
    [TestMethod]   
    public void TestMethodSync()
    {
        string textoEntrada = @"01
00:20:41,150 --> 00:20:45,109
- How did he do that?
- Made him an offer he couldn't refuse.

02
00:20:47,009 --> 00:20:47,230 
- There are no raindrops on roses and girls in white dresses
- It's sleeping with roaches and taking best guesses

03
00:20:48,000 --> 00:20:48,500
- Thanks for the memories.
- Even though they weren't so great.

04
00:20:49,000 --> 00:20:49,300
- How did we get here ?
- When i used to knew you so well

";
        List<string> saida = new List<string>() {"01","00:20:43,150 --> 00:20:47,109","- How did he do that?","- Made him an offer he couldn't refuse."," ","02","00:20:49,009 --> 00:20:49,230","- There are no raindrops on roses and girls in white dresses","- It's sleeping with roaches and taking best guesses"," ","03","00:20:50,000 --> 00:20:50,500","- Thanks for the memories.","- Even though they weren't so great."," ","04","00:20:51,000 --> 00:20:51,300","- How did we get here ?","- When i used to knew you so well", ""};
        double val =  2;
        SubtitleSyncObj teste = new SubtitleSyncObj(); 
        List<string> format = teste.modifyFile(textoEntrada, val);
        bool final = format.SequenceEqual(saida);

        Assert.IsFalse(final);
    }
}