using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker;

namespace QuizMaker
{
    class Test
    {
        public Fraccion []results;
        public Problema problem;

        public void generarTest()
        {
            problem = new Problema();
            problem.generarProblemaRandom(0);
            results = problem.generarProblemaRandomMalos();

        }

        public bool verificarRespuesta(int posRespuesta)
        {
            Fraccion respuesta = results[posRespuesta];
            if (respuesta.getNumerador() == problem.getResultado().getNumerador() && respuesta.getDenominador() == problem.getResultado().getDenominador())
                return true;
            return false;
        }
    }

    

}
