using MeuMundoCompartilhado.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuMundoCompartilhado.Tests.Entities
{
    [TestClass]
    public class CompromissoTests
    {
        [TestMethod]
        public void Test_Construtor()
        {
            var descricao = "Compromisso";
            var data = DateTime.Now.AddDays(1);
            var compromisso = new Compromisso(descricao: descricao, data: data);
            Assert.IsNotNull(compromisso);
            Assert.AreEqual(compromisso.Descricao, descricao);
            Assert.AreEqual(compromisso.Data, data);
        }
    }
}