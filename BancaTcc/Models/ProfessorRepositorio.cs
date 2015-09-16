using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using PexeiraConnectionClassLibrary;

namespace BancaTcc.Models
{
    public class ProfessorRepositorio
    {
        RepositorioDB conn = new RepositorioDB();
        private List<Professor> professor = new List<Professor>();

        public IEnumerable<Professor> getAll()
        {
            //List<Professor> professor = new List<Professor>();

            string sql = "select * from professores";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                professor.Add(new Professor((int)dr["id"],(string)dr["nome"]));
                
            }
            return professor;
        }
        public void Create(Professor pProfessor)
        {
            string sql = "insert into professores values (";
            sql += pProfessor.Id + ",'" + pProfessor.Nome + "')";

            conn.executarComando(sql);
        }
        public Professor GetOne(int pId)
        {
            string sql = "select * from professores where Id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Professor ProfessorEditar = new Professor((int)dr["id"], (string)dr["nome"]);

            return ProfessorEditar;
        }
        public void Update(Professor pProfessor)
        {
            string sql = "update professores set nome ='" + pProfessor.Nome + "' where id =" + pProfessor.Id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from professores where Id =" + pId;
            conn.executarComando(sql);
            //professor.RemoveAt(professor.FindIndex(x => x.Id == pId));
        }
    }
}