using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Printing_and_Engraving_Site.DataContracts
{
    [DataContract]
    public class orderDetailsData
    {
        [DataMember]
        public int ItemID { get; set; }

        [DataMember]
        public long ItemCode { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string ItemDescription { get; set; }

        [DataMember]
        public double ItemPrice { get; set; }
    }
}