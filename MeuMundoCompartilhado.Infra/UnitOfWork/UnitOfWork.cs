using MeuMundoCompartilhado.Infra.Contexts;
using MeuMundoCompartilhado.Shared.UnitOfWork;
using System;

namespace MeuMundoCompartilhado.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Commit()
        {
            _dataContext.SaveChanges();
        }

        public void RollBack()
        {
           
        }
    }
}
