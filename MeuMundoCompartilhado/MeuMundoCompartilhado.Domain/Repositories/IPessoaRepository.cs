using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Enums;
using System;
using System.Collections.Generic;

namespace MeuMundoCompartilhado.Domain.Repositories
{
    public interface IPessoaRepository
    {
        bool PessoaExists(string nome, string sobrenome, TipoParentesco tipoParentesco, string descricaoParentesco);

        void CreatePessoa(Pessoa pessoa);

        void UpdatePessoa(Pessoa pessoa);

        Pessoa GetById(Guid id);

        IEnumerable<Pessoa> GetAll();
    }
}