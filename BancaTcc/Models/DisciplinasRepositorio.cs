using MySql.Data.MySqlClient;
using PexeiraConnectionClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class DisciplinasRepositorio
    {
        RepositorioDB conn = new RepositorioDB();
        public List<Disciplinas> disciplina = new List<Disciplinas>();

        public IEnumerable<Disciplinas> getAll()
        {
            //List<Disciplinas> disciplinas = new List<Disciplinas>();

            string sql = "select * from disciplinas";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                disciplina.Add(new Disciplinas((int)dr["id"], (string)dr["nome"]));

            }
            return disciplina;
        }

        public void Create(Disciplinas pDisciplina)
        {
            string sql = "insert into disciplinas values (";
            sql += pDisciplina.Id + ",'" + pDisciplina.Nome + "')";

            conn.executarComando(sql);
        }
        public Disciplinas GetOne(int pId)
        {
            string sql = "select * from disciplinas where Id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Disciplinas DisciplinasEditar = new Disciplinas((int)dr["id"], (string)dr["nome"]);

            return DisciplinasEditar;
        }
        public void Update(Disciplinas pDisciplina)
        {
            string sql = "update disciplinas set nome ='" + pDisciplina.Nome + "' where id =" + pDisciplina.Id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from disciplinas where Id =" + pId;
            conn.executarComando(sql);
        }
    }
}