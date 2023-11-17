namespace Skottår_Kalkylator
{
    public class År
    {
        public static bool ÄrSkottår(int år)
        {
            return (år % 4 == 0 && år % 100 !=0) || (år % 400 == 0);
          
        }
        
        public static int FåDagsNummer(DateTime dag)
        {
            return dag.DayOfYear;
        }


    }
}