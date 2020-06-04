using System;

namespace Aula10Polimorfismo
{
    public class Player
    {
        public virtual void Pular(){
            Console.WriteLine("O personagem esta pulando normalmente.");
        }
        public virtual void Correr(){
            Console.WriteLine("O personagem esta correndo normalmente.");
        }
    }
}