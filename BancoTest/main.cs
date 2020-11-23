using System;
using BancoTest.DAO;
using BancoTest.Entities;

namespace BancoTest
{
    class main
    {
        static void Main(string[] args)
        {
            var alunoDao = new AlunoDao();
            var aluno1 = new Aluno();
            //aluno1.Nome = "Paulo";
            //aluno1.Nota1 = 9;
            //aluno1.Nota2 = 8;
            //aluno1.Nota3 = 7;
            //aluno1.Nota4 = 6;
            //aluno1.Media = (aluno1.Nota1 + aluno1.Nota2 + aluno1.Nota3 + aluno1.Nota4) / 4;
            //alunoDao.Insert(aluno1);
            aluno1.Id = 3;
            Console.WriteLine(alunoDao.Select(aluno1));
            //aluno1.Nome = "Carlos";
            //alunoDao.Update(aluno1);
            //aluno1.Id = 2;
            //alunoDao.Delete(aluno1);
           
        }
    }
}
