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
}
	