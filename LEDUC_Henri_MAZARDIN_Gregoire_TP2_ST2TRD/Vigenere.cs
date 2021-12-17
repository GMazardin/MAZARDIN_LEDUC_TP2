namespace LEDUC_Henri_MAZARDIN_Gregoire_TP2_ST2TRD
{
    public class Vigenere
    {
        
        private static string Code(string input, string key, bool encrypt)
        {
            foreach(char ch in key)
                if (!char.IsLetter(ch))
                    return null; // Error

            string output = string.Empty;
            int nonRegularCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool chIsUpper = char.IsUpper(input[i]);
                    char offset = chIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonRegularCharCount) % key.Length;
                    int k = (chIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encrypt ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonRegularCharCount;
                }
            }

            return output;
        }
        
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        public static string Encrypt(string input, string key)
        {
            return Code(input, key, true);
        }

        public static string Decrypt(string input, string key)
        {
            return Code(input, key, false);
        }
    }
}