using CH_CARS.BL;
using System.Collections.Generic;

namespace CH_CARS.DL
{
    internal class CarDL
    {
        public static bool IntegerValidation(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool AlphabetValidation(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                if (!char.IsUpper(character) && !char.IsLower(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}