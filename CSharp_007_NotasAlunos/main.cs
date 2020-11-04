using CSharp_007_NotasAlunos.DAO;
using CSharp_007_NotasAlunos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_007_NotasAlunos
{
    class main : Connection
    {
        static void Main()
        {

            #region ENTITY
            var notaAluno = new NotaAluno();

            
            //FILL OBJECT
            notaAluno.Nome = "John Doeeeeeeeeejjjjjjjjjeeeeee";
            notaAluno.Nota1 = 1;
            notaAluno.Nota2 = 2;
            notaAluno.Nota3 = 3;
            notaAluno.Nota4 = 4;
            notaAluno.Media = 5;
            #endregion //ENTITY

            #region DAO
            var dao = new NotaAlunoDAO();

            for (int i = 0;i < 400; ++i)
                dao.Insert(notaAluno);

            



            notaAluno.Nome = "Steve Jobs";
            dao.Update(notaAluno);
            #endregion //DAO

        }
    }
}
