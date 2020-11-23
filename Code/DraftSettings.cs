using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskBallDB
{
    class DraftSettings
    {
        public int DraftSettingsID { get; set; }
        public string DraftOrder { get; set; }
        public string DraftDate{ get; set; }
        public string LeagueName{ get; set; }
        public int UserID { get; set; }
    }
}
