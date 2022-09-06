using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Professor:Pessoa
    {
        float salario;

        public float Salario { get => salario; set => salario = value; }
    }
}
