using System;
using System.Collections.Generic;
using System.Text;

namespace Abhimanbhau.CMPR.DGList
{
    public class Domain
    {
        public static List<string> getListOfDomains(string module, string branch)
        {
            List<string> domainList = new List<string>();
            if (branch == "COMP")
            {
                if (module == "III")
                {
                    domainList.Add("Data Structures");
                    domainList.Add("Principles of Prog. Lang.");
                    domainList.Add("Data Communication");
                    domainList.Add("ASP.NET");
                    domainList.Add("C#.NET");
                    domainList.Add("Applied Probability and Stats");
                }
                else if (module == "IV")
                {
                    domainList.Add("Digital Electronics");
                    domainList.Add("Microprocessor and Interfacing");
                    domainList.Add("Computer Organization");
                    domainList.Add("Python");
                    domainList.Add("VB.NET");
                    domainList.Add("Mathematical Transforms");
                }
            }
            return domainList;
        }
    }
}
