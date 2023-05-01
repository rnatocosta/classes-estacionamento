using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Proprietario
    {
        private int id;
        private string nome;
        private Veiculo veiculo;

        public Proprietario(int id, string nome, Veiculo veiculo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Veiculo = veiculo;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Veiculo Veiculo { get => veiculo; set => veiculo = value; }
    }
}
