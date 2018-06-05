using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using CDT.Core;

namespace CoreMethodTests
{
    [TestFixture]
    public class AlphabetiserTests
    {

        [Test]
        public void test_1()
        {
            CoreSorter sorter = new CoreSorter();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello /");

            LinkedList<string> result = sorter.Index(list);

            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result.ElementAt(0), "Hello /");

        }

        [Test]
        public void test_2()
        {
            CoreSorter sorter = new CoreSorter();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello /");
            list.AddLast("World /");

            LinkedList<string> result = sorter.Index(list);

            Assert.AreEqual(result.Count, 2);
            Assert.AreEqual(result.ElementAt(0), "Hello /", "Incorrect first entry");
            Assert.AreEqual(result.ElementAt(1), "World /", "Incorrect second entry");

        }

        [Test]
        public void test_3()
        {
            CoreSorter sorter = new CoreSorter();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello /");
            list.AddLast("World /");
            list.AddLast("Test /");

            LinkedList<string> result = sorter.Index(list);

            Assert.AreEqual(result.Count, 3);
            Assert.AreEqual(result.ElementAt(0), "Hello /", "Incorrect first entry");
            Assert.AreEqual(result.ElementAt(1), "Test /", "Incorrect second entry");
            Assert.AreEqual(result.ElementAt(2), "World /", "Incorrect third entry");

        }
    }
}
