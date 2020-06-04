using System;

namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {
        public override void  Pular(){
            base.Pular(); 
            Console.WriteLine("O Luigi pode pular 30% mais alto.");
        }
    }
}