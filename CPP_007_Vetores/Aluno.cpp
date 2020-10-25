#include "Aluno.h"


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

int Aluno::getNota(int posicao)
{
	return Notas.at(posicao);
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