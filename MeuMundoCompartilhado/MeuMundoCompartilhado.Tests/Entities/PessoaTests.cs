using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MeuMundoCompartilhado.Tests.Entities
{
    [TestClass]
    public class PessoaTests
    {
        [TestMethod]
        public void Test_Construtor()
        {
            var nome = "Julius";
            var sobrenome = "Rock";
            var dataAniversario = new DateTime(1990, 1, 1);
            var parentesco = new Parentesco(tipo: TipoParentesco.Amigo, descricao: "Amigo da família");
            var pessoa = new Pessoa(nome: nome, sobrenome: sobrenome, dataAniversario: dataAniversario, parentesco);
            var compromisso = new Compromisso(descricao: "Compromisso urgente", data: DateTime.Now.AddDays(1));
            pessoa.AdicionaCompromisso(compromisso);

            Assert.IsNotNull(pessoa);
            Assert.IsTrue(pessoa.Compromissos.Count == 1);
        }
    }
}