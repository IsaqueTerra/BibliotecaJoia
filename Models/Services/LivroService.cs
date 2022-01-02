using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Contracts.Services;
using BibliotecaJoia.Models.Dtos;
using System;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }        

        public List<LivroDto> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
