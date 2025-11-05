using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public class LanguageDetecter
    {
        public char WhatLanguageIs(string sentence)
        {
            if (sentence.Contains("-") && sentence.Contains(".") && sentence.Contains(" "))
            {
                return 'M';
            }
            return 'N';
        }
    }
}
