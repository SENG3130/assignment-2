using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using CDT.Core;

namespace CoreMethodTests
{
    [TestFixture]
    public class CircularShiftTests
    {

        [Test]
        public void c_shift_test_1()
        {
            Rotator rotator = new Rotator();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello");

            LinkedList<string> result = rotator.Rotate(list);

            int count = result.Count;

            Assert.AreEqual(count, 0);
        }

        [Test]
        public void c_shift_test_2()
        {
            Rotator rotator = new Rotator();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello World /");

            LinkedList<string> result = rotator.Rotate(list);

            int count = result.Count;

            Assert.AreEqual(count, 2, "Incorrect list output length");
            Assert.AreEqual(result.ElementAt(0), "World Hello", "Incorrect first entry");
            Assert.AreEqual(result.ElementAt(1), "Hello World", "Incorrect second entry");

        }

        [Test]
        public void c_shift_test_3()
        {
            Rotator rotator = new Rotator();

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Hello /");

            LinkedList<string> result = rotator.Rotate(list);

            int count = result.Count;

            Assert.AreEqual(count, 1, "Incorrect list output length");
            Assert.AreEqual(result.ElementAt(0), "Hello", "Incorrect entry");

        }
    }
}
