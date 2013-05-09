using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizMaker;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testConstructorDefaultFraccion()
        {
            Fraccion f = new Fraccion();
            int numerador = f.getNumerador();
            int denominador = f.getDenominador();

            bool b = (numerador == 1) && (denominador == 1);

            Assert.AreEqual(true, b);
        }


        [TestMethod]
        public void testConstructorConParametrostFraccion()
        {
            Fraccion f = new Fraccion(2, 3);
            int numerador = f.getNumerador();
            int denominador = f.getDenominador();

            bool b = (numerador == 2) && (denominador == 3);

            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testConstructorConParametrosDenominadorCeroFraccion()
        {
            try
            {
                Fraccion f = new Fraccion(2, 0);
            }
            catch (ArgumentException e)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void testSumarMetodoPublicoDeFraccion()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Sumar(f1, f2);

            //bool b = result.esIgual(new Fraccion(9,9));
            bool b = (resul.getNumerador() == 9) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);
            
        }

        [TestMethod]
        public void testRestarMetodoPublicoDeFraccion()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Restar(f1, f2);

            bool b = (resul.getNumerador() == -3) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);

        }
        
        [TestMethod]
        public void testMultiplicarMetodoPublicoDeFraccion()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Multiplicar(f1, f2);

            bool b = (resul.getNumerador() == 2) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);
        }
        
        [TestMethod]
        public void testDividirMetodoPublicoDeFraccion()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Dividir(f1, f2);

            bool b = (resul.getNumerador() == 3) && (resul.getDenominador() == 6);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testConstructorDefaultProblema()
        {
            Problema p = new Problema();

            Fraccion op1 = p.getOperando1();
            Fraccion op2 = p.getOperando2();
            char operador = p.gerOperador();
            Fraccion result = p.getResultado();
        }
    }
}
