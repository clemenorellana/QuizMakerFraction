using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    /*class Fraccion
    {
        private int _numerador;
        private int _denominador;

        public Fraccion()
        {
            this._denominador = 0;
            this._numerador = 0;
        }
    }*/


    public class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion()
        {
            this.numerador = 1;
            this.denominador = 1;
        }

        public Fraccion(int num, int denom)
        {
            if (denom == 0)
                throw new ArgumentException();

            this.numerador = num;
            this.denominador = denom;
        }

        public int getNumerador()
        {
            return numerador;
        }

        public int getDenominador()
        {
            return denominador;
        }

        public void setNumerador(int num)
        {
            this.numerador = num;
        }

        public void setDenominador(int den)
        {
            this.denominador = den;
        }

        public void Sumar(Fraccion f1, Fraccion f2)
        {   
            int n = f1.getNumerador() * f2.getDenominador() + f1.getDenominador() * f2.getNumerador();
            int d = f1.getDenominador() * f2.getDenominador();
            this.numerador = n;
            this.denominador = d;
        }

        public void Restar(Fraccion f1, Fraccion f2)
        {
            int n = f1.getNumerador() * f2.getDenominador() - f1.getDenominador() * f2.getNumerador();
            int d = f1.getDenominador() * f2.getDenominador();
            this.numerador = n;
            this.denominador = d;
        }

        public void Multiplicar(Fraccion f1, Fraccion f2)
        {
            int n = f1.getNumerador() *  f2.getNumerador();
            int d = f1.getDenominador() * f2.getDenominador();
            this.numerador = n;
            this.denominador = d;
        }

        public void Dividir(Fraccion f1, Fraccion f2)
        {
            int n = f1.getNumerador() * f2.getDenominador() ;
            int d = f1.getDenominador() * f2.getNumerador();
            this.numerador = n;
            this.denominador = d;
        }

        private int GCD(int num, int den)
        {
            while (true)
            {
                num = num % den;
                if (num == 0)
                    return den;

                den = den % den;
                if (den == 0)
                    return num;
            }
        }

        public void Simplificar()
        {
            int num = this.getNumerador();
            int den = this.getDenominador();
            int gcd = GCD(num, den);
            num = num / gcd;
            den = den / gcd;
            this.setNumerador(num);
            this.setDenominador(den);
        }
    }
}
