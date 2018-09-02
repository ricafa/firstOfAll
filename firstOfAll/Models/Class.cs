using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstOfAll.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string ativo { get; set; }
        public float peso { get; set; }
        public int numerocalcado { get; set; }
    }
}
