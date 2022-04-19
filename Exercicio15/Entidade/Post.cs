﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Exercicio15.Entidade
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }

        public List<Comentario> comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            comentarios.Add(comentario);
        }
      

        public void RemoverComentario(Comentario comentario)
        {
            comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentarios: ");
            foreach (Comentario c in comentarios) 
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
