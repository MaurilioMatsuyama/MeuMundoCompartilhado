using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace MeuMundoCompartilhado.Infra.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        public void CreatePessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pessoa GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool PessoaExists(string nome, string sobrenome, TipoParentesco tipoParentesco, string descricaoParentesco)
        {
            throw new NotImplementedException();
        }

        public void UpdatePessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}