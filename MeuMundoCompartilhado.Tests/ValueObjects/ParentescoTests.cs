using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeuMundoCompartilhado.Tests.ValueObjects
{
    [TestClass]
    public class ParentescoTests
    {
        [TestMethod]
        public void Test_Construtor()
        {
            var tipo = TipoParentesco.Familiar;
            var descricao = "Tio";
            var parentesco = new Parentesco(tipo: tipo, descricao: descricao);
            Assert.IsNotNull(parentesco);
            Assert.AreEqual(parentesco.Tipo, tipo);
            Assert.AreEqual(parentesco.Descricao, descricao);
        }
    }
}