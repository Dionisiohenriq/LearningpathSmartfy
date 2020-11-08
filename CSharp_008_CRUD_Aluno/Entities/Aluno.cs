using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_008_CRUD_Aluno.Entities
{
    class Aluno
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private string Endereco { get; set; }

        private List<double> Notas = new List<double>();
        private double Media { get; set; }

    }
}
