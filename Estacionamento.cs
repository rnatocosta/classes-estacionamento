using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Estacionamento
    {
        private int id;
        private string numero;
        private Boolean liberada;
        private Tarifa tarifa;

        public Estacionamento(int id, string numero, bool liberada, Tarifa tarifa)
        {
            this.Id = id;
            this.Numero = numero;
            this.Liberada = liberada;
            this.Tarifa = tarifa;
        }

        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public bool Liberada { get => liberada; set => liberada = value; }
        internal Tarifa Tarifa { get => tarifa; set => tarifa = value; }
    }
}
