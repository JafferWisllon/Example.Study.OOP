﻿namespace Example.Study.OOP.Abstracao
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public void Testar()
        {
            // teste do equipamento
        }
    }
}