#include<string>
#include<iostream>
#include "Aluno.h"


using namespace std;
using namespace cpp_004;

// exemplo de método construtor e método destrutor, de acordo com o que aprendi
#pragma once

string Aluno::dadosAluno() 
{
	return cout << "Idade aluno = " << idade << " Sobrenome = " << Pessoa::getSobrenome() << " Nome = " << Pessoa::getNome() << endl;
}
