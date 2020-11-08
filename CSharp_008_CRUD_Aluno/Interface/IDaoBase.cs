using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_008_CRUD_Aluno.Interface
{
    interface IDaoBase
    {
        void Insert(Entities.Curso entity);
        void Select(Entities.Curso entity);
        void Update(Entities.Curso entity);
        void Delete(Entities.Curso entity);
    }
}
