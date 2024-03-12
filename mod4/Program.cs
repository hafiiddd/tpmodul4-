// See https://aka.ms/new-console-template for more information


public class KodePos 
{
    public enum area {
        Batununggal = 40266,
        Kujangsari = 40287,
        Mengger = 40267,
        wates = 40256,
        cijaura = 40287,
        Jatisari = 40286,
        Margasari = 40286,
        Sekejati = 40286,
        KebonWaru = 40272,
        Maleer = 40274,
        Samoja = 40273,
    }
    public static int getKodepos(area Area)
    {
        
        return ((int) Area);
    }
    public static void Main(string[] args)
    {
        area kodePos= area.Batununggal;
        Console.WriteLine($" {kodePos} = {getKodepos(kodePos)}");
    }
}