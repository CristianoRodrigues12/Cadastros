using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Pessoa
    {
        private int matricula;
        private string nome="";

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        { 
            get { return nome; } 
            set { nome = value; }
        }

    }
}
