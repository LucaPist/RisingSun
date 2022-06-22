using System.Text.RegularExpressions;

namespace WebAPI_Sample2.Helper
{
     public static class PhoneNumber
        {
            // Regular expression used to validate a phone number.
            public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            public static bool IsPhoneNbr(this string number)
            {
                if (number != null) return Regex.IsMatch(number, motif);
                else return false;
            }
        
    }


}
