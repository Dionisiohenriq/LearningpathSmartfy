#pragma once
#include<string>
#include "Nacionalidade.h"
#include "Pessoa.h"

using namespace std;

class Aluno : public Nacionalidade, public Pessoa
{

public:
	// utiliza��o do comando this para inserir e recuperar os dados do Aluno
	
	void apresentaDadosAluno();


};

