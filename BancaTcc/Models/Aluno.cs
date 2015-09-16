using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Aluno()
        {

        }
        public Aluno(int pId, string pNome)
        {
            Id = pId;
            Nome = pNome;
        }
        
    }
}