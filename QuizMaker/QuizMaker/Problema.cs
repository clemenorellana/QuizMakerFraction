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
        private Fraccion[] malos;

        enum dificultad { easy, hard };

        public Problema()
        {
            malos = new Fraccion[4];
        }
        
        public void generarProblemaRandom(int level)
        {
            dificultad lvl = new dificultad();
            if(level==0)
                lvl = dificultad.easy;
            else
                lvl = dificultad.hard;

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



        }

        public Fraccion[] generarProblemaRandomMalos()
        {
            int cont = 0;
            int pos = 0;
                  

            while(cont<3)
            {
                Random ran = new Random();
                pos = ran.Next(0,3);
                if(malos[pos]==null)
                {
                    malos[pos].setNumerador(getResultado().getNumerador()+cont+1);
                    malos[pos].setDenominador(getResultado().getDenominador());

                    cont++;
                }
            }

            for(int i=0;i<4;i++)
            {
                if(malos[i]==null)
                {
                    malos[pos]=getResultado();
                }

            }

            
            return malos;
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
