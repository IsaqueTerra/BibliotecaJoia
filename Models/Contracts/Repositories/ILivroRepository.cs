using System.Collections.Generic;
using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        List<LivroDto> Listar();
    }
}
