using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class Semestre
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Semestre()
        {
            

        }

        public Semestre(int pId, string pNome)
        {
            Id = pId;
            Nome = pNome;
        }
    }
}