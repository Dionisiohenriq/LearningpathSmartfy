#include "Aluno.h"
#include<iostream>



void Aluno::apresentaDadosAluno()
{
	// com a refer�ncia da classe aluno, pode-se usar o operador this para acessar os m�todos dela
	cout << "Nome do Aluno: " << this->getNome() << endl;
	cout << "Sobrenome do Aluno: " << this->getSobreNome() << endl;
}