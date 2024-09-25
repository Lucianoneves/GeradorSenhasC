using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geradorSenhasC
{
    internal class GeradorSenhas
    {
        public int Length { get; set; }
        public bool IncludeUppercase { get; set; }
        public bool IncludeLowercase { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeSymbols { get; set; }

        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string NumberChars = "0123456789";
        private const string SymbolChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";

        public GeradorSenhas(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
        {
            Length = length;
            IncludeUppercase = includeUppercase;
            IncludeLowercase = includeLowercase;
            IncludeNumbers = includeNumbers;
            IncludeSymbols = includeSymbols;
        }

        public string GeneratePassword()
        {
            StringBuilder charSet = new StringBuilder();

            if (IncludeUppercase)
                charSet.Append(UppercaseChars);
            if (IncludeLowercase)
                charSet.Append(LowercaseChars);
            if (IncludeNumbers)
                charSet.Append(NumberChars);
            if (IncludeSymbols)
                charSet.Append(SymbolChars);

            if (charSet.Length == 0)
                return string.Empty;

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }
    }
}
