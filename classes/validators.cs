
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

        public static bool email(string email)
        {
            // 1 ta 32 char from 0-9A-Za-z_- and then @ and then 1 ta 8 char  from 0-9A-Za-z and then . and then 1ta 3 char from a-zA-Z

            foreach (var m in Regex.Matches(email, @"^([0-9A-Za-z_-]){1,32}@([0-9A-Za-z]){1,8}\.[a-zA-Z]{1,3}"))
            {


                if (m.ToString().Equals(email))
                {

                    return true;
                }
            }


            return false;
        }



        public static bool name(string name)
        {
            // 3 ta 32 char from A-Za-z 

            foreach (var m in Regex.Matches(name, "^[a-zA-Z]{3,32}"))
            {


                if (m.ToString().Equals(name))
                {

                    return true;
                }
            }


            return false;

        }


        public static bool datecard(string date_m, string date_d)
        {
            //calc now date time

            var now_date = DateTime.Now;


            //convert datecard_string to timestamp 
            var card_date = new DateTime(DateTime.Now.Year, int.Parse(date_m), int.Parse(date_d));


            //remin 3 month check
            if (Math.Abs((card_date - now_date).Days) < 90)
            {
                return false;

            }
            return true;

        }

        public static bool cvv(string cvv)
        {
            // 3 or 4 digit
            foreach (var m in Regex.Matches(cvv, "^[0-9]{3,4}"))
            {

                if (m.ToString().Equals(cvv))
                {

                    return true;
                }
            }


            return false;


        }

    }

}

