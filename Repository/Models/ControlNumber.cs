using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class ControlNumber
    {
        public static bool CheckCattleControlDigit(string animalID)
        {
            const int NumberLenght = 14;
            bool isCorrect = false;
            int controlDigit;         

            if (animalID.Length != NumberLenght)
            {
                return false;
            }

            int[] wagi = { 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };
            string s = animalID.Substring(2, 11);   //ignorujemy dwa pierwsze znaki cyfry kontrolnej (PL)

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //wyliczamy wg. algorytmu ARiMR 
                count = count + (int)Char.GetNumericValue(s[i]) * wagi[i];

            }
            int moduloCount = count % 10;
            controlDigit = 10 - moduloCount;
            if (int.Parse(animalID.Substring(13)) == controlDigit)
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        public static bool CheckHertControlDigit(string herdID)
        {
            const int herdIdNumberLenght = 9;
            int oddSum = 0;
            int evenSum = 0;
            int evenCount = 0;
            int specifiedControlNumber = (int)Char.GetNumericValue(herdID[herdIdNumberLenght - 1]);
            int calculateControlNumber = -1;

            if (herdID.Length != herdIdNumberLenght)
            {
                return false;
            }

            for (int i = 0; i < herdIdNumberLenght - 1; i++)
            {
                int temp = (int)Char.GetNumericValue(herdID[i]);

                if (temp % 2 == 0)
                {
                    evenSum += temp;
                    evenCount++;
                }
                else
                {
                    oddSum += temp;
                }
            }
            //algorytm ARiMR do wyliczania cyfry kontrolnej siedziby stada
            calculateControlNumber = (23 * evenSum + 17 * oddSum + evenCount) % 7;

            if (calculateControlNumber == specifiedControlNumber)
                return true;
            else
                return false;

        }

    }
}