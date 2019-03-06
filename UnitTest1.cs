using System;


using NUnit.Framework;

namespace TestesUnitariosNUnit.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        [Test]
        public void DeveRetornarASomaCorretamente()
        {
            int primeiroValor = 10;
            int segundoValor = 20;
            int resultado = new Calculadora().CalculoMatematicoSimples(primeiroValor, segundoValor, OperacaoEnum.Adicao);
            Assert.AreEqual(30, resultado);
        }

        [Test]
        public void DeveRetornarASubtracaoCorretamente()
        {
            int primeiroValor = 20;
            int segundoValor = 10;
            int resultado = new Calculadora().CalculoMatematicoSimples(primeiroValor, segundoValor, OperacaoEnum.Subtracao);
            Assert.AreEqual(10, resultado);
        }


        [Test]
        public void DeveRetornarADivisaoCorretamente()
        {
            int primeiroValor = 20;
            int segundoValor = 10;
            int resultado = new Calculadora().CalculoMatematicoSimples(primeiroValor, segundoValor, OperacaoEnum.Divisao);
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void DeveRetornarAMultiplicacaoCorretamente()
        {
            int primeiroValor = 10;
            int segundoValor = 20;
            int resultado = new Calculadora().CalculoMatematicoSimples(primeiroValor, segundoValor, OperacaoEnum.Multiplicacao);
            Assert.AreEqual(200, resultado);
        }
    }
}