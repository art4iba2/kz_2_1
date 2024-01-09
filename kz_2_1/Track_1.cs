using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace kz_2_1
{
    public class Track_1
    {
        public string TrackName;
        public string Track_id;
        public bool HasSnowMachine;
        public decimal[] AD;

        public static ArrayList GetTrackInfo()
        {
            ArrayList tracklist = new ArrayList();
            tracklist.Add(new Track_1 { TrackName = "bella", Track_id = "1", HasSnowMachine = true, AD = new decimal[] { 1.65m, 3m } });
            tracklist.Add(new Track_1 { TrackName = "Gella", Track_id = "1", HasSnowMachine = true, AD = new decimal[] { 1.65m, 3m } });
            tracklist.Add(new Track_1 { TrackName = "Yella", Track_id = "12", HasSnowMachine = true, AD = new decimal[] { 1.65m, 3m } });
            return tracklist;
        }
    }
}
