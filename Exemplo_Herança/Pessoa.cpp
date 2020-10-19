#include<string>
#include<iostream>
#include "Pessoa.h"
#include<time.h>


using namespace std;
using namespace cpp_004;

// exemplo de m�todo construtor e m�todo destrutor, de acordo com o que aprendi
#pragma once
Pessoa::Pessoa()
{
}

Pessoa::Pessoa(string nome, string sobre, int tempoDeEstudo)
	: Nome(nome), Sobrenome(sobre), TempoDeEstudo(tempoDeEstudo)
{
}


void Pessoa::setNome(string nome)
{
	Nome = nome;
}

void Pessoa::setSobrenome(string sobre)
{
	this->Sobrenome = sobre;
}

void Pessoa::setTempoDeEstudo(int tempoDeEstudo)
	:TempoDeEstudo(tempoDeEstudo)
{
	if (tempoDeEstudo > 6)
	{
		cout << "� estudante" << endl;
	}
	else
	{
		cout << "� apenas uma pessoa comum" << endl;
	}
}

Pessoa::~Pessoa()
{
	cout << "Objeto deletado" << endl;
}