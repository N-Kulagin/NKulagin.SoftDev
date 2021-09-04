using NKulagin.SoftDev.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NKulagin.SoftDev.SoftDevTests
{
    public class PeopleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPay()
        {
            // 10000 + 11000 + 8750
            Manager manager = new Manager("test", new List<TimeRecord>() {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test", 9, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test", 7, "test message"),
            });

            Assert.IsTrue(manager.TotalPay == 29750);
        }
    }
}