using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Homem De Ferro";
            objetoPersonagem1.idade = 53;
            objetoPersonagem1.armadura = "Destruidora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Capitão America";
            objetoPersonagem2.idade = 39;
            objetoPersonagem2.armadura = "Indestrutível";

            Console.WriteLine($"Personagem1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }
    }
}
