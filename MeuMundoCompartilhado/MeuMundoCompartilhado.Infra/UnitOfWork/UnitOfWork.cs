using MeuMundoCompartilhado.Shared.UnitOfWork;
using System;

namespace MeuMundoCompartilhado.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
