using System;
using System.Collections.Generic;
using System.Text;

namespace Abhimanbhau.CMPR.DGList
{
    public class Guide
    {
        List<string> cSharpGuides = new List<string>();
        public Guide()
        {
            // Let's add guides with respective domains

            // C#
            cSharpGuides.Add("S. M. Khatri");
        }

        public List<string> GetListOfGuides(string module)
        {
            switch (module)
            {
                case "C#.NET":
                    return cSharpGuides;
            }
            // blank for now
            return new List<string>();
        }
    }
}
