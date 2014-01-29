using System;
using System.Collections.Generic;
using System.Text;

namespace Abhimanbhau.CMPR.DivisionList
{
    public class Division
    {
        static List<char> feDivisionList = new List<char>();

        static List<char> chemicalDivisionList = new List<char>();
        static List<char> computerDivisionList = new List<char>();

        public static List<char> getDivisionList(string branch, string year)
        {
            if (year == "SE" || year == "TE" || year == "BE")
            {
                if (branch == "COMP")
                {
                    char div = 'C';
                    for (int i = 0; i < 6; ++i)
                    {
                        computerDivisionList.Add(div);
                        div++;
                    }
                    return computerDivisionList;
                }
                else if (branch == "CHEM")
                {
                    chemicalDivisionList.Add('A');
                    chemicalDivisionList.Add('B');
                    return chemicalDivisionList;
                }
            }
            else
            {
                char div = 'A';
                for (int i = 0; i < 16; ++i)
                {
                    feDivisionList.Add(div);
                    div++;
                }
                return feDivisionList;
            }
            return new List<char>();
        }
    }
}