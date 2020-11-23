using System;
using System.Collections.Generic;
using System.Text;
using BancoTest.Interface;
using BancoTest.Entities;
using MySql.Data.MySqlClient;

namespace BancoTest.DAO
{
    class AlunoDao : Aluno, IAluno
    {
        public int Insert(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO aluno (Nome, Nota1, Nota2, Nota3, Nota4, Media)" +
                                       "VALUES (?nome, ?nota1, ?nota2, ?nota3, ?nota4, ?media)";

                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entidade.Nome;
                command.Parameters.Add("?nota1", MySqlDbType.Double).Value = entidade.Nota1;
                command.Parameters.Add("?nota2", MySqlDbType.Double).Value = entidade.Nota2;
                command.Parameters.Add("?nota3", MySqlDbType.Double).Value = entidade.Nota3;
                command.Parameters.Add("?nota4", MySqlDbType.Double).Value = entidade.Nota4;
                command.Parameters.Add("?media", MySqlDbType.Double).Value = entidade.Media;
                //command.Parameters.Add("?idAluno", MySqlDbType.Int32).Value = entity.Id;

                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return (int)command.LastInsertedId;
            }
            catch (Exception exception)
            {
                return 0;
            }
        }

        public string Select(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM aluno";

                ////command.Parameters.Add("?Nome", MySqlDbType.VarChar).Value = entidade.Nome;
                ////command.Parameters.Add("?Nota1", MySqlDbType.Float).Value = entidade.Nota1;
                ////command.Parameters.Add("?Nota2", MySqlDbType.Float).Value = entidade.Nota2;
                ////command.Parameters.Add("?Nota3", MySqlDbType.Float).Value = entidade.Nota3;
                ////command.Parameters.Add("?Nota4", MySqlDbType.Float).Value = entidade.Nota4;
                ////command.Parameters.Add("?Media", MySqlDbType.Float).Value = entidade.Media;
                ////command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entidade.Id;


                command.ExecuteNonQuery();
                return Nome + " " + Media;
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
                return "Erro" + x;
            }
        }

        public void Update(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE aluno SET Nome = ?Nome, Nota1 = ?Nota1, Nota2 = ?Nota2," +
                                        "Nota3 = ?Nota3, Nota4 = ?Nota4, Media = ?Media WHERE Id = ?Id";

                command.Parameters.Add("?Nome", MySqlDbType.VarChar).Value = entidade.Nome;
                command.Parameters.Add("?Nota1", MySqlDbType.Float).Value = entidade.Nota1;
                command.Parameters.Add("?Nota2", MySqlDbType.Float).Value = entidade.Nota2;
                command.Parameters.Add("?Nota3", MySqlDbType.Float).Value = entidade.Nota3;
                command.Parameters.Add("?Nota4", MySqlDbType.Float).Value = entidade.Nota4;
                command.Parameters.Add("?Media", MySqlDbType.Float).Value = entidade.Media;
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entidade.Id;


                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();

            }
        }
        public void Delete(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM aluno WHERE Id = ?Id";
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entidade.Id;

                //command.CommandText = "UPDATE Student 
                //SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
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
