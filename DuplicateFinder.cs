using System;
using System.Linq;

namespace FindDuplicateInAString
{
    public class DuplicateFinder
    {
        public static bool FindDuplicate(string[] stringArray)
        {
            Array.Sort(stringArray);
            bool IsDublicatesAvailable = false;
            for (int i = 0; i <= stringArray.Length - 2; i++)
            {
                if (stringArray[i] == stringArray[i + 1])
                {
                    IsDublicatesAvailable = true;

                }
                else
                {
                    IsDublicatesAvailable = false;
                }
            }
            return IsDublicatesAvailable;

        }


        public static bool FindDuplicateUsingCharArray(string str)
        {
            bool IsDublicatesAvailable = false;
            var countCollection = str.ToCharArray().GroupBy(r => r)
                                    .Select(s => new
                                    {
                                        Count = s.Count(),
                                    });
            foreach (var item in countCollection)
            {
                if (item.Count > 1)
                {
                    IsDublicatesAvailable = true;
                }
            }
            return IsDublicatesAvailable;

        }

        public static bool FindDuplicateUsingForLoops(string str)
        {
            bool IsDublicatesAvailable = false;
            for (int i = 0; i < str.Length; i++)
            {

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        IsDublicatesAvailable = true;
                    }
                }
            }
            return IsDublicatesAvailable;

        }

        public static bool FindDuplicateUsingDistinct(string str)
        {
            bool IsDublicatesAvailable = false;
            if (str.Distinct().ToArray().Length == str.Length)
                IsDublicatesAvailable = true;
            return IsDublicatesAvailable;

        }
    }
}
