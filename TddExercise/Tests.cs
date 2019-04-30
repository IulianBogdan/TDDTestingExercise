using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static TddExercise.Exceptions;

namespace TddExercise
{
    /// <summary>
    /// tdd test class
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Will test the constructor
        /// </summary>
        [Test]
        public void Create()
        {
            MyStack<int> stack = new MyStack<int>(3);
            Assert.AreEqual(0, stack.Size);
        }

        /// <summary>
        /// Will test if the provided value is removed from the stack
        /// </summary>
        [Test]
        public void Add_Remove()
        {
            MyStack<int> stack = new MyStack<int>(3);

            stack.Add(1);
            stack.Add(2);
            stack.Add(3);

            int removedValue = stack.Remove();

            Assert.AreEqual(3, removedValue);
            Assert.AreEqual(2, stack.Size);
        }

        /// <summary>
        /// Will test if the method throws exception if we try to remove an element from an empty list
        /// </summary>
        [Test]
        public void Handle_Remove_Limit()
        {
            MyStack<int> stack = new MyStack<int>(3);
            Assert.Throws<CustomException>(() => stack.Remove());
        }

        /// <summary>
        /// Will test if the method throws exception if we try to add an element over the limit of the stack
        /// </summary>
        [Test]
        public void Handle_Stack_Overflow()
        {
            var stack = new MyStack<int>(3);
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            Assert.Throws<MyStackOverflowException>(() => stack.Add(4));
        }

        /// <summary>
        /// Will test if the method returns the right value
        /// </summary>
        [Test]
        public void Get_Last_Element()
        {
            var stack = new MyStack<int>(3);

            stack.Add(1);
            stack.Add(2);

            int lastValue = stack.GetLastElement();

            Assert.AreEqual(2, lastValue);
        }

        /// <summary>
        /// Will test if the method throws an exception if we want to return the last value from an empty stack
        /// </summary>
        [Test]
        public void Get_Last_Element_Exception()
        {
            var mystack = new MyStack<int>(3);

            Assert.Throws<CustomException>(() => mystack.GetLastElement());
        }
    }
}
