using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorology
{
    public class MeteoDatasRecord
    {
        public string UniqueRecordNumber = "0000-00-00-00-00-00-000-00000000000000000000000";
        public DateTime DateAndTime = new DateTime();
        public float TemperatureCelsiusDegrees = 0.0f;
        public string MeteoConditions = "";
        public string MeteoWarningMessage = "";
        public string Latitude = "";
        public string Longitude = "";
        public string Country = "";
        public string Language = "";
        public bool InPast = false;

        public MeteoDatasRecord() { }
        public MeteoDatasRecord(string uniqueRN, DateTime dt, float TCS, string mc, string mwm, string lat, string lon, string cn, string la, bool p)
        {
            UniqueRecordNumber = uniqueRN;
            DateAndTime = dt;
            TemperatureCelsiusDegrees = TCS;
            MeteoConditions = mc;
            MeteoWarningMessage = mwm;
            Latitude = lat;
            Longitude = lon;
            Country = cn;
            Language = la;
            InPast = p;
        }

    }
}
