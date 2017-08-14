using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NRTrackerDomain.Entities
{
    public class Document
    {
        public Staff Owner;

        public int Id { get; set; }
        protected virtual ICollection<Transfer> Transfers { get; set; }

        //ignore
        public Transfer LastTransfer
        {
            get
            {
                return Transfers.Last();
            }
        }

        public string Subject { get; private set; }

        public Document()
        {
            Transfers = new List<Transfer>();
        }

        public static Document Create(Staff staff, string subject)
        {
            Document doc = new Document();
            doc.Owner = staff;
            doc.Subject = subject;
            doc.Transfers.Add(new Transfer
            {
                DestinationId = staff.Unit.Id,
                StaffId = staff.Id

            });
            return doc;
        }

        public void Endorse(string comment="")
        {

        }

        public void Return(string comment = "")
        {

        }

        public void Hold(string comment = "")
        {

        }

        public void Reject(string comment = "")
        {

        }
    }
}
