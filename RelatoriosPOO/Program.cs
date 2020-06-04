using System;

namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio();
            Mensal relatorio_mensal = new Mensal();
            Anual relatorio_anual = new Anual();
            
            relatorio_anual.MostrarRelatorio();
            relatorio_mensal.MostrarRelatorio();
        }
    }
}
