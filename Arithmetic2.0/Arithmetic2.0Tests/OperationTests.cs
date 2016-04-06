using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arithmetic2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic2._0.Tests
{
    [TestClass()]
    public class OperationTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Operation operation = new Operation();
            Define define = new Define();
            define.num1 = 10;
            define.num2 = 2;
            define.ans[1] = (define.num1 + define.num2).ToString();
            Assert.AreEqual(define.ans[1],(define.num1 + define.num2).ToString());
        }
    }
}