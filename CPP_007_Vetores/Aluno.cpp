#include "Aluno.h"


void Aluno::setNotas(int notas) 
{
	Notas.push_back(notas);
}

void Aluno::getNotas()
{
	for (int i = 0; i < size(Notas); i++)
	{
		cout << "Nota " << (i + 1) << " do aluno " << getNome() << " " << getSobreNome() << " = "<< Notas[i] << endl;
	}
}
