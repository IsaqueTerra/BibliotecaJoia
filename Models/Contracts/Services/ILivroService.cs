using BibliotecaJoia.Models.Dtos;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface ILivroService 
    {
        void Cadastrar(LivroDto livro);

        List<LivroDto> Listar();

        LivroDto PesquisarPorId(string id);

        void Atualizar(LivroDto livro);

        void Excluir(string id);
    }
}
