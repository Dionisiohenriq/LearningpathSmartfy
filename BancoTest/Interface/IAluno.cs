using System;
using System.Collections.Generic;
using System.Text;

namespace BancoTest.Interface
{
    interface IAluno
    {
        int Insert(Entities.Aluno aluno);
        string Select(Entities.Aluno aluno);
        void Update(Entities.Aluno aluno);
        void Delete(Entities.Aluno aluno);

    }
}
