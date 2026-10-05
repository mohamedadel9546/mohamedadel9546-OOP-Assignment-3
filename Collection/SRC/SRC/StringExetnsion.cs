using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SRC;

public static class StringExetnsion
{
    extension(string Value)
    {
        public  bool IsValidEgyptianPhone()
        {

            if (string.IsNullOrWhiteSpace(Value))
                return false;

            return Regex.IsMatch(Value, @"^(?:\+201|01)[0125]\d{8}$");
        }

        public  bool IsValidEgyptianNationalId()
        {
            if (string.IsNullOrWhiteSpace(Value))
                return false;
            if (Value[0] != '2' && Value[0] != '3')
                return false;
            if (Value.Length != 14)
                return false;
            return Regex.IsMatch(Value, @"^[23]\d{13}$");
        }

    }
}
