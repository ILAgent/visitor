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

        [Test]
        public void AreaTest()
        {
            IFigure figure = new Rectangle(100, 5);

            var area = figure.IfRectangle(r => r.Height * r.Width)
                .IfCircle(c => Math.PI * c.Radius * c.Radius)
                .IfTriangle(t =>
                    {
                        var p = (t.A + t.B + t.C) / 2;
                        return Math.Sqrt(p * (p - t.A) * (p - t.B) * (p - t.C));
                    }
                ).Else(() => 0);

            Assert.AreEqual(500, area);
        }
    }
}
