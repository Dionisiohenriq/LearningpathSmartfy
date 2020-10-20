#include "Aluno.h"
#include <iostream>

using namespace std;

void Aluno::apresentaDadosAluno()
{

	apresentaDadosPessoa(); // método da classe Pessoa, da qual Aluno é filha
	cout << "De onde ele vem? " << ehGringo() << endl;
}