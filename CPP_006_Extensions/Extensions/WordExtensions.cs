using System;
using System.Collections.Generic;
using System.Text;
using CSharp_006_Extensions.Enums;
using CSharp_006_Extensions.Models;

namespace CSharp_006_Extensions.Extensions
{
    //Classes Extensions sempre serao PUBLIC STATIC
    public static class WordExtensions
    {
        public static string ToEnglish(this Word word)
        {
            string newWord = "";

            if (word.Language == Language.Portuguese && word.Text == "Olá")
                newWord = "Hello";
            else if (word.Language == Language.Spanish && word.Text == "Hasta Luego")
                newWord = "See you later";

            return newWord;
        }

        public static Word ToWordEnglish(this Word word)
        {
            if (word.Language == Language.Portuguese && word.Text == "Olá")
                return new Word("Hello",Language.English);
            else if (word.Language == Language.Spanish && word.Text == "Hasta Luego")
                return new Word("See you later", Language.English);

            return null;
        }

        public static string ToSpanish(this Word word, bool bForce)
        {
            return "QQB";
        }
    }
}
