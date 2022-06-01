using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Tests
{
    [TestClass()]
    public class PruebaExcepcionesPuntoDosTest
    {
        [TestMethod()]
        public void DivisionPorCero()
        {
            //Arrange
            var valor1 = "10";
            var valor2 = "0";

            //Act
            var result = PruebaExcepciones.PuntoDos(valor1, valor2);

            //Assert
            Assert.AreEqual(result, "Sólo Goku puede dividir por cero!!!");
        }

        [TestMethod()]
        public void DivisionInvalida()
        {
            //Arrange
            var valor1 = "10";
            var valor2 = "cadena";

            //Act
            var result = PruebaExcepciones.PuntoDos(valor1, valor2);

            //Assert
            Assert.AreEqual(result, "¡Seguro Ingreso una letra o no ingreso nada!");
        }

    }

}