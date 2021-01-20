namespace OCP.Before
{
    class Kare
    {
        public int kenar { get; set; }
        public Kare(int kenari)
        {
            kenar = kenari;
        }
    }

    class Daire
    {
        public int yaricap { get; set; }
        public Daire(int yaricapi)
        {
            yaricap = yaricapi;
        }
    }

    class AlanToplamiHesaplama
    {
        public double AlanToplamlari(object[] sekiller)
        {
            double alanToplami = 0;

            foreach (object sekil in sekiller)
            {
                if (sekil is Kare)
                {
                    alanToplami += System.Math.Pow(((Kare)sekil).kenar, 2);
                }
                else if (sekil is Daire)
                {
                    alanToplami += 3.14 * System.Math.Pow(((Daire)sekil).yaricap, 2);
                }
            }

            return alanToplami;
        }
    }

}