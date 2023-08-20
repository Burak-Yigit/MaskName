using System;

namespace MaskName
{
    public class PersonManager
    {
        public bool CheckCharacter(string word)
        {
            if (word.Length >= 2)
            {
                bool characterCheck = false;
                for (int i = 0; i < word.Length; i++)
                {
                    characterCheck = char.IsLetter(word[i]);
                    if (characterCheck == false)
                    {
                        Console.WriteLine("Enter letters only");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public string MaskName(string word)
        {
            string firstThreeChars = word.Substring(0, 1);
            string remainingChars = new string('*', word.Length - 1);

            return firstThreeChars + remainingChars;
        }
    }
}