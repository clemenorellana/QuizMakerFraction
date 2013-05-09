using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
