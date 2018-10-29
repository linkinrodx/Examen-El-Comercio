using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Evaluacion_1.Test
{
    [TestClass]
    public class UnitTest_Algoritmos
    {
        [TestMethod]
        public void Problema1()
        {
            //Planteamiento
            string entrada1 = "123 abcd*3";
            string entrada2 = "**Casa 52";
            string esperado1 = "123 bcde*3";
            string esperado2 = "**Dbtb 52";
            //Prueba
            var prueba1 = ChangeString.build(entrada1);
            var prueba2 = ChangeString.build(entrada2);
            //Resultado
            Assert.AreEqual(esperado1, prueba1);
            Assert.AreEqual(esperado2, prueba2);
        }

        [TestMethod]
        public void Problema2()
        {
            //Planteamiento
            int[] entrada1 = { 2, 1, 4, 5 };
            int[] salidapares = { 2, 4 };
            int[] salidaimpares = { 1, 5 };
            List<int> pares = null;
            List<int> impares = null;
            //Prueba
            OrderRange.build(entrada1, ref pares, ref impares);
            //Resultado
            CollectionAssert.AreEqual(salidapares, pares.ToArray());
            CollectionAssert.AreEqual(salidaimpares, impares.ToArray());
        }

        [TestMethod]
        public void Problema3()
        {
            //Planteamiento
            decimal entrada1 = 0.1M;
            decimal entrada2 = 0.2M;
            decimal[][] salida1 = { new decimal[]{ 0.05M, 0.05M }, new decimal[] { 0.1M } };
            decimal[][] salida2 = { new decimal[] { 0.05M, 0.05M, 0.05M, 0.05M }, new decimal[] { 0.1M, 0.05M, 0.05M}, new decimal[] { 0.1M, 0.1M }, new decimal[] { 0.2M } };
            //Prueba
            var respuesta1 = MoneyParts.build(entrada1).ToArray();
            var respuesta2 = MoneyParts.build(entrada2).ToArray();
            //Resultado
            CollectionAssert.AreEqual(respuesta1, salida1, new CollectionAssertComperator());
            CollectionAssert.AreEqual(respuesta2, salida2, new CollectionAssertComperator());
        }
    }

    //metodo para comparar matrices
    class CollectionAssertComperator : IComparer
    {
        public int Compare(object x, object y)
        {
            CollectionAssert.AreEqual((ICollection)x, (ICollection)y);
            return 0;
        }
    }
}
