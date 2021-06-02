using MeuMundoCompartilhado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MeuMundoCompartilhado.Domain.Repositories
{
    public interface IPessoaRepository
    {
        Pessoa GetById(int id);

        List<Pessoa> GetAll();

        List<Pessoa> Find(Expression<Func<Pessoa, bool>> expression);

        void InsertPessoa(Pessoa pessoa);

        void UpdatePessoa(Pessoa pessoa);
    }
}