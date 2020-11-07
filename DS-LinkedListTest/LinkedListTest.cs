using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_LinkedList;
namespace DS_LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {
        /// <summary>
        /// Able to add numbers to linkedlist
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_When_Added_ShouldBeAddedToTop()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Add(30);
            list.Add(70);
            ///Assert
            Assert.AreEqual(56, list.head.data);
        }
        /// <summary>
        /// Able to append the numbers
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_When_Appended_ShouldBeAddedToLast()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Append(56);
            list.Append(30);
            list.Append(70);
            ///Assert
            Assert.AreEqual(56, list.head.data);
        }
        /// <summary>
        /// able to insert the value at particular position
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenInsertingSecondInBetween_ShouldBeAddedInBetween()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            ///Assert
            Assert.AreEqual(30, list.head.next.data);
        }
    }
}
