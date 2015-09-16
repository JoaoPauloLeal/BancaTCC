using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class Disciplinas
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Disciplinas()
        {

        }
        public Disciplinas(int pId, string pNome)
        {
            Id = pId;
            Nome = pNome;
        }
    }
}