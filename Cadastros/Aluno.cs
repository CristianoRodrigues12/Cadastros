using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Aluno:Pessoa
    {
        float media;

        public float Media { get => media; set => media = value; }
    }
}
