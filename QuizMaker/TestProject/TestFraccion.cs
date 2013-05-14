﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizMaker;

namespace TestProject
{
    [TestClass]
    public class TestFraccion
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

            bool b = (resul.getNumerador() == 9) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);
            
        }

        [TestMethod]
        public void testIsPositiveFraccionConNumYDenPositivo()
        {
            Fraccion f = new Fraccion(1, 3);
            Assert.AreEqual(true, f.getSigno());
        }


        [TestMethod]
        public void testIsPositiveFraccionConNumYDenNegativo()
        {
            Fraccion f = new Fraccion(-1, -3);
            Assert.AreEqual(true, f.getSigno());
        }


        [TestMethod]
        public void testIsNegativeFraccionConNumNegativo()
        {
            Fraccion f = new Fraccion(-1, 3);
            Assert.AreEqual(false, f.getSigno());
        }

        
        [TestMethod]
        public void testIsNegativeFraccionConDenNegativo()
        {
            Fraccion f = new Fraccion(1, -3);
            Assert.AreEqual(false, f.getSigno());
        }


        [TestMethod]
        public void testSumarMetodoPublicoDeFraccionConSignosEnOperador1()
        {
            Fraccion f1 = new Fraccion(-1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Sumar(f1, f2);

            resul.Simplificar();
            bool b = (resul.getNumerador() == 1) && (resul.getDenominador() == 3);
            Assert.AreEqual(true, b);
        }

        
        [TestMethod]
        public void testSumarMetodoPublicoDeFraccionConSignosEnOperador2()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
            Fraccion resul = new Fraccion();
            resul.Sumar(f1, f2);

            resul.Simplificar();
            bool b = (resul.getNumerador() == 1) && (resul.getDenominador() == 3);
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
        public void testRestarMetodoPublicoDeFraccion1()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
            Fraccion resul = new Fraccion();
            resul.Restar(f1, f2);

            bool b = (resul.getNumerador() == 9) && (resul.getDenominador() == 9);
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
        public void testMultiplicarMetodoPublicoDeFraccionNegativo1()
        {
            Fraccion f1 = new Fraccion(-1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Multiplicar(f1, f2);

            
            bool b = (resul.getNumerador() == -2) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testMultiplicarMetodoPublicoDeFraccionNegativo2()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
            Fraccion resul = new Fraccion();
            resul.Multiplicar(f1, f2);

            
            bool b = (resul.getNumerador() == -2) && (resul.getDenominador() == 9);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testMultiplicarMetodoPublicoDeFraccionNegativo3()
        {
            Fraccion f1 = new Fraccion(-1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
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
        public void testDividirMetodoPublicoDeFraccion1()
        {
            Fraccion f1 = new Fraccion(-1, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resul = new Fraccion();
            resul.Dividir(f1, f2);
            
            bool b = (resul.getNumerador() == -3) && (resul.getDenominador() == 6);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testDividirMetodoPublicoDeFraccion2()
        {
            Fraccion f1 = new Fraccion(1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
            Fraccion resul = new Fraccion();
            resul.Dividir(f1, f2);

            bool b = (resul.getNumerador() == -3) && (resul.getDenominador() == 6);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testDividirMetodoPublicoDeFraccion3()
        {
            Fraccion f1 = new Fraccion(-1, 3);
            Fraccion f2 = new Fraccion(-2, 3);
            Fraccion resul = new Fraccion();
            resul.Dividir(f1, f2);

            bool b = (resul.getNumerador() == 3) && (resul.getDenominador() == 6);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testSimplificarFraccion()
        {
            Fraccion f = new Fraccion(7, 14);

            f.Simplificar();
            
            bool b = (f.getNumerador() == 1) && (f.getDenominador() == 2);

            Assert.AreEqual(true,b);
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
