using MySql.Data.MySqlClient;
using PexeiraConnectionClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTcc.Models
{
    public class SemestreRepositorio
    {
        RepositorioDB conn = new RepositorioDB();
        public List<Semestre> semestre = new List<Semestre>();

        public IEnumerable<Semestre> getAll()
        {
            //List<Semestre> semestre = new List<Semestre>();

            string sql = "select * from semestres";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                semestre.Add(new Semestre((int)dr["id"], (string)dr["nome"]));

            }
            return semestre;
        }

        public void Create(Semestre pSemestre)
        {
            string sql = "insert into semestres values (";
            sql += pSemestre.Id + ",'" + pSemestre.Nome + "')";

            conn.executarComando(sql);
        }
        public Semestre GetOne(int pId)
        {
            string sql = "select * from semestres where Id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Semestre SemestreEditar = new Semestre((int)dr["id"], (string)dr["nome"]);

            return SemestreEditar;
        }
        public void Update(Semestre pSemestre)
        {
            string sql = "update semestres set nome ='" + pSemestre.Nome + "' where id =" + pSemestre.Id;
            conn.executarComando(sql);

        }
        public void Delete(int pId)
        {
            string sql = "delete from semestres where Id =" + pId;
            conn.executarComando(sql);
            //semestre.RemoveAt(semestre.FindIndex(x => x.Id == pId));
        }
    }
}