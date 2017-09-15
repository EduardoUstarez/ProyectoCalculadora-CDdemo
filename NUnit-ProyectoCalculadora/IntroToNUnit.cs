using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProyectoCalculadora.Models;

namespace NUnit_ProyectoCalculadora
{
  [TestFixture]
  class IntroToNUnit
  {
    [Test]
    public void TestResta() {
      var TestCalculadora = new Calculadora();
      int resultado = TestCalculadora.restar(4, 2);
     
      Assert.AreEqual(2, resultado);
    }

  }
}
