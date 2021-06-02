using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Shared.ValueObjects;

namespace MeuMundoCompartilhado.Domain.ValueObjects
{
    public class Parentesco : ValueObject
    {
        public TipoParentesco Tipo { get; private set; }

        public string Descricao { get; private set; }

        public Parentesco()
        {

        }

        public Parentesco(TipoParentesco tipo, string descricao)
        {
            Tipo = tipo;
            Descricao = descricao;
        }
    }
}