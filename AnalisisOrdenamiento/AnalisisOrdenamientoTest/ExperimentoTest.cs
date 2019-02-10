using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisOrdenamiento;

namespace AnalisisOrdenamientoTest
{
    [TestClass]
    public class ExperimentoTest
    {
        private Ordenamiento ordenamientoT;

        public void initialize()
        {
            ordenamientoT = new Ordenamiento(0, 0, "", "");

        }
        [TestMethod]
        public void testQuickSortAscendenteSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickPequeño();


            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortAscendenteBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();


            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortAscendenteBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortDescendenteSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickPequeño();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortDescendenteBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);
            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortDescendenteBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);
            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortRandomSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickPequeño();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortRandomBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testQuickSortRandomBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "QuickSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorQuick();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortAscendenteSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickPequeño();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortAscendenteBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }
        [TestMethod]
        public void testBubbleSortAscendenteBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ASCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortDescendenteSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickPequeño();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortDescendenteBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortDescendenteBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "DESCENDENTE";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }


        [TestMethod]
        public void testBubbleSortRandomSmall2()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.PEQUEÑO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickPequeño();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortRandomBig4()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.MEDIANO;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }

        [TestMethod]
        public void testBubbleSortRandomBig8()
        {
            initialize();
            ordenamientoT.tamañoArreglo = Ordenamiento.GRANDE;
            ordenamientoT.RAM = 0;
            ordenamientoT.estadoArreglo = "ALEATORIO";
            ordenamientoT.algoritmoOrdenamiento = "BubbleSort";
            ordenamientoT.estadoQuickGrande();

            int[] esperado = ordenamientoT.getCollection();
            Array.Sort(esperado);

            ordenamientoT.ordenarPorBurbuja();

            Assert.AreEqual(esperado, ordenamientoT.getCollection());
        }
    }
}
