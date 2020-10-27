#include <string>
#include <iostream>
#include "Aluno.h"
#include <vector>

using namespace std;


int main()
{
	int i = 1;
	Aluno aluno1;
	int nota;

	aluno1.setNome("Henrique");
	aluno1.setSobreNome("Dionisio");
	
	string resposta = " ";

	while (resposta != "n")
	{
		cout << "Insira a " << i << "ª nota: " << endl;
		cin >> nota;
		aluno1.setNotas(nota);
		
		cout << "Digite sim para continuar ou 'n' para sair " << endl;
		cin >> resposta;

		i++;
	}
	aluno1.getNotas();
	
	int posicao = 0;

	while (posicao != -1)
	{
		
		cout << "insira a posicao da nota a ser recuperada ou -1 para sair" << endl;
		cin >> posicao;

		if (posicao != -1)
		{
			aluno1.getNota(posicao);
		}
		else
		{
			break;
		}
		
	}

	cout << "A maior nota foi = " << aluno1.getMaiorNota() << endl;
	cout << "A media é = " << aluno1.getMediaNotas() << endl;

	posicao = 0;
	cout << "Insira a posição que deseja remover a nota: " << endl;
	cin >> posicao;

	cout << "Removendo nota" << endl;
	aluno1.removeNota(posicao);
	cout << "Nota removida" << endl;

	aluno1.getNotas();

	system("pause");
}
	