using System;

namespace RelatoriosPOO
{
    public class Relatorio
    {
        public DateTime data;
	    public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrando relatório geral");
        }
		
    }
}