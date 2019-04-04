using System;

namespace SoftplayerCalcTest.Domain
{
    public class Calculador
    {
        private const int CASAS_DECIMAIS = 2;

        public Calculador(decimal valorInicial, int meses)
        {
            Id = Guid.NewGuid();
            TaxaJuros = 0.01;
            ValorInicial = valorInicial;
            Meses = meses;
        }

        public Guid Id { get; private set; }
        public decimal ValorInicial { get; private set; }
        public double TaxaJuros { get; private set; }
        public int Meses { get; private set; }

        public decimal ValorFinal()
        {
            var jurosTempo = (decimal)Math.Pow(TaxaJuros + 1, Meses);
            return TruncateDecimal(ValorInicial * jurosTempo, CASAS_DECIMAIS);
        }
        
        private decimal TruncateDecimal(decimal valor, int casasDecimais)
        {
            decimal passo = (decimal)Math.Pow(10, casasDecimais);
            decimal tmp = Math.Truncate(passo * valor);
            return tmp / passo;
        }
    }
}
