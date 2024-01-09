using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kz_2_1
{
    public class SkiResort
    {
        public string ResortName;
        public string TrackId;
        public bool ForSki;

        public static ArrayList GetselfArrayList()
        {
            ArrayList data = new ArrayList();
            data.Add(new SkiResort { ResortName = "Rosa", ForSki = true, TrackId = "1" });
            return data;
        }
    }
}
