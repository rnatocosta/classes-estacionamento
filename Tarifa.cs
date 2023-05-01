using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Tarifa
    {
        private int id;
        private string valorTarifa;
        private DateTime data;

        public Tarifa(int id, string valorTarifa, DateTime data)
        {
            this.Id = id;
            this.ValorTarifa = valorTarifa;
            this.Data = data;
        }

        public int Id { get => id; set => id = value; }
        public string ValorTarifa { get => valorTarifa; set => valorTarifa = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
