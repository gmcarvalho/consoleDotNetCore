using System;

namespace GameTop.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        public string Chutar() { 
            return $"{_Nome} está Chutando \n";
         }

        public string  Correr() { 
            return $"{_Nome} está Correndo \n";
        }

         public string passe() { 
            return $"{_Nome} está passendo \n";
        }
    }
}