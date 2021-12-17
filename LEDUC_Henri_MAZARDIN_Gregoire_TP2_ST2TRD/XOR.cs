namespace LEDUC_Henri_MAZARDIN_Gregoire_TP2_ST2TRD
{
    public class XOR
    {
        public static string XORCipher(string input, string key)
        {
            int inputLen = input.Length;
            int keyLen = key.Length;
            char[] output = new char[inputLen];

            for (int i = 0; i < inputLen; ++i)
            {
                output[i] = (char)(input[i] ^ key[i % keyLen]);
            }

            return new string(output);
        }
    }
}