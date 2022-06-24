using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class TestSettingJobId
    {

        [TestMethod]
        public void TestSettingJobIdTest()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue((job1.Id + 1) == job2.Id);
        }

    }
}
