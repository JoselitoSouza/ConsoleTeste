namespace ConsoleCore
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome; 
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        public string Corre()
        {
            return $"{_Nome} correndo \n";
        }

        public string Passe()
        {
            return $"{_Nome} passando \n";
        }

        public string Chuta()
        {
            return $"{_Nome} chutando \n";
        }
    }
}