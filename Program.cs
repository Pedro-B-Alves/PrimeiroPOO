using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            bool defesa1 = false;
            bool defesa2 = false;

            Personagem objetoPersonagem1 = new Personagem();
            Console.WriteLine("Qual é o nome do 1º Personagem");
            objetoPersonagem1.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do 1º Personagem");
            objetoPersonagem1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome da armadura do 1º Personagem");
            objetoPersonagem1.armadura = Console.ReadLine();

            Personagem objetoPersonagem2 = new Personagem();
            Console.WriteLine("Qual é o nome do 2º Personagem");
            objetoPersonagem2.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do 2º Personagem");
            objetoPersonagem2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome da armadura do 2º Personagem");
            objetoPersonagem2.armadura = Console.ReadLine();

            

            Combate vida = new Combate();
            
            do
            {   
                defesa1 = false;
                defesa2 = false;
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Rodada {contador}");
                Console.WriteLine($"Personagem1 = {objetoPersonagem1.nome} - Vida = {vida.vidaPersonagem1}");
                Console.WriteLine($"Personagem2 = {objetoPersonagem2.nome} - Vida = {vida.vidaPersonagem2}");
                vida.vidaPersonagem1Salvo = vida.vidaPersonagem1;
                vida.vidaPersonagem2Salvo = vida.vidaPersonagem2;
                String[] acaoMaquina = {"Ataque", "Defesa","Ataque Especial"};
                Random aleatorio = new Random();
                int r = aleatorio.Next(acaoMaquina.Length);
                    Console.WriteLine("Digite a Ação - (1)Ataque - (2)Defesa - (3)Ataque Especial");
                    Console.WriteLine($"O Ataque Especial só funciona em Rodadas Pares e se você o ultilizar errado receberá dano.");
                    int acao = int.Parse(Console.ReadLine());
                    switch (acao)
                    {
                        case 1:
                            Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.Atacar()}");
                            Console.WriteLine($"O {objetoPersonagem1.nome} usou Ataque");
                            vida.vidaPersonagem2 = vida.vidaPersonagem2 - 800;
                            break;
                        case 2:
                            Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.Defender()}");
                            Console.WriteLine($"O {objetoPersonagem1.nome} usou Defesa");
                            defesa1 = true;
                            break;
                        case 3:
                            if(contador%2 == 0){
                                Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.Especial()}");
                                Console.WriteLine($"O {objetoPersonagem1.nome} usou o Ataque Especial");
                                vida.vidaPersonagem2 = vida.vidaPersonagem2 - 1200;
                            }else{
                                Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.EspecialFalho()}");
                                Console.WriteLine($"O {objetoPersonagem1.nome} tentou usar o Ataque Especial e falhou");
                                vida.vidaPersonagem1 = vida.vidaPersonagem1 - 200;
                            }
                            break;
                        default:
                            Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.FazerNada()}");
                            Console.WriteLine("Você digitou um número inválido, então você não atacou e nem defendeu."); 
                            break;
                    }
                        switch ((string)acaoMaquina[r])
                        {
                            case "Ataque":
                                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.Atacar()}");
                                Console.WriteLine($"O {objetoPersonagem2.nome} usou Ataque");
                                vida.vidaPersonagem1 = vida.vidaPersonagem1 - 800;
                                break;
                            case "Defesa":
                                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.Defender()}");
                                Console.WriteLine($"O {objetoPersonagem2.nome} usou Defesa");
                                defesa2 = true;
                                break;
                            case "Ataque Especial":
                                if(contador%2 == 0){
                                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.Especial()}");
                                Console.WriteLine($"O {objetoPersonagem2.nome} usou o Ataque Especial");
                                vida.vidaPersonagem1 = vida.vidaPersonagem1 - 1200;
                                }else{
                                    Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.EspecialFalho()}");
                                    Console.WriteLine($"O {objetoPersonagem2.nome} tentou usar o Ataque Especial e falhou");
                                    vida.vidaPersonagem2 = vida.vidaPersonagem2 - 200;
                                }
                                break;
                            default:
                                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.FazerNada()}");
                                Console.WriteLine($"{objetoPersonagem2.nome} não atacou e nem defendeu.");
                                break;
                        }
                        if (defesa1 == true)
                        {
                            vida.vidaPersonagem1 = vida.vidaPersonagem1Salvo;
                        }
                        if (defesa2 == true)
                        {
                            vida.vidaPersonagem2 = vida.vidaPersonagem2Salvo;
                        }
                contador = contador + 1;
            } while ((vida.vidaPersonagem1 > 0) && (vida.vidaPersonagem2 > 0));

            if ((vida.vidaPersonagem1 > 0) && (vida.vidaPersonagem2 > 0))
            {
                Console.WriteLine("Empate");
                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.Empate()}");
            }else if (vida.vidaPersonagem1 > 0){
                Console.WriteLine($"{objetoPersonagem1.nome} Venceu");
                Console.WriteLine($"{objetoPersonagem1.nome}: {objetoPersonagem1.Vitoria()}");
            }else{
                Console.WriteLine($"{objetoPersonagem2.nome} Venceu");
                Console.WriteLine($"{objetoPersonagem2.nome}: {objetoPersonagem2.Vitoria()}");
            }
        }
    }
}
