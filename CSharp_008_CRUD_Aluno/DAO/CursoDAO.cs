using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using CSharp_008_CRUD_Aluno.Entities;
using CSharp_008_CRUD_Aluno.Interface;

namespace CSharp_008_CRUD_Aluno.DAO
{
    class CursoDAO : IDaoBase
    {
      
        public void Insert(Curso entity)
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO notaaluno (Nome, Nota1, Nota2, Nota3, Nota4, Media)" +
                                       "VALUES (?nome, ?sala, ?qtdAlunos, ?periodo)";

                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entity.Nome;
                command.Parameters.Add("?sala", MySqlDbType.Int32).Value = entity.Sala;
                command.Parameters.Add("?qtdAlunos", MySqlDbType.Int32).Value = entity.QtdAlunos;
                command.Parameters.Add("?periodo", MySqlDbType.VarChar).Value = entity.Periodo;
                //command.Parameters.Add("?idAluno", MySqlDbType.Int32).Value = entity.Id;


                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
            }
        }

        public void Select(Curso entity)
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO notaaluno (Nome, Nota1, Nota2, Nota3, Nota4, Media)" +
                                        "VALUES (?nome, ?sala, ?qtdAlunos, ?periodo)";

                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entity.Nome;
                command.Parameters.Add("?sala", MySqlDbType.Int32).Value = entity.Sala;
                command.Parameters.Add("?qtdAlunos", MySqlDbType.Int32).Value = entity.QtdAlunos;
                command.Parameters.Add("?periodo", MySqlDbType.Int32).Value = entity.Periodo;
                //command.Parameters.Add("?idAluno", MySqlDbType.Int32).Value = entity.Id;


                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
            }
        }

        public void Update(Curso entity)
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE notaaluno SET Nome = ?Nome, Nota1 = ?Nota1, Nota2 = ?Nota2," +
                                        "Nota3 = ?Nota3, Nota4 = ?Nota4, Media = ?Media WHERE Id = ?Id";

                command.Parameters.Add("?Nome", MySqlDbType.VarChar).Value = entity.Nome;
                command.Parameters.Add("?Nota1", MySqlDbType.Float).Value = entity.Sala;
                command.Parameters.Add("?Nota2", MySqlDbType.Float).Value = entity.QtdAlunos;
                command.Parameters.Add("?Nota3", MySqlDbType.Float).Value = entity.Periodo;
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entity.Id;


                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString(); 
            }
        }

        public void Delete(Curso entity)
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM notaaluno WHERE Id = ?Id";
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entity.Id;

                
                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
            }
        }
    }
}
