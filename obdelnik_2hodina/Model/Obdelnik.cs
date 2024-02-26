namespace obdelnik_2hodina.Model
{
    public class Obdelnik //staci zadat vlatnost jakjo prop (jako Property) a stisk tab
    {
        //pro zadani klanych cisel muzeme pouzivat uint
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        
        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }

        //metody
        public void SpoctiObvod()
        {
            Obvod = 2*(StranaA+StranaB);
        }
        public void SpoctiObsah()
        {
            Obsah = StranaA * StranaB;
        }
        public void SpoctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(StranaA*StranaA) + Math.Pow(StranaB,2);
        }

        public void Vypocet()
        {
            SpoctiObsah();
            SpoctiObvod();
            SpoctiUhlopricku();
        }
    }
}
