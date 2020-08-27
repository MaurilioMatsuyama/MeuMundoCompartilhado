using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeuMundoCompartilhado.Tests.ValueObjects
{
    [TestClass]
    public class StatusCompromissoTests
    {
        [TestMethod]
        public void Test_Construtor()
        {
            var statusCompromisso = new StatusCompromisso();
            Assert.IsNotNull(statusCompromisso);
            Assert.AreEqual(statusCompromisso.Situacao, SituacaoCompromisso.Agendado);
            Assert.AreEqual(statusCompromisso.Descricao, "Compromisso agendado");
        }
    }
}