#include "Aluno.h"
#include<iostream>



void Aluno::apresentaDadosAluno()
{
	// com a referência da classe aluno, pode-se usar o operador this para acessar os métodos dela
	cout << "Nome do Aluno: " << this->getNome() << endl;
	cout << "Sobrenome do Aluno: " << this->getSobreNome() << endl;
}