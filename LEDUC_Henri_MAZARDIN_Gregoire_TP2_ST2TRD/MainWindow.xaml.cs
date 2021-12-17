using System;
using System.IO.Packaging;
using System.Windows;

namespace LEDUC_Henri_MAZARDIN_Gregoire_TP2_ST2TRD
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_Execute(object sender, RoutedEventArgs e)
        {
            try
            {
                var toDecrypt = Check.IsChecked ?? false;
                var inputText = Input.Text;
                var keyText = Key.Text;
                var encryptionmethod = EncryptionComboBox.Text;

                if (toDecrypt)
                {
                    if (encryptionmethod == "Caesar")
                    {
                        Output.Text = Caesar.Decrypt(inputText, Int32.Parse(keyText)%26);
                    }

                    if (encryptionmethod == "XOR")
                    {
                        Output.Text = XOR.XORCipher(inputText, keyText);
                    }
                    if (encryptionmethod == "Vigénère")
                    {
                        Output.Text = Vigenere.Decrypt(inputText, keyText);
                    }
                }
                else
                {
                    if (encryptionmethod == "Caesar")
                    {
                        Output.Text = Caesar.Encrypt(inputText, Int32.Parse(keyText)%26);
                    }

                    if (encryptionmethod == "XOR")
                    {
                        Output.Text = XOR.XORCipher(inputText, keyText);
                    }
                    if (encryptionmethod == "Vigénère")
                    {
                        Output.Text = Vigenere.Encrypt(inputText, keyText);
                    }
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
    
}