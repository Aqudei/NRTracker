using System;
using System.Collections.Generic;
using System.Text;

namespace NRTrackerDomain.Entities
{
    public class Transfer
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public int StaffId { get; set; }
    }
}
