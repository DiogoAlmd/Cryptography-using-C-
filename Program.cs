using System;
using System.Text;


namespace testeCriptoConsole
{
    class Program
    {
        static void Main(string[] args) {
            
            string wordToBeCrypted = "teste";
            
            //encrypting
            var byteArray = Encoding.ASCII.GetBytes(wordToBeCrypted);
            var wordCrypted = Convert.ToBase64String(byteArray);
            Console.WriteLine(wordCrypted);

            //decrypting
            var wordToBeDecrypted = "dGVzdGU=";
            var dadosAsBytes = System.Convert.FromBase64String(wordToBeDecrypted);
            var wordDecrypted = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
            Console.WriteLine(wordDecrypted);
        }
    }
}
