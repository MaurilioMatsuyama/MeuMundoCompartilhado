using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuMundoCompartilhado.Domain.ValueObjects
{
    public class StatusCompromisso : ValueObject
    {
        public SituacaoCompromisso Situacao { get; private set; }

        public string Descricao { get; private set; }

        public StatusCompromisso()
        {
            Situacao = SituacaoCompromisso.Agendado;
            Descricao = "Compromisso agendado";
        }
    }
}