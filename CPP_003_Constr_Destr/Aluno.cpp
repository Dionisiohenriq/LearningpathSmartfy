#include<string>
#include<iostream>
#include "Aluno.h"
#include<time.h>


using namespace std;
using namespace cpp_003;

// exemplo de método construtor e método destrutor, de acordo com o que aprendi
#pragma once
Aluno::Aluno()
{
}

Aluno::Aluno(string nome, string sobre)
	: Nome(nome),Sobrenome(sobre)
{
}


void Aluno::setNome(string nome)
{
	Nome = nome;
}

void Aluno::setSobrenome(string sobre)
{
	this->Sobrenome = sobre;
}

void Aluno::tempo()
{
	// uma ideia que não foi pra frente, timer
}

Aluno::~Aluno()
{
	cout << "Objeto deletado" << endl;
}