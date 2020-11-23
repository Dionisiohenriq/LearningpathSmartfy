using System;
using BancoTest2.DAO;
using BancoTest2.Entidades;

namespace BancoTest2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while(menu != -1)
            {
                Console.WriteLine("Insira a opção desejada: ");
                Console.WriteLine("(1)Cadastrar aluno: ");
                Console.WriteLine("(2)Pesquisar aluno: ");
                Console.WriteLine("(3)Atualizar aluno: ");
                Console.WriteLine("(4)Deletar aluno: ");
                Console.WriteLine("(-1)Para Sair: ");
                menu = Int32.Parse(Console.ReadLine());

                switch(menu) 
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Pesquisar();
                        break;
                    case 3:
                        Atualizar();
                        break;
                    case 4:
                        Deletar();
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção correspondente.");
                        break;
                }

            }
        }

        public static void Cadastrar()
        {
            AlunoDAO aluno1 = new AlunoDAO();

            Console.WriteLine("Insira dados de um aluno: Nome, Idade, Endereco, Telefone");
            // Coleta dos dados e inserção através da classe Input
            Console.WriteLine("Nome: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            aluno1.Idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Endereço: ");
            aluno1.Endereco = (Console.ReadLine());
            Console.WriteLine("Telefone: ");
            aluno1.Telefone = (Console.ReadLine());
            aluno1.InputData(aluno1);
        }
        public static void Pesquisar()
        {
            AlunoDAO aluno1 = new AlunoDAO();
            // Pesquisa por ID
            Console.WriteLine("Insira um ID a ser pesquisado: ");
            aluno1.Id = Int32.Parse(Console.ReadLine());
            aluno1.ShowData(aluno1);

        }

        public static void Atualizar()
        {
            AlunoDAO aluno1 = new AlunoDAO();
            // Update por ID
            Console.WriteLine("Insira os dados novos para o ID correspondente: ");
            Console.WriteLine("Novo nome: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Nova idade: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Novo Endereço: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Novo Telefone: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Insira o ID a ser atualizado: ");
            aluno1.Id = Int32.Parse(Console.ReadLine());
            aluno1.UpdateData(aluno1);
        }
        
        public static void Deletar()
        {
            AlunoDAO aluno1 = new AlunoDAO();
            // Delete por ID
            Console.WriteLine("Insira o ID a ser deletado do banco de dados: ");
            aluno1.Id = Int32.Parse(Console.ReadLine());
            aluno1.DeleteData(aluno1);
        }
    }
}
