﻿using BibliotecaJoia.Models.Dtos;
using System;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<LivroDto> Livros;

        static ContextDataFake()
        {
            Livros = new List<LivroDto>();
            InitializeData();
        }

        private static void InitializeData()
        {
            var livro = new LivroDto("Implementando Domain-Driven Design","Vaugh Vernon","Alta Books");
            Livros.Add(livro);
            
            livro = new LivroDto("Domain-Driven Design", "Eric Evans", "Alta Books");
            Livros.Add(livro);

            livro = new LivroDto("Redes Guia Prático", "Carlos E. Morimoto", "Sul Editores");
            Livros.Add(livro);

            livro = new LivroDto("PHP Programando com Orientação a Objetos", "Pablo Dall'Oglio", "Novatec");
            Livros.Add(livro);

            livro = new LivroDto("Introdução a Programação a Pyton", "Nilo N. C. Menezes", "NotaTec");
            Livros.Add(livro);
        }
    }
}
