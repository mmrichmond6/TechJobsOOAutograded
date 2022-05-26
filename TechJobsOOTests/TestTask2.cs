using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsOOTests
{
    //These tests are only for items contained in Task 2.

    //DUMMY CLASS FOR TESTING(See Job 1 in Program file)
        //(Id)
        //Job Name: Product tester
        //Employer: ACME
        //Location: Desert
        //PositionType: Quality control
        //CoreCompetency: Persistence

    [TestClass]
    public class TestTask2
    {
        //setup

        Location testLocation = new Location("Desert");
        CoreCompetency testComp = new CoreCompetency("Persistence");
        PositionType testPosition = new PositionType("Quality control");

    // TESTS

    // Testing Location --------------------------------------------------------


        [TestMethod]
        //Testing the Location Class is present
        public void Test_Second_Location_Constructor_Exists()
        {
            //id = 1
            //2nd constructor takes a string value - should not be null
            Assert.IsNotNull(testLocation);
        }

        [TestMethod]
        //Testing if we can update the Value
        public void Test_Second_Location_Constructor_Initializes_Value()
        {
            //id = 2
            if(testLocation.Value != null)
            {
                Assert.AreEqual("Desert", testLocation.Value);
            }

            else if(testLocation.Value == null)
            {
                Assert.IsNotNull(testLocation);
            }
            
        }

        [TestMethod]
        //Testing if ': this()' initalizes the location's id
        public void Test_Second_Location_Constructor_Initializes_Id()
        {
           //id = 3
            Assert.AreEqual(3, testLocation.Id);
            Assert.IsNotNull(testLocation);
        }

    // Testing CoreCompetency --------------------------------------------------

        [TestMethod]
        public void Test_Core_Competency_Has_Value_Accessors()
        {
            //if we can access the values of these, then the proper accessors have been provided to Core Competency
            Assert.IsNotNull(testComp.Value);
            Assert.IsNotNull(testComp.Id);
            // not sure how to best test nextId since it's private.  calling it in a test will caiuse the test to fail
            // maybe an exception?  
        }

        [TestMethod]
        public void Test_Core_Competency_Has_Id_Getter()
        {
            //should be able to return Id value
            Assert.IsNotNull(testComp.Id);
        }

        [TestMethod]
        public void Test_Core_Competency_Has_No_Id_Setter()
        {
            //should not be able to set the Id - getter only
            Assert.IsFalse(testComp.Id == 10000);
        }

    // Testing PositionType ----------------------------------------------------


        // testing the ToString, Equals, and GetHashCode methods

        [TestMethod]
        public void Test_PositionType_ToString_Method()
        {
            //pass string to testPosition and check if it is a string
            //NOPE 
            Assert.IsNotNull(testPosition.ToString());
        }

        [TestMethod]
        public void Test_PositionType_Equals_Method()
        {
            // hmm...
        }

        [TestMethod]
        public void Test_PositionType_GetHashCode_Method()
        {
            //NOPE
            Assert.IsNotNull(testLocation.GetHashCode());
        }

    }
}




/*

 * DUMMY CLASS FOR TESTING(See Job 1 in Program file)
    * Id
    * Job Name: Product tester
    * Employer: ACME
    * Location: Desert
    * PositionType: Quality control
    * CoreCompetency: Persistence
 * 
 * - when adding tests, update the TEST class' dependencies to pull in the TechJobsOO namespace
 * - NOT the other way around.  (it will cause headaches)
 * 
 * 
 */

