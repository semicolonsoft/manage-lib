
using System;
using System.Text.RegularExpressions;


namespace LIBRARY.classes
{
    class validator
    {

        public static bool card(string card)
        {
            // split digit and convert to int
            int[] digits = new int[card.Length];

            for (int i = 0; i < (int)card.Length; i++)
            {
                digits[i] = int.Parse(card[i].ToString());
            }

            /// calc sum of 0,2,4,6,... digits
            int sumodd = 0;
            for (int i = (int)card.Length - 1; i > 0; i -= 2)
            {


                sumodd += digits[i];
            }

            ////add sum of 1,3,5,7,... to last sum
            for (int i = (int)card.Length - 2; i >= 0; i -= 2)
            {

                // check bigger than 10
                if (2 * digits[i] >= 10)
                {
                    sumodd += 2 * digits[i] / 10 + 2 * digits[i] % 10;
                }
                else
                {
                    sumodd += 2 * digits[i];

                }

            }



            //check a multiple of 10
            if (sumodd % 10 == 0)
            {
                return true;

            }

            else
            {
                return false;
            }
        }

        public static bool phone(string phone)
        {
            /// start with 09 and 9 digit past
            foreach (var m in Regex.Matches(phone, "^09[0-9]{9}"))
            {


                if (m.ToString().Equals(phone))
                {

                    return true;
                }
            }


            return false;
        }

    }

}

