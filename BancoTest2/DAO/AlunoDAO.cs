using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using BancoTest2.Entidades;

namespace BancoTest2.DAO
{
    class AlunoDAO: Aluno
    {
        public int InputData(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste2;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO aluno (Nome, Idade, Endereco, Telefone)" +
                                       "VALUES (?nome, ?idade, ?endereco, ?telefone)";

                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entidade.Nome;
                command.Parameters.Add("?idade", MySqlDbType.Int32).Value = entidade.Idade;
                command.Parameters.Add("?endereco", MySqlDbType.VarChar).Value = entidade.Endereco;
                command.Parameters.Add("?telefone", MySqlDbType.VarChar).Value = entidade.Telefone;
                
                Console.WriteLine("Comando executado com sucesso!");
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

        public void ShowData(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste2;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            
            try
            {
                connection.Open();
                command.CommandText = "SELECT Nome, Idade, Endereco, Telefone FROM aluno WHERE Id = ?id";

                command.Parameters.Add("?Id", MySqlDbType.Int32).Value = entidade.Id;

                MySqlDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    Console.WriteLine($"Nome: {rd["Nome"]} Idade: {rd["Idade"]} Endereço: {rd["Endereco"]} Telefone: {rd["Telefone"]}");
                }

                Console.WriteLine("Comando executado com sucesso!");

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                rd.Close();

                
            }
            catch (Exception exception)
            {
                Console.WriteLine("Não foi possível realizar a consulta");
            }

        }

        public void UpdateData(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste2;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE aluno SET Nome = ?nome, Idade = ?idade, Endereco = ?endereco," +
                                        "Telefone = ?telefone WHERE Id = ?id";

                
                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = entidade.Nome;
                command.Parameters.Add("?idade", MySqlDbType.Int32).Value = entidade.Idade;
                command.Parameters.Add("?endereco", MySqlDbType.VarChar).Value = entidade.Endereco;
                command.Parameters.Add("?telefone", MySqlDbType.VarChar).Value = entidade.Telefone;
                command.Parameters.Add("?id", MySqlDbType.Int32).Value = entidade.Id;

                command.ExecuteReader();
                Console.WriteLine("Comando executado com sucesso!");
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                
            }
            catch (Exception exception)
            {
                Console.WriteLine("Não foi possível realizar a query");
            }
        }

        public void DeleteData(Aluno entidade)
        {
            var connString = "Server=localhost;Database=teste2;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM aluno WHERE Id = ?id";

                command.Parameters.Add("?id", MySqlDbType.Int32).Value = entidade.Id;

                command.ExecuteReader();

                Console.WriteLine("Comando executado com sucesso!");

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Não foi possível deletar o registro informado");
            }

        }

    }
}
