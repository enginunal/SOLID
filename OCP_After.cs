namespace OCP.After
{
    abstract class Sekil
    {
        public abstract double Alan();
    }

    class Kare : Sekil
    {
        public int kenar { get; set; }
        public Kare(int kenari)
        {
            kenar = kenari;
        }
        public override double Alan()
        {
            return System.Math.Pow(kenar, 2);
        }
    }

    class Daire : Sekil
    {
        public int yaricap { get; set; }
        public Daire(int yaricapi)
        {
            yaricap = yaricapi;
        }
        public override double Alan()
        {
            return 3.14 * System.Math.Pow(yaricap, 2);
        }
    }

    class AlanToplamiHesaplama
    {
        public double AlanToplamlari(Sekil[] sekiller)
        {
            double alanToplami = 0;

            foreach (Sekil sekil in sekiller)
                alanToplami += sekil.Alan();

            return alanToplami;
        }
    }




}