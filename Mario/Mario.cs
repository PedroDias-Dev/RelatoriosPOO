using System;

namespace Aula10Polimorfismo
{
    public class Mario : Player
    {
        public override void Correr(){
            Console.WriteLine("Mario esta correndo mais rápido.");
        }
    }
}