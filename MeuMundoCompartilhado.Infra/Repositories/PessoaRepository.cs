using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.Repositories;
using MeuMundoCompartilhado.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MeuMundoCompartilhado.Infra.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext _dataContext;

        public PessoaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Pessoa GetById(int id)
        {
            var query = _dataContext.Pessoas.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
            return query;
        }

        public List<Pessoa> GetAll()
        {
            var query = _dataContext.Pessoas.AsNoTracking();
            return query.ToList();
        }

        public List<Pessoa> Find(Expression<Func<Pessoa, bool>> expression)
        {
            var query = _dataContext.Pessoas.Where(expression);
            return query.ToList();
        }

        public void InsertPessoa(Pessoa pessoa)
        {
            _dataContext.Pessoas.Add(pessoa);
        }

        public void UpdatePessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}