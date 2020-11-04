using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_007_NotasAlunos.Entities
{
    public class NotaAluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Nota4 { get; set; }
        public float Media { get; set; }
    }
}
