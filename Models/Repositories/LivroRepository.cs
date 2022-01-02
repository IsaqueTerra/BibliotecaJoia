using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaJoia.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public List<LivroDto> Listar()
        {
            var livros = ContextDataFake.Livros;
            return livros
                .OrderBy(p => p.Nome)
                .ToList();
        }
    }
}
