using Calculadora;

namespace CalculadoraTest
{
    [TestClass]
    public sealed class OperacoesUnitTest
    {
        private Operacoes operacoes;

        [TestInitialize]
        public void setup()
        {
            operacoes = new Operacoes();
        }


        [TestMethod]
        [DataRow(10,10, 20)]
        [DataRow(5,10, 15)]
        [DataRow(10,-5, 5)]
        [DataRow(0,0,0)]
        public void DeveRetornarSoma(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.soma(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(10,10, 0)]
        [DataRow(-5,-5, 0)]
        [DataRow(0,-5, -5)]
        [DataRow(23,7, 16)]
        public void DeveRetornarSubtracao(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.subtracao(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }


        [TestMethod]
        [DataRow(10, 10, 100)]
        [DataRow(5, 5, 25)]
        [DataRow(0, -5, 0)]
        [DataRow(20, 5, 100)]
        [DataRow(5, -5, -25)]
        [DataRow(-5, -5, 25)]
        public void DeveRetornarMultiplicacao(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.multiplicacao(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(10,10,1)]
        [DataRow(10,2,5)]
        [DataRow(10,0,0)]
        [DataRow(0,0,0)]
        [DataRow(0,10,0)]
        [DataRow(10,-5,-2)]
        [DataRow(-10,-5,2)]
        public void DeveRetornarDivisao(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.divisao(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(2,2,4)]
        [DataRow(1,2,1)]
        [DataRow(5,2,25)]
        [DataRow(10,4,10000)]
        [DataRow(10,0,1)]
        [DataRow(112830,0,1)]
        public void DeveRetornarExponenciacao(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.exponenciacao(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(10,5,1.43f)]
        [DataRow(2,4,0.5f)]
        [DataRow(9,5,1.36f)]
        public void DeveRetornarLog(double a, double b, double esperado)
        {
            // Act
            double obtido = operacoes.log(a, b);

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }


        [TestMethod]
        [DataRow(1500, 0.5, 2, 3375f)]
        [DataRow(100, 0.05, 12, 179.58f)]
        [DataRow(15000, 0.01, 6, 15922.80f)]
        [DataRow(15, 0, 9, 15f)]
        public void DeveRetornarMontanteFuturo(double valorPresente, double taxaJurosMensal, int quantidadeMeses, double esperado)
        {
            // Act
            double obtido = Operacoes.CalcularMontanteFuturo(valorPresente, taxaJurosMensal, quantidadeMeses);

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }
    }
}
