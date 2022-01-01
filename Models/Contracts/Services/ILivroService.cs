using BibliotecaJoia.Models.Dtos;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface ILivroService 
    {
        List<LivroDto> Listar();

    }
}
