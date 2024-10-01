using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.BD
{
    public class Database
    {
        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string db_name = "AULA_DS";

        private void CreateDatabase()
        {
            string sql = "CREATE DATABASE AULA_DS;" +
                "USE AULA_DS;" +
                "CREATE TABLE PROFESSORES (" +
                "   Id INT PRIMARY KEY AUTO_INCREMENT," +
                "   Nome VARCHAR(50) NOT NULL," +
                "   Apelido VARCHAR(15) NOT NULL" +
                ");" +
                "CREATE TABLE SALAS (" +
                "   Id INT PRIMARY KEY AUTO_INCREMENT," +
                "   Nome VARCHAR(30) NOT NULL," +
                "   NumeroComputadores INT NOT NULL," +
                "   NumeroCadeiras INT NOT NULL," +
                "   IsLab BIT NOT NULL," +
                "   Disponivel BIT NOT NULL" +
                ");" +
                "CREATE TABLE DISCIPLINAS (" +
                "   Id INT PRIMARY KEY AUTO_INCREMENT," +
                "   Nome VARCHAR(60) NOT NULL," +
                "   Sigla VARCHAR(8) NOT NULL" +
                ");" +
                "CREATE TABLE CURSOS (" +
                "   Id INT PRIMARY KEY AUTO_INCREMENT," +
                "   Nome VARCHAR(50) NOT NULL," +
                "   Turno VARCHAR(10) NOT NULL," +
                "   Sigla VARCHAR(10) NOT NULL" +
                ");" +
                "CREATE TABLE CURSO_DISCIPLINA (" +
                "   Id INT PRIMARY KEY AUTO_INCREMENT," +
                "   Periodo VARCHAR(15) NOT NULL," +
                "   Disciplina_Id INT NOT NULL," +
                "   Curso_Id INT NOT NULL," +
                "   CONSTRAINT  FK_DISCIPLINA FOREIGN KEY (Disciplina_Id) REFERENCES DISCIPLINAS(Id)," +
                "   CONSTRAINT  FK_CURSOS FOREIGN KEY (Curso_Id) REFERENCES CURSOS(Id)" +
                ");" +
                "" +
                "" +
                "";
        }
    }
}
