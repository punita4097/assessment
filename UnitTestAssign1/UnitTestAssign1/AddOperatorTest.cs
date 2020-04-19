using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestAssign1
{
    [TestClass]
    public class AddOperatorTest
    {
        public const double Tolerance = 0.0000001;
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_AddPositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var addOperator = new AddOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(addOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }

        [TestMethod]
        [DynamicData(nameof(GetStringValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_AddStirngArgs_ResultReturns((object[] operands, string expected) info)
        {
            // Arrange
            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var addOperator = new AddOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.AreEqual(addOperator.Evaluate(list), Convert.ToString(info.expected));
        }
        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Addition: new object[] { 0, 25 }, Expected: 25D) };
            yield return new object[] { (Addition: new object[] { 5, 5 }, Expected: 10D) };
            yield return new object[] { (Addition: new object[] { 19, -2 }, Expected: 17D) };
            yield return new object[] { (Addition: new object[] { -33, -11 }, Expected: -44D) };
            yield return new object[] { (Addition: new object[] { 12, 40.5 }, Expected: 52.5D) };
            yield return new object[] { (Addition: new object[] { 16.2, 22 }, Expected: 38.2D) };
            yield return new object[] { (Addition: new object[] { 30.65, 10.45 }, Expected: 41.1D) };
            yield return new object[] { (Addition: new object[] { 12.10, -3.5 }, Expected: 8.6) };
            yield return new object[] { (Addition: new object[] { -12.10, 4.5, }, Expected: -7.6) };
            yield return new object[] { (Addition: new object[] { 0.000000000000000000321, 0.000000000000000000003 }, Expected: 2.5202598881629844E-35D) };
            yield return new object[] { (Addition: new object[] { 1235349, 9, 4 }, Expected: 1235362D) };
            yield return new object[] { (Addition: new object[] { 1235349, 7, 2, 2 }, Expected: 1235360D) };
        }

        public static IEnumerable<object[]> GetStringValueDataRow()
        {
            yield return new object[] { (Addition: new object[] { "P", "Q", "R", "S", "T" }, Expected: "PQRST") };
            yield return new object[] { (Addition: new object[] { "A", "B", "C", "D", "E" }, Expected: "ABCDE") };
           
        }

        
    }
}
