using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NRTracker.Models;
using NRTrackerDomain.Entities;

namespace NTrackerTest
{
    [TestClass]
    public class UnitTest1
    {
        private Staff staff;
        private Unit unit;

        public UnitTest1()
        {
            unit = new Unit
            {
                Id = 1
            };

            staff = new Staff();
            staff.Id = 1;

            staff.Unit = unit;
        }

        [TestMethod]
        public void InitialStateIsCorrect()
        {
            Document doc = Document.Create(staff, "subject 1");
            doc.Id = 1;
            Assert.IsTrue(doc.LastTransfer.DestinationId == unit.Id);
        }
    }
}
