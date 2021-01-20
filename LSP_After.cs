namespace LSP.After
{       
    public interface IUcabilir
    {
        public double UcmaMesafesi();        
    }
    public class Kus
    {        
        public int KanatAraligi { get; set; }
        public string LatinceAdi { get; set; }
       
    }

    public class Baykus : Kus, IUcabilir
    {
        public double UcmaMesafesi()
        {
            double ucmaMesafesiniHesapla = 1000;
            return ucmaMesafesiniHesapla;
        }
    }

    public class Penguen : Kus
    {        
        
    }

}