using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_007_NotasAlunos
{
    public class Connection
    {
        
        public void connectionString()
        {
            //Aqui você substitui pelos seus dados
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                //command.CommandText = "CREATE TABLE IF NOT EXISTS `NotasAlunos` (" +
                //                        "`idAluno` INT AUTO_INCREMENT," +
                //                        "`nomeAluno`VARCHAR(30)," +
                //                        "`nota1` FLOAT," +
                //                        "`nota2` FLOAT," +
                //                        "`nota3` FLOAT," +
                //                        "`nota4` FLOAT," +
                //                        "`media` FLOAT," +
                //                        "PRIMARY KEY(idAluno))";
                //command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            
        }

        public void insereDados()
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO notasalunos (" +
                                        "nomeAluno," +
                                        "nota1 ," +
                                        "nota2 ," +
                                        "nota3 ," +
                                        "nota4 ," +
                                        "media) VALUES(?nome, ?nota1, ?nota2, ?nota3, ?nota4, ?media)";
                command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = "Henrique";
                command.Parameters.Add("?nota1", MySqlDbType.Float).Value = 10.0;
                command.Parameters.Add("?nota2", MySqlDbType.Float).Value = 9.0;
                command.Parameters.Add("?nota3", MySqlDbType.Float).Value = 8.0;
                command.Parameters.Add("?nota4", MySqlDbType.Float).Value = 7.0;
                command.Parameters.Add("?media", MySqlDbType.Float).Value = 6.0;


                //cmd.CommandText = "INSERT INTO room(person,address) VALUES(?person,?address)";
                //cmd.Parameters.Add("?person", MySqlDbType.VarChar).Value = "myname";
                //cmd.Parameters.Add("?address", MySqlDbType.VarChar).Value = "myaddress";
                //cmd.ExecuteNonQuery();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }

        public void updateDados()
        {
            var connString = "Server=localhost;Database=csharp_003;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "UPDATE notasalunos SET nomeAluno = ?nomeAluno, nota1 = ?nota1, nota2 = ?nota2," +
                                        "nota3 = ?nota4, nota4 = ?nota4, media = ?media WHERE idAluno = ?idAluno";

                                      
                command.Parameters.Add("?nomeAluno", MySqlDbType.VarChar).Value = "Felipe";
                command.Parameters.Add("?nota1", MySqlDbType.Float).Value = 8.9;
                command.Parameters.Add("?nota2", MySqlDbType.Float).Value = 10.0;
                command.Parameters.Add("?nota3", MySqlDbType.Float).Value = 7.0;
                command.Parameters.Add("?nota4", MySqlDbType.Float).Value = 5.0;
                command.Parameters.Add("?media", MySqlDbType.Float).Value = 8.0;
                command.Parameters.Add("?idAluno", MySqlDbType.Int32).Value = 1;

                //command.CommandText = "UPDATE Student 
                //SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }
    }
}
