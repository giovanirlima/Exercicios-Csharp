using Exercicio15.Entidade;
using System;
using System.Collections.Generic;

Comentario c1 = new Comentario("Boa viagem!");
Comentario c2 = new Comentario("Volte logo!");

Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"), 
    "Viajando para Nova Zelandia",
    "Estou indo visitar este lindo Pais",
    12);
p1.AddComentario(c1);
p1.AddComentario(c2);

Comentario c3 = new Comentario("Boa Noite!");
Comentario c4 = new Comentario("Que saudades!");

Post p2 = new Post(
    DateTime.Parse("21/06/2019 13:05:44"),
    "Boa Noite",
    "Esta tarde",
    5);
p2.AddComentario(c1);
p2.AddComentario(c2);

Console.WriteLine(p1);
Console.WriteLine(p2);