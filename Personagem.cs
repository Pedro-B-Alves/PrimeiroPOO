namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;

        public string Atacar(){
            return "Você não pode com o meu ataque";
        }

        public string Defender(){
            return "Não foi dessa vez!";
        }

        public string Especial(){
            return "Agora você provará todo o meu poder";
        }

        public string EspecialFalho(){
            return "Isso não vai fica assim";
        }

        public string FazerNada(){
            return "Isso está fácil de mais";
        }

        public string Vitoria(){
            return "Nem cansei";
        }

        public string Empate(){
            return "Você vai ver na próxima vez";
        }
    }
}