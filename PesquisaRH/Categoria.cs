using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaRH
{
    public class Categoria
    {
        public string Nome { get; private set; }
        public int Ordem { get; private set; }
        public Pergunta Perguntas { get; private set; }
    }
}