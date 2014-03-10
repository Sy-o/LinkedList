using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_2;

namespace TestForList
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestAdd()
        {
            LinkedList list = new LinkedList();
            list.Add("one");
        }

        [TestMethod]
        public void TestDelete()
        {
            LinkedList list = new LinkedList();
            list.Add("one");
            list.Delete("one");
        }

        [TestMethod]
        public void TestDeleteFromTheMid()
        {
            LinkedList list = new LinkedList();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Delete("two");
        }

        [TestMethod]
        public void TestByIndex()
        {
            int index;
            int expected = 1;
            LinkedList list = new LinkedList();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            index = list.IndexOf("two");
            Assert.AreEqual(index, expected);
        }

        [TestMethod]
        public void TestFindByIndex()
        {
            string expected = "one";
            string real = "";
            LinkedList list = new LinkedList();
            list.Add("one");
            list.Add("two");
            real = list.FindByIndex(0);
            Assert.AreEqual(real, expected);
        }

        [TestMethod]
        public void TestMoreComplexAddDelete()
        {
            string expected = "three";
            string real = "";
            LinkedList list = new LinkedList();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Delete("one");
            list.Add("four");
            list.Delete("two");
            list.Delete("four");
            real = list.FindByIndex(0);
            Assert.AreEqual(real, expected);
        }
        

    }
}
