using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    
    public class Fraccion
    {
        private int numerador;
        private int denominador;
        private bool signo;
        private int signoFrac;

        public Fraccion()
        {
            this.numerador = 1;
            this.denominador = 1;
            this.signo = true;
            signoFrac = 1;
        }

        public Fraccion(int num, int denom)
        {
            if (denom == 0)
                throw new ArgumentException();


            if (num < 0 && denom > 0)
            {
                signo = false;
                num = Math.Abs(num);
                signoFrac = -1;
            }
            else if (num > 0 && denom < 0)
            {
                signo = false;
                num = Math.Abs(num);
                signoFrac = -1;
            }
            else if (num < 0 && denom < 0)
            {
                signo = true;
                num = Math.Abs(num);
                denom = Math.Abs(denom);
                signoFrac = 1;
            }
            else
            {
                signo = true;
                signoFrac = 1;
            }
            
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

        public bool getSigno()
        {
            return this.signo;
        }

        public Fraccion getMayor(Fraccion f1, Fraccion f2)
        {
            float a = f1.getNumerador() / f1.getDenominador();
            float b = f2.getNumerador() / f2.getDenominador();
            if (a > b)
                return f1;
            else
                return f2;
        }

        public void Sumar(Fraccion f1, Fraccion f2)
        {
            int n=0, d=0;
         
            if (f1.getSigno() == f2.getSigno())
            {
                n = f1.getNumerador() * f2.getDenominador() + f1.getDenominador() * f2.getNumerador();
                d = f1.getDenominador() * f2.getDenominador();                
            }
            else if (!f1.getSigno() && f2.getSigno())
            {
                Fraccion temp = new Fraccion();
                temp.Restar(f2, f1);
                n = temp.getNumerador();
                d = temp.getDenominador();
                n *= f1.signoFrac;
            }
            else if (f1.getSigno() && !f2.getSigno())
            {
                Fraccion temp = new Fraccion();
                temp.Restar(f1, f2);
                n = temp.getNumerador();
                d = temp.getDenominador();
                n *= f2.signoFrac;
            }            
            this.numerador = n;
            this.denominador = d;

        }

        public void Restar(Fraccion f1, Fraccion f2)
        {
            int n=0, d=0;
            if (f1.getSigno() == f2.getSigno())
            {
                n = (f1.getNumerador() * f2.getDenominador())*(-1) - (f1.getDenominador() * f2.getNumerador())*(-1);
                d = f1.getDenominador() * f2.getDenominador();
            }
            else if (!f1.getSigno() && f2.getSigno())
            {
                Fraccion temp = new Fraccion();
                temp.Sumar(f2, f1);
                n = temp.getNumerador();
                d = temp.getDenominador();
                n *= f1.signoFrac;
            }
            else if (f1.getSigno() && !f2.getSigno())
            {
                Fraccion temp = new Fraccion();
                temp.Sumar(f2, f1);
                n = temp.getNumerador();
                d = temp.getDenominador();
                
            }            
            this.numerador = n;
            this.denominador = d;
        }

        public void Multiplicar(Fraccion f1, Fraccion f2)
        {
            int n = f1.getNumerador() *  f2.getNumerador();
            int d = f1.getDenominador() * f2.getDenominador();

            if (!f1.getSigno() && f2.getSigno())
            {
                n = n * f1.signoFrac;
            }
            else if ( f1.getSigno() && !f2.getSigno())
            {
                n = n * f2.signoFrac;
            }
            this.numerador = n;
            this.denominador = d;
        }

        public void Dividir(Fraccion f1, Fraccion f2)
        {
            int n = f1.getNumerador() * f2.getDenominador() ;
            int d = f1.getDenominador() * f2.getNumerador();

            if (!f1.getSigno() && f2.getSigno())
            {
                n = n * f1.signoFrac;
            }
            else if (f1.getSigno() && !f2.getSigno())
            {
                n = n * f2.signoFrac;
            }

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
            int num = Math.Abs(this.getNumerador());
            int den = Math.Abs(this.getDenominador());
            if (!this.getSigno())
            {
                if (num < 0)
                    num *= -1;
                else if (den < 0)
                    den *= -1;

            }
            int gcd = GCD(num, den);
            num = num / gcd;
            den = den / gcd;

            if (!this.getSigno())
            {
                if (num < 0)
                    num *= -1;
                else if (den < 0)
                    den *= -1;

            }
            
            this.setNumerador(num);
            this.setDenominador(den);
        }
    }
}
