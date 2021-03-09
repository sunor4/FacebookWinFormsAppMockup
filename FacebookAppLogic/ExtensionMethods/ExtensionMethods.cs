
using System;

namespace FacebookAppLogic.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static DateTime BirthdayToDateTime (this string i_BirthdayString)
        {
            DateTime result = new DateTime();
            if (i_BirthdayString != null)
            {
                string[] birthdayStringSplit = i_BirthdayString.Split('/');
                if (birthdayStringSplit.Length == 3)
                {
                    int[] birthdayIntSplit = Array.ConvertAll(birthdayStringSplit, int.Parse);
                    result = new DateTime(birthdayIntSplit[2], birthdayIntSplit[0], birthdayIntSplit[1]);
                }
            }

            return result;
        }
    }
}
