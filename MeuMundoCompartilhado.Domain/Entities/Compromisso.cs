using MeuMundoCompartilhado.Domain.ValueObjects;
using MeuMundoCompartilhado.Shared.Entities;
using System;

namespace MeuMundoCompartilhado.Domain.Entities
{
    public class Compromisso : Entity
    {
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public StatusCompromisso Status { get; private set; }

        public Compromisso(string descricao, DateTime data)
        {
            Descricao = descricao;
            Data = data;
            Status = new StatusCompromisso();
        }
    }
}