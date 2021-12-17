using System;
using System.Windows;

namespace LEDUC_Henri_MAZARDIN_Gregoire_TP2_ST2TRD
{
    public class Caesar
    {
        private static char Code(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;
            try
            {
                foreach (char ch in input)
                    output += Code(ch, key);
            }
            catch (Exception e)
            {
                MessageBox.Show("Enter an integer as a key to use Caesar encryption");
            }
            return output;
        }

        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }
    }
}