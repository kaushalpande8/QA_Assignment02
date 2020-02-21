using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QA_Assignment02;

namespace AssignmentQATest
{
    [TestFixture]
    class TriangleSolverTest
    {
        [Test]
        public void IsTriangle_From_isCorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 3, 4), "This is a Scalene Triangle");
        }
        [Test]
        public void TypeTriangle_Checkequilateral_isCorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 2, 2), "This is an Equilateral Triangle");

        }
        [Test]
        public void TypeTriangle_Checkscalene_isCorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(7, 6, 2), "This is a Scalene Triangle");

        }
        [Test]
        public void TypeTriangle_Checkisoceles_isCorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 2, 3), "This is an Isosceles Trainagle");

        }

        [Test]
        public void IsTriangle_From_Isnotcorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 0, 4), "Triangle cannot be formed");
        }

        [Test]
        public void IsTriangle_Input_IsnotProper()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 0, 4), "Triangle cannot be formed");
        }
        [Test]
        public void IsTriangle_Typeequilateral_Isnotcorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 4), "This is an Scalene Triangle");
        }
        [Test]
        public void IsTriangle_Typescalene_Isnotcorrect()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 4), "This is an Isosceles Trainagle");
        }






    }
}
