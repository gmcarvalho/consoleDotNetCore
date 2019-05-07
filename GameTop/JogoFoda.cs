using System;

namespace GameTop
{
    public class JogoFoda{
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB = jogadorB;
        }

        public void IniciarJogo(){
            Console.Write(_jogadorA.Chutar());
            Console.Write(_jogadorA.Correr());
            Console.Write(_jogadorA.passe());
                
            Console.Write("\n PROXIMO JOGADOR \n");

            Console.Write(_jogadorB.Chutar());
            Console.Write(_jogadorB.Correr());
            Console.Write(_jogadorB.passe());
        }
    }
}