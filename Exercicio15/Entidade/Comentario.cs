using System;
using System.Collections.Generic;


namespace Exercicio15.Entidade
{
    class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
