using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }

        public string RetornarNomeCategoria()
        {
            return $"Filme {NomeFilme}, Categoria {Categoria}";
        }
    }
}