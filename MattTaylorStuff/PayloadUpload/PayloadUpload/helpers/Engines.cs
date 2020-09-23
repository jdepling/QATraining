using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayloadUpload.helpers
{
    class Engines
    {
        public const string Daily = "https://daily.conformx.com/cxws/enginews.asmx";
        public const string QA = "https://qa.conformx.com/cxws/EngineWS.asmx";
        public const string RC = "https://rc.conformx.com/cxws/enginews.asmx";
        public const string CRDaily = "https://idfn-1.conformx.com/crDailyWS/EngineWS.asmx";
        public const string Consumer = "https://idfn-1.conformx.com/consumerws/enginews.asmx";
        public const string Consumer3 = "https://idfn-1.conformx.com/consumerws3/enginews.asmx";
    }
}
