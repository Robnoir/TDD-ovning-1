namespace Skottår_Kalkylator
{
    public class År
    {
        public static bool ÄrSkottår(int år)
        {
            if((år % 4 == 0 && år % 100 !=0) || (år % 400 == 0) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}