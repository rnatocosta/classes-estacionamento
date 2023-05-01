using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Veiculo
    {
        private int id;
        private string modelo;
        private string placa;

        public Veiculo(int id, string modelo, string placa)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Placa = placa;
        }

        public int Id { get => id; set => id = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
    }
}
