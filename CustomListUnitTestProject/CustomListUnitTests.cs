using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListRound2;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class CustomListUnitTests
    {
   

        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToZeroIndex()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 1;
            int expected = 1;
            int actual;

            //Act
            testList.Add(item);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 1;
            int expected = 1;
            int actual;

            //Act
            testList.Add(item);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        // what if i .Add to a list that has a couple things in it already (position of item)?
        [TestMethod]
        public void Add_AddItemToList_ItemAddedToEndOfList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actual = testList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // what if i .Add to a list that has a couple things in it already (value of Count)?
        [TestMethod]
        public void Add_AddMultipleItemsToList_CountMatchesNumberOfItems()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            int expected = 3;
            int actual;

            //Act
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Add 3 items
        [TestMethod]
        public void Add_AddItemsToList_OverFourItemsAddedToList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //Act
            testList.Add(5);
            testList.Add(7);
            testList.Add(9);
            testList.Add(8);
            testList.Add(3);

            actual = testList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // how does the Capacity change as you add things? (starts at 4, and doubles)
        
        // REMOVE TESTS:

        [TestMethod]
        public void Remove_RemoveItemFromList_ItemRemovedFromFirstInstance()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            testList.Add(250);
            testList.Add(150);
            testList.Add(250);
            testList.Remove(250);

            actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_ItemRemovedFromIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 150;
            int actual;

            //Act
            testList.Add(250);
            testList.Add(150);

            testList.Remove(250);

            actual = testList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Remove at the 1 index after removed
        [TestMethod]
        public void Remove_RemoveItemFromList_ItemRemovedFromIndexOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 250;
            int actual;

            //Act
            testList.Add(250);
            testList.Add(150);
            testList.Add(250);
            testList.Remove(250);

            actual = testList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Make a test to check a bool
        //if it finds something to remove return true
        //vicce versa
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckBoolTrueIfRemovableIsFound()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            actual = testList.Remove(3);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_CheckBoolFalseIfRemovableIsNotFound()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;

            //Act
            testList.Add(1);
            testList.Add(2);

            actual = testList.Remove(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        ////To String Test
      
        [TestMethod]
        public void ToString_ConvertToString_ConvertThreeIntsToToString()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = ("123");
            string actual;
            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            actual = testList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertToString_ConvertDoubleToToString()
        {
            //arrange
            CustomList<double> testList = new CustomList<double>();
            string expected = "10.20";
            double actual;

            //act
            testList.Add(10.20);

            actual = testList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertBoolToString_ConvertTrueToToString()
        {
            //arrange
            CustomList<bool> testList = new CustomList<bool>();
            string expected = ("true");
            string actual;
            //act
            testList.Add(true);

            actual = testList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
