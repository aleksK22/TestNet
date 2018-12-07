using System;
using System.Diagnostics.Eventing.Reader;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTest
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Count_WhenEmptyList_ShouldBeZero()
        {
            //Arrange
            var stack = new Stack<string>();

            //Act
            var count=stack.Count;
            
            //Assert
            Assert.That(count,Is.EqualTo(0));

        }
        
        [Test]
        public void Push_WhenObjectIsNull_ReturnsException()
        {
            //Arrange
            var stack = new Stack<string>();

            //Assert
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);

        }
        
        [Test]
        public void Push_WhenObjectIsNotNull_CountShouldBeGreaterByOne()
        {
            //Arrange
            var stack = new Stack<string>();
            var countPlusOne = stack.Count+1;

            //Act
            stack.Push("one");            
            var countGreaterByOne=stack.Count;

            //Assert
            Assert.That(countGreaterByOne,Is.EqualTo(countPlusOne));

        }
        
        [Test]
        public void Pop_WhenListIsEmpty_ReturnsException()
        {
            //Arrange
            var stack = new Stack<string>();

            //Assert
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);

        }
        
        [Test]
        public void Pop_WhenListIsNotEmpty_CountShouldBeSmallerByOneAfterPop()
        {
            //Arrange
            var stack = new Stack<string>();
            stack.Push("one");
            var countListMinusOne = stack.Count-1;

            //Act
            var result=stack.Pop();
            var countAfterPop=stack.Count;

            //Assert
            Assert.That(countListMinusOne,Is.EqualTo(countAfterPop));

        }
        
        [Test]
        public void Pop_WhenListIsNotEmpty_ShouldReturnLast()
        {
            //Arrange
            var stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");

            //Act
            var result=stack.Pop();

            //Assert
            Assert.That(result,Is.EqualTo("two"));

        }
        
        
        [Test]
        public void Peek_WhenListIsEmpty_ReturnsException()
        {
            //Arrange
            var stack = new Stack<string>();

            //Assert
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);

        }
        
        
        [Test]
        public void Peek_WhenListIsNotEmpty_ShouldReturnLast()
        {
            //Arrange
            var stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");

            //Act
            var result=stack.Peek();

            //Assert
            Assert.That(result,Is.EqualTo("two"));

        }
        
        
        [Test]
        public void Peek_WhenListIsNotEmpty_DoesNotRemoveObjectOnTop()
        {
            //Arrange
            var stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            var countListBeforePeek = stack.Count;

            //Act
            var result=stack.Peek();

            //Assert
            Assert.That(countListBeforePeek,Is.EqualTo(2));

        }
    }
}