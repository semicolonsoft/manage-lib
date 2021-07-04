
using System;
using System.Text.RegularExpressions;


namespace LIBRARY.classes
{
    class validator
    {

        public static bool card(string card)
        {
            int[] digits = new int[card.Length];

            for (int i = 0; i < (int)card.Length; i++)
            {
                digits[i] = int.Parse(card[i].ToString());
            }


            int sumodd = 0;
            for (int i = (int)card.Length - 1; i > 0; i -= 2)
            {


                sumodd += digits[i];
            }


            for (int i = (int)card.Length - 2; i >= 0; i -= 2)
            {


                if (2 * digits[i] >= 10)
                {
                    sumodd += 2 * digits[i] / 10 + 2 * digits[i] % 10;
                }
                else
                {
                    sumodd += 2 * digits[i];

                }

            }




            if (sumodd % 10 == 0)
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

