using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum dificultad {easy,hard};

namespace QuizMaker
{
    public class Problema
    {
        private Fraccion operando1;
        private Fraccion operando2;
        private char operador;
        private Fraccion resultado;

        public Problema()
        {
        }
        
        public Problema generarProblemaRandom(dificultad lvl)
        {
            Random n1 = new Random();
            int nx = n1.Next(1, 4);
            if (nx == 1)
            {
                operador = '+';
            }
            else if (nx == 2)
            {
                operador = '-';
            }
            else if (nx == 3)
            {
                operador = '/';
            }
            else
            {
                operador = '*';
            }

            if (lvl == dificultad.easy)
            {
                Random n = new Random();
                int num = n.Next(1, 9);
                int den = n.Next(1, 9);
                operando1.setNumerador(num);
                operando1.setDenominador(den);
                n = new Random();
                num = n.Next(1, 9);
                den = n.Next(1, 9);
                operando2.setNumerador(num);
                operando2.setDenominador(den);
                getResultado();
            }
            else
            {
                Random n = new Random();
                int num = n.Next(10, 99);
                int den = n.Next(10, 99);
                operando1.setNumerador(num);
                operando1.setDenominador(den);
                n = new Random();
                num = n.Next(10, 99);
                den = n.Next(10, 99);
                operando2.setNumerador(num);
                operando2.setDenominador(den);
                getResultado();
            }

            return this;
        }

        public Problema generarProblemaRandomMalos(dificultad lvl)
        {

            if (lvl == dificultad.easy)
            {
                Random n = new Random();
                int num = n.Next(1, 9);
                int den = n.Next(1, 9);
                operando1.setNumerador(num);
                operando1.setDenominador(den);
                n = new Random();
                num = n.Next(1, 9);
                den = n.Next(1, 9);
                operando2.setNumerador(num);
                operando2.setDenominador(den);
                getResultado();
            }
            else
            {
                Random n = new Random();
                int num = n.Next(10, 99);
                int den = n.Next(10, 99);
                operando1.setNumerador(num);
                operando1.setDenominador(den);
                n = new Random();
                num = n.Next(10, 99);
                den = n.Next(10, 99);
                operando2.setNumerador(num);
                operando2.setDenominador(den);
                getResultado();
            }

            return this;
        }

        public Fraccion getOperando1()
        {
            return this.operando1;
        }

        public Fraccion getOperando2()
        {
            return this.operando2;
        }

        public char gerOperador()
        {
            return this.operador;
        }

        public Fraccion getResultado()
        {
            if (this.operador == '+')
                this.resultado.Sumar(this.operando1, this.operando2);
            else if(this.operador == '-')
                this.resultado.Restar(this.operando1, this.operando2);
            else if (this.operador == '*')
                this.resultado.Multiplicar(this.operando1, this.operando2);
            else if (this.operador == '/')
                this.resultado.Dividir(this.operando1, this.operando2);

            return this.resultado;
        }
    }
}
