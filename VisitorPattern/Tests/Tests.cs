using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryFigures;
using NUnit.Framework;
using VisitorImplementations.Builder;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BuilderTest()
        {
            IFigure figure = new Circle(100.0);

            Assert.IsTrue(figure.IfCircle(c => true).Else(() => false));
            Assert.IsFalse(figure.IfRectangle(c => true).Else(() => false));
            Assert.IsFalse(figure.IfTriangle(c => true).Else(() => false));
        }
    }
}
