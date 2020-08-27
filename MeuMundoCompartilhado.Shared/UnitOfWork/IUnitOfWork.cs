using System;
using System.Collections.Generic;
using System.Text;

namespace MeuMundoCompartilhado.Shared.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        void RollBack();
    }
}