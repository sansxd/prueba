using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyectobubblesort;

namespace UnitTestBubblesort
{
    [TestClass]
    public class TestUnitario1
    {
        [TestMethod]
        public void TestMethod10()
        {
            //testeo con 10 elementos
            // arrange -  act  - assert
            Bubblesort bubble = new Bubblesort();
            int[] numbers = new int[] { 1, 7, 99, 2, 0, 12, 15 ,3,5, 55};
            bubble.BubleSort(numbers);
            int[] valoreEsperado = new int[] { 0, 1, 2, 3,5, 7, 12, 15,55, 99 };
            CollectionAssert.AreEqual(valoreEsperado, numbers);
            //Assert.AreEqual(valoreEsperado, numbers);
        }
    }
}
