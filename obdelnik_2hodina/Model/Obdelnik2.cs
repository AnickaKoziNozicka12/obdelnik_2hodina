namespace obdelnik_2hodina.Model
{
    public class Obdelnik2
    {
        private int stranaA;
        private int stranaB;

        public int StranaA
        {
            //get vrací hodnoty stranaA
            get => stranaA;
            set
            {
                if (stranaA != value)
                {
                    if (value >= 0)
                    {
                        stranaA = value;
                    }
                    else
                    {
                        stranaA = 0;
                    }
                }
                
            }
        }
        public int StranaB
        {
            get => stranaB;
            set
            {
                if (stranaB != value)
                {
                    if (value >= 0)
                    {
                        stranaB = value;
                    }
                    else
                    {
                        stranaB = 0;
                    }
                }
            }
        }
        
        //=> davame na jevo, ze ma pouze getter a ne setter
        public int Obvod => 2*(StranaA + StranaB);
        public int Obsah => StranaA * StranaB;
        public double Uhlopricka => Math.Sqrt(StranaA * StranaA) + Math.Pow(StranaB, 2);
    }
}
