using System;
using System.Collections.Generic;
using System.Text;
using CSharp_006_Extensions.Enums;

namespace CSharp_006_Extensions.Models
{
    public class Word
    {
        public Word(string text,Language language)
        {
            Text = text;
            Language = language;

        }

        public string Text { get; set; }

        public Language Language { get; set; }

    }
}
