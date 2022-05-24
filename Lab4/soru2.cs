public class Gezegen
{
    protected int gezegenSayisi = 9;
    protected string sisteminAdi = "Güneş Sistemi";

    public virtual void bilgiAl(){ 
        Console.WriteLine("Gezegen Sayısı: {0}", gezegenSayısı);
        Console.WriteLine("Sistemin Adı: {0}", sisteminAdi);
        Console.WriteLine();
    }
}
class Mars : Gezegen
{
    public string gezegenAdi = "Mars";
    public override void bilgiAl(){  
        base.bilgiAl(); 
        Console.WriteLine("Gezegen Adı: {0}", gezegenAdi);  
    }
}
class Uydu : Mars
{
    private string uyduAdi = "Deimos";
    public void bilgiAl(){ 
        base.bilgiAl(); 
        Console.WriteLine("Uydusunun Adı: {0}", uyduAdi);
    }
}
public static void Main(){ 
    Mars m = new Mars(); 
    m.bilgiAl(); 
    Uydu u = new Uydu(); 
    Console.ReadLine();
}

# RFC = 14
