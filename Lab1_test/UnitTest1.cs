using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_project;

namespace Lab1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*
         Stack has value in head, value is copied to the variable
         */
        public void CopyTo_NormalCopying_CopiesHeadToVariable()
        {
            //Arrange
            Stack st1 = new Stack(new int[] { 7, 4, 3 });
            int expected = 7;
            //Act
            st1.CopyTo(out int actual);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /*
         Stack does not have value in head, throws Exception
         */
        public void CopyTo_InvalidCopying_NoHead_ThrowException()
        {
            //Arrange
            Stack st1 = new Stack();
            
            //Act and Assert
            Assert.ThrowsException<System.Exception>(() => st1.CopyTo(out int _));
        }

        [TestMethod]
        /*
         Stack has value in head, value is excracted to the variable
         */
        public void ExtractTo_NormalExtracting_ExtractsHeadToVariable()
        {
            //Arrange
            Stack st1 = new Stack(new int[] { 7, 4, 3 });
            int expected = 7;
            //Act
            st1.ExtractTo(out int actual);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /*
         Stack has value in head, head is extracted out of stack
         */
        public void ExtractTo_NormalExtracting_ExtractsHeadOutOfStack()
        {
            //Arrange
            Stack expected = new Stack(new int[] { 4, 3 });
            Stack actual = new Stack(new int[] { 7, 4, 3 });
            //Act
            actual.ExtractTo(out _);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /*
         Stack does not have value in head, throws Exception
         */
        public void ExtractTo_InvalidExtracting_NoHead_ThrowException()
        {
            //Arrange
            Stack st1 = new Stack();
           
            //Act and Assert
            Assert.ThrowsException<System.Exception>(() => st1.ExtractTo(out _));
        }

        [TestMethod]
        /*
         Value is normally added to the stack
         */
        public void Add_NormalAdding_AddsValueToStack()
        {
            //Arrange
            Stack expected = new Stack(new int[]{ 5, 7, 4, 3 });
            Stack actual = new Stack(new int[] { 7, 4, 3 });
            //Act
            actual.Add(5);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
