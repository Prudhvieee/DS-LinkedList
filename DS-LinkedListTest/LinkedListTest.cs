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
        public void GivenThreeNumbersWhen_AddedShouldBeAddedToTop()
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
        public void GivenThreeNumbersWhenAppended_ShouldBeAddedToLast()
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
        public void GivenThreeNumbersWhenInsertingSecondInBetween_ShouldBeAddedInBetween()
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
        /// <summary>
        /// Ability to delete first number should return the remaining.
        /// </summary>
        [TestMethod]
        public void WhenDeleteFirstNumber_ShouldReturnRemaining()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Append(30);
            list.Append(70);
            Node head = list.Pop();
            ///Assert
            Assert.AreEqual(56, head.data);
        }
        /// <summary>
        /// Ability to delete last number should return the remaining.
        /// </summary>
        [TestMethod]
        public void WhenDeleteLastNumber_ShouldReturnRemaining()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Append(30);
            list.Append(70);
            Node last = list.PopLast();
            ///Assert
            Assert.AreEqual(70, last.data);
        }

    }
}
