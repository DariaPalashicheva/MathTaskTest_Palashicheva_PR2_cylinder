using MathTask_Palashicheva_PR2_cylinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTaskTest_Palashicheva_PR2_cylinder
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Cylinder_returned()
        {
            //исходные данные
            double r = 2;
            double h = 4;
            double expected = 50;

            // получаем значение с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.RectangleArea(r, h);


            // сравнеие ожидаемого результата с полученным
            Assert.AreEqual(expected, Math.Round(actual));
        }
    }
}
