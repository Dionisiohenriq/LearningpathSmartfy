using System;
using CSharp_006_Extensions.Enums;
using CSharp_006_Extensions.Extensions;
using CSharp_006_Extensions.Models;

namespace CPP_006_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Word wordOla = new Word("Olá",Language.Portuguese);
            Word wordBye = new Word("Bye",Language.English);
            Word wordHastaLuego = new Word("Hasta Luego",Language.Spanish);

            //string minhaidade = "32";
            //int suaidade = Convert.ToInt32(minhaidade);
            //int numero = 31;
            //string idade = numero.ToString();

            var olaEmIngles = wordOla.ToEnglish();
            Console.WriteLine($"Word: {wordOla.Text} em Ingles: {olaEmIngles}");

            var hastaEmIngles = wordHastaLuego.ToEnglish();
            Console.WriteLine($"Word: {wordHastaLuego.Text} em Ingles: {hastaEmIngles}");

            var hastWordEnglish = wordHastaLuego.ToWordEnglish();
            string pqp = hastWordEnglish.Text;

        }
    }
}

