using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BannoUI
{
    class CharStat
    {
        private char[] character { get; set; }
        
        
        public CharStat(char[] charList)
        {
            character = charList;  
        }
        //get length
        public int CharStatLength()
        {
            return character.Length;
        }
        //trim all duplicates
        public char[] DuplicateTrim()
        {
            char[] distCharArray = character.Distinct().ToArray();
            return distCharArray;
        }
        //show length of trimemed array
        public int DuplicatedTrimLength()
        {
            char[] distCharArray = character.Distinct().ToArray();
            return distCharArray.Length;
        }
        //show the duplicated count of each alphanum
        public int[] DuplicateArrayCount()
        {
            int arrayCount = 0;
            char[] trimList = new char[DuplicatedTrimLength()];
            int[] countNumArray = new int[DuplicatedTrimLength()];
            trimList = DuplicateTrim();
            foreach (char element in trimList)
            {
                foreach (char copy in character)
                {
                    if (copy == element)
                    {
                        countNumArray[arrayCount]++;
                    }

                }
                arrayCount++;
            }
            return countNumArray;

        }
        //Sort both the counts and alphanums together in descending
        public int[] CountStatSort()
        {
            int[] duplicateCountArray = DuplicateArrayCount();
            char[] duplicateTrimArray = DuplicateTrim();
            Array.Sort(duplicateCountArray,duplicateTrimArray );
            Array.Reverse(duplicateCountArray);
            return duplicateCountArray;
        }
        public char[] DuplicateStatSort()
        {
            int[] duplicateCountArray = DuplicateArrayCount();
            char[] duplicateTrimArray = DuplicateTrim();
            Array.Sort(duplicateCountArray, duplicateTrimArray);
            Array.Reverse(duplicateTrimArray);
            return duplicateTrimArray;
        }


    }
}
