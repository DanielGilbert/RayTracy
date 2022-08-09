using RayTracy.Core.Math;
using System;
using TechTalk.SpecFlow;

namespace RayTracy.Tests
{
    [Binding]
    public class TuplesVectorsAndPointsStepDefinitions
    {
        private RayTracyTuple _givenATuple;

        [Then(@"a\.x = (.*)")]
        public void ThenA_X(Double p0)
        {
            Assert.AreEqual(_givenATuple.X, p0);
        }

        [Then(@"a\.y = (.*)")]
        public void ThenA_Y(Double p0)
        {
            Assert.AreEqual(_givenATuple.Y, p0);
        }

        [Then(@"a\.z = (.*)")]
        public void ThenA_Z(Double p0)
        {
            Assert.AreEqual(_givenATuple.Z, p0);
        }

        [Then(@"a\.w = (.*)")]
        public void ThenA_W(Double p0)
        {
            Assert.AreEqual(_givenATuple.W, p0);
        }

        [Then(@"a is a point")]
        public void ThenAIsAPoint()
        {
            Assert.IsTrue(_givenATuple.IsPoint);
        }

        [Then(@"a is not a vector")]
        public void ThenAIsNotAVector()
        {
            Assert.IsFalse(_givenATuple.IsVector);
        }

        [Then(@"a is not a point")]
        public void ThenAIsNotAPoint()
        {
            Assert.IsFalse(_givenATuple.IsPoint);
        }

        [Then(@"a is a vector")]
        public void ThenAIsAVector()
        {
            Assert.IsTrue(_givenATuple.IsVector);
        }

        [Given(@"p ← point\((.*), (.*), (.*)\)")]
        public void GivenPPoint(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"p = tuple\((.*), (.*), (.*), (.*)\)")]
        public void ThenPTuple(int p0, int p1, int p2, int p3)
        {
            throw new PendingStepException();
        }

        [Given(@"v ← vector\((.*), (.*), (.*)\)")]
        public void GivenVVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"v = tuple\((.*), (.*), (.*), (.*)\)")]
        public void ThenVTuple(int p0, int p1, int p2, int p3)
        {
            throw new PendingStepException();
        }

        [Then(@"a(.*) \+ a(.*) = tuple\((.*), (.*), (.*), (.*)\)")]
        public void ThenAATuple(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            throw new PendingStepException();
        }

        [Given(@"p(.*) ← point\((.*), (.*), (.*)\)")]
        public void GivenPPoint(int p0, int p1, int p2, int p3)
        {
            throw new PendingStepException();
        }

        [Then(@"p(.*) - p(.*) = vector\((.*), (.*), (.*)\)")]
        public void ThenP_PVector(int p0, int p1, int p2, int p3, int p4)
        {
            throw new PendingStepException();
        }

        [Then(@"p - v = point\((.*), (.*), (.*)\)")]
        public void ThenP_VPoint(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Given(@"v(.*) ← vector\((.*), (.*), (.*)\)")]
        public void GivenVVector(int p0, int p1, int p2, int p3)
        {
            throw new PendingStepException();
        }

        [Then(@"v(.*) - v(.*) = vector\((.*), (.*), (.*)\)")]
        public void ThenV_VVector(int p0, int p1, int p2, int p3, int p4)
        {
            throw new PendingStepException();
        }

        [Given(@"zero ← vector\((.*), (.*), (.*)\)")]
        public void GivenZeroVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"zero - v = vector\((.*), (.*), (.*)\)")]
        public void ThenZero_VVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Given(@"a ← tuple\((.*), (.*), (.*), (.*)\)")]
        public void GivenATuple(Double p0, Double p1, Double p2, Double p3)
        {
            _givenATuple = new RayTracyTuple()
            {
                X = p0,
                Y = p1,
                Z = p2,
                W = p3
            };
        }

        [Then(@"-a = tuple\((.*), (.*), (.*), (.*)\)")]
        public void Then_ATuple(int p0, int p1, int p2, int p3)
        {
            throw new PendingStepException();
        }

        [Then(@"a \* (.*) = tuple\((.*), (.*), (.*), (.*)\)")]
        public void ThenATuple(Decimal p0, Decimal p1, int p2, Decimal p3, int p4)
        {
            throw new PendingStepException();
        }

        [Then(@"a / (.*) = tuple\((.*), (.*), (.*), (.*)\)")]
        public void ThenATuple(int p0, Decimal p1, int p2, Decimal p3, int p4)
        {
            throw new PendingStepException();
        }

        [Then(@"magnitude\(v\) = (.*)")]
        public void ThenMagnitudeV(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"magnitude\(v\) = √(.*)")]
        public void ThenMagnitudeSqrtV(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"normalize\(v\) = vector\((.*), (.*), (.*)\)")]
        public void ThenNormalizeVVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"normalize\(v\) = approximately vector\((.*), (.*), (.*)\)")]
        public void ThenNormalizeVApproximatelyVector(Decimal p0, Decimal p1, Decimal p2)
        {
            throw new PendingStepException();
        }

        [When(@"norm ← normalize\(v\)")]
        public void WhenNormNormalizeV()
        {
            throw new PendingStepException();
        }

        [Then(@"magnitude\(norm\) = (.*)")]
        public void ThenMagnitudeNorm(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"a ← vector\((.*), (.*), (.*)\)")]
        public void GivenAVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Given(@"b ← vector\((.*), (.*), (.*)\)")]
        public void GivenBVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"dot\(a, b\) = (.*)")]
        public void ThenDotAB(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"cross\(a, b\) = vector\((.*), (.*), (.*)\)")]
        public void ThenCrossABVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Then(@"cross\(b, a\) = vector\((.*), (.*), (.*)\)")]
        public void ThenCrossBAVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Given(@"c ← color\((.*), (.*), (.*)\)")]
        public void GivenCColor(Decimal p0, Decimal p1, Decimal p2)
        {
            throw new PendingStepException();
        }

        [Then(@"c\.red = (.*)")]
        public void ThenC_Red(Decimal p0)
        {
            throw new PendingStepException();
        }

        [Then(@"c\.green = (.*)")]
        public void ThenC_Green(Decimal p0)
        {
            throw new PendingStepException();
        }

        [Then(@"c\.blue = (.*)")]
        public void ThenC_Blue(Decimal p0)
        {
            throw new PendingStepException();
        }

        [Given(@"c(.*) ← color\((.*), (.*), (.*)\)")]
        public void GivenCColor(int p0, Decimal p1, Decimal p2, Decimal p3)
        {
            throw new PendingStepException();
        }

        [Then(@"c(.*) \+ c(.*) = color\((.*), (.*), (.*)\)")]
        public void ThenCCColor(int p0, int p1, Decimal p2, Decimal p3, Decimal p4)
        {
            throw new PendingStepException();
        }

        [Then(@"c(.*) - c(.*) = color\((.*), (.*), (.*)\)")]
        public void ThenC_CColor(int p0, int p1, Decimal p2, Decimal p3, Decimal p4)
        {
            throw new PendingStepException();
        }

        [Then(@"c \* (.*) = color\((.*), (.*), (.*)\)")]
        public void ThenCColor(int p0, Decimal p1, Decimal p2, Decimal p3)
        {
            throw new PendingStepException();
        }

        [Given(@"c(.*) ← color\((.*), (.*), (.*)\)")]
        public void GivenCColor(int p0, int p1, Decimal p2, Decimal p3)
        {
            throw new PendingStepException();
        }

        [Given(@"c(.*) ← color\((.*), (.*), (.*)\)")]
        public void GivenCColor(int p0, Decimal p1, int p2, Decimal p3)
        {
            throw new PendingStepException();
        }

        [Then(@"c(.*) \* c(.*) = color\((.*), (.*), (.*)\)")]
        public void ThenCMultiplyCColor(int p0, int p1, Decimal p2, Decimal p3, Decimal p4)
        {
            throw new PendingStepException();
        }

        [Given(@"n ← vector\((.*), (.*), (.*)\)")]
        public void GivenNVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [When(@"r ← reflect\(v, n\)")]
        public void WhenRReflectVN()
        {
            throw new PendingStepException();
        }

        [Then(@"r = vector\((.*), (.*), (.*)\)")]
        public void ThenRVector(int p0, int p1, int p2)
        {
            throw new PendingStepException();
        }

        [Given(@"n ← vector\(√(.*), √(.*), (.*)\)")]
        public void GivenNVector(Decimal p0, Decimal p1, int p2)
        {
            throw new PendingStepException();
        }
    }
}
