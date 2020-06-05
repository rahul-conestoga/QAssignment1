using System;
using Assignment1;
using NUnit.Framework;

namespace UnitTesting
{
    public class ShapeTester
    {
        public ShapeTester()
        {
        }

        [Test]
        public void Length_Is_Always_Positive()
        {
            int l = 2;
            int w = 3;
            Rectangle rect = new Rectangle(l, w);
            rect.SetLength(-1);
            Assert.Greater(rect.GetLength(), 0);
        }

        [Test]
        public void Width_Is_Always_Positive()
        {
            int l = 2;
            int w = 3;
            Rectangle rect = new Rectangle(l, w);
            rect.SetWidth(-1);
            Assert.Greater(rect.GetWidth(), 0);

        }

        [Test]
        public void Area_Works()
        {
            int l = 2;
            int w = 3;
            Rectangle rect = new Rectangle(l, w);

            var area = rect.GetArea();

            Assert.AreEqual(area, 6);
        }
    }
}
