namespace LSP.Before
{       
    public class Kus
    {
        public int KanatAraligi { get; set; }
        public string LatinceAdi { get; set; }
        
        public virtual double UcmaMesafesi()
        {
            double ucmaMesafesiniHesapla = 0;
            return ucmaMesafesiniHesapla;
        }        
    }

    public class Penguen : Kus
    {        
        public override double UcmaMesafesi()
        {
            throw new System.NotImplementedException();
        }
    }

}