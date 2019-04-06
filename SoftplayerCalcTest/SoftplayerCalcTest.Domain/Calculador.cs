using System;

namespace SoftplayerCalcTest.Domain
{
    public class Calculador
    {
        private const int CasasDecimais = 2;

        public Calculador(decimal valorInicial, int meses)
        {
            Id = Guid.NewGuid();
            TaxaJuros = 0.01;
            ValorInicial = valorInicial;
            Meses = meses;
        }

        public Guid Id { get; }
        public decimal ValorInicial { get; }
        public double TaxaJuros { get; }
        public int Meses { get; }

        public decimal ValorFinal()
        {
            var jurosTempo = (decimal)Math.Pow(TaxaJuros + 1, Meses);
            return TruncateDecimal(ValorInicial * jurosTempo, CasasDecimais);
        }
        
        private static decimal TruncateDecimal(decimal valor, int casasDecimais)
        {
            var passo = (decimal)Math.Pow(10, casasDecimais);
            var tmp = Math.Truncate(passo * valor);
            return tmp / passo;
        }
    }
}
