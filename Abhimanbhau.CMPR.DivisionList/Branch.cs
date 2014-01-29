using System;
using System.Collections.Generic;
using System.Text;

namespace Abhimanbhau.CMPR.DivisionList
{
    public class Branch
    {
        static List<string> branchList = new List<string>();

        public static List<string> getBranchList()
        {
            branchList.Add("CHEM");
            branchList.Add("COMP");
            branchList.Add("ELEX");
            branchList.Add("EXTC");
            branchList.Add("INDUS");
            branchList.Add("IT");
            branchList.Add("INSTRU");
            branchList.Add("PROD");
            branchList.Add("MECH");

            return branchList;
        }
    }
}
