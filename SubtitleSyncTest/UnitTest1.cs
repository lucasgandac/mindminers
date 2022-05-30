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
    public void TestMethodSync()
    {
        string dataEntrada = "00:20:41,150 --> 00:20:45,109";
        double val =  2;
        string dataSaida = "00:20:43,150 --> 00:20:47,109";
        SubtitleSyncObj teste = new SubtitleSyncObj(); 
        string format = teste.formatDate(dataEntrada, val);

        Assert.AreEqual(format, dataSaida);
    }
}