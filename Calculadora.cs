using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitariosNUnit.Test
{
    public class Calculadora
    {
        public int CalculoMatematicoSimples(int primeiroValor, int segundoValor, OperacaoEnum operacao)
        {
            if (operacao == OperacaoEnum.Adicao)
                return primeiroValor + segundoValor;

            if (operacao == OperacaoEnum.Subtracao)
                return primeiroValor - segundoValor;

            if (operacao == OperacaoEnum.Divisao)
                return primeiroValor / segundoValor;

            if (operacao == OperacaoEnum.Multiplicacao)
                return primeiroValor * segundoValor;

            return 0;
        }
    }
}
