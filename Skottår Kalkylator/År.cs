namespace Skottår_Kalkylator
{
    public class År
    {
        public static bool ÄrSkottår(int år)
        {
            if(år % 400 == 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ÄrInteSkottår(int år)
        {
            if(år % 100 == 0 && år % 400 !=0)
            {
             return true;

            }else
            {
                return false;
            }
        }

        public static bool ÄrSkottårMenDelatPå4(int år)
        {
            // Om åren är delat på 4 men inte hundra så är det skottår.
            if(år % 4 == 0 && år % 100 != 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool AllaÅrSomInteGårAttDelaMed4(int år)
        {
            if(år % 4 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }


    }
}