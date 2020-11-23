using CSharp_007_NotasAlunos.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_007_NotasAlunos.DAO
{
    public class NotaAlunoDAO
    {
        public int Insert(NotaAluno entity)
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO notaaluno (Nome, Nota1, Nota2, Nota3, Nota4, Media)" + 
                                       "VALUES (?nome, ?nota1, ?nota2, ?nota3, ?nota4, ?media)";

                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entity.Nome;
                command.Parameters.Add("?nota1", MySqlDbType.Float).Value = entity.Nota1;
                command.Parameters.Add("?nota2", MySqlDbType.Float).Value = entity.Nota2;
                command.Parameters.Add("?nota3", MySqlDbType.Float).Value = entity.Nota3;
                command.Parameters.Add("?nota4", MySqlDbType.Float).Value = entity.Nota4;
                command.Parameters.Add("?media", MySqlDbType.Float).Value = entity.Media;
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

        public bool Update(NotaAluno entity)
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
                command.Parameters.Add("?Nota1", MySqlDbType.Float).Value = entity.Nota1;
                command.Parameters.Add("?Nota2", MySqlDbType.Float).Value = entity.Nota2;
                command.Parameters.Add("?Nota3", MySqlDbType.Float).Value = entity.Nota3;
                command.Parameters.Add("?Nota4", MySqlDbType.Float).Value = entity.Nota4;
                command.Parameters.Add("?Media", MySqlDbType.Float).Value = entity.Media;
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entity.Id;

                
                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return true;
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
                return false;
            }            
        }

        public bool Delete(NotaAluno entity)
        {

            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM notaaluno WHERE Id = ?Id";
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entity.Id;

                //command.CommandText = "UPDATE Student 
                //SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return true;
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
                return false;
            }
        }
        public void Select(NotaAluno entity)
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
                command.Parameters.Add("?Nota1", MySqlDbType.Float).Value = entity.Nota1;
                command.Parameters.Add("?Nota2", MySqlDbType.Float).Value = entity.Nota2;
                command.Parameters.Add("?Nota3", MySqlDbType.Float).Value = entity.Nota3;
                command.Parameters.Add("?Nota4", MySqlDbType.Float).Value = entity.Nota4;
                command.Parameters.Add("?Media", MySqlDbType.Float).Value = entity.Media;
                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entity.Id;


                command.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return ;
                
            }
            catch (Exception exception)
            {
                string x = exception.InnerException.ToString();
                
            }
        }


    }
}
