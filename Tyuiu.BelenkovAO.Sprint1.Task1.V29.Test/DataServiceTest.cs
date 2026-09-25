using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelenkovAO.Sprint1.Task1.V29.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelenkovAO.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            ISprint1Task1V29 ds = new DataService();

            double a = 2.0;
            double b = 3.0;
            double c = 4.0;

            double res = ds.Calculate(a, b, c);
            double wait = 24.0 / 9.0;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}