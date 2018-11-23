using System;
namespace prova07_SistAposentadoria
{
    public class Pensao
    {
        public string Nome;
        public int Idade;
        public string Sexo;

        public void Aposenta()
        {

            if (Sexo == "feminino")
            {
                if (Idade >= 60)
                {
                    Console.Write("A Senhora {0} Pode Se Aposentar", Nome);
                }
            }
            else{
                Console.Write("Essa Pessoa ainda nao Pode Se Aposentar");
            }


                if (Sexo == "masculino")
            {
                if (Idade >= 65)
                {
                    Console.Write("O Senhor {0} Pode Se Aposentar", Nome);
                }
            }
            else
            {
                Console.Write("Essa Pessoa ainda nao Pode Se Aposentar");
            }


        }
            public Pensao()
            {
            }

    }
}
