#include "Aluno.h"
#include <vector>

void Aluno::setNotas(int notas) 
{
	Notas.push_back(notas);
}

void Aluno::getNotas()
{
	int j = 1;
	for (auto i = Notas.begin(); i != Notas.end(); ++i)
	{
		
		cout << "Nota " << j << " do aluno " << getNome() << " " << getSobreNome() << " = "<< *i << endl;
		j++;
	}
}

void Aluno::getNota(int posicao)
{
	if(posicao < Notas.size() - 1)
	{
		cout <<"Nota = " << Notas.at(posicao) << " Posicao = " << posicao << endl;
	}
	else
	{
		cout << "Posicao nao existe no Vetor" << endl;
	}
	
}

int Aluno::getMaiorNota()
{
	int maiorNota = 0;
	for (auto i = Notas.begin(); i != Notas.end(); i++) 
	{
		if (*i > maiorNota)
		{
			maiorNota = *i;
		}
	}
	return maiorNota;
}

double Aluno::getMediaNotas() 
{
	double somaDasNotas = 0;
	double media;

	for (auto i = Notas.begin(); i != Notas.end(); i++)
	{
		somaDasNotas += *i;
	}

	media = somaDasNotas / size(Notas);

	return media;
}

void Aluno::removeNota(int posicao)
{
	
	if(posicao < Notas.size() - 1)
	{
		Notas.erase(Notas.begin() + posicao);
	}
	else
	{
		cout << "Posicao maior ou menor que o tamanho do Vetor" << endl;
	}
}
