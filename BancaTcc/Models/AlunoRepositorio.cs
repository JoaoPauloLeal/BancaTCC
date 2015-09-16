using MySql.Data.MySqlClient;
using PexeiraConnectionClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class AlunoRepositorio
    {
        RepositorioDB conn = new RepositorioDB();
        private List<Aluno> aluno = new List<Aluno>();

        public IEnumerable<Aluno> getAll()
        {
            //List<Aluno> aluno = new List<Aluno>();

            string sql = "select * from alunos";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                aluno.Add(new Aluno((int)dr["id"], (string)dr["nome"]));

            }
            return aluno;
        }

        public void Create(Aluno pAluno)
        {
            string sql = "insert into alunos values (";
            sql += pAluno.Id+ ",'"+pAluno.Nome+"')";

            conn.executarComando(sql);

        }
        public Aluno GetOne(int pId)
        {
            string sql = "select * from alunos where Id ="+pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Aluno AlunoEditando = new Aluno((int)dr["id"],(string)dr["nome"]);
            
            return AlunoEditando;
        }
        public void Update(Aluno pAluno)
        {
            string sql = "update alunos set nome ='" + pAluno.Nome + "' where id ="+pAluno.Id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from alunos where Id ="+pId;
            conn.executarComando(sql);
            //aluno.RemoveAt(aluno.FindIndex(x => x.Id == pId));
        }
    }
}