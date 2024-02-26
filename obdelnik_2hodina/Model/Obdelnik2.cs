namespace obdelnik_2hodina.Model
{
    public class Obdelnik2
    {
        private int stranaA;
        private int stranaB;

        public int StranaA
        {
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
            get => stranaB; set
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

        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }
    }
}
