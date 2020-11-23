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
            var notaAlunoDao = new NotaAlunoDAO();
            
            //FILL OBJECT
            notaAluno.Nome = "Henrique Dionisio";
            notaAluno.Nota1 = 10;
            notaAluno.Nota2 = 8;
            notaAluno.Nota3 = 4;
            notaAluno.Nota4 = 5;
            notaAluno.Media = (notaAluno.Nota1 + notaAluno.Nota2 + notaAluno.Nota3 + notaAluno.Nota4) / 4;
            notaAlunoDao.Insert(notaAluno);
            #endregion //ENTITY

            #region DAO
            var dao = new NotaAlunoDAO();

            //for (int i = 0;i < 400; ++i)
            //    dao.Insert(notaAluno);

            notaAluno.Id = 1;
            //dao.Delete(notaAluno);
            dao.Select(notaAluno);


            //notaAluno.Nome = "Steve Jobs";
            //dao.Update(notaAluno);
            #endregion //DAO

        }
    }
}
