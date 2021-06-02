using MeuMundoCompartilhado.Domain.ValueObjects;
using MeuMundoCompartilhado.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuMundoCompartilhado.Domain.Entities
{
    public class Pessoa : Entity
    {
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public DateTime DataAniversario { get; private set; }

        public Parentesco Parentesco { get; private set; }

        private IList<Compromisso> _compromissos;
        public IReadOnlyCollection<Compromisso> Compromissos { get { return _compromissos.ToArray(); } }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, DateTime dataAniversario, Parentesco parentesco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataAniversario = dataAniversario;
            Parentesco = parentesco;
            _compromissos = new List<Compromisso>();
        }

        public void AdicionaCompromisso(Compromisso compromisso)
        {
            _compromissos.Add(compromisso);
        }
    }
}