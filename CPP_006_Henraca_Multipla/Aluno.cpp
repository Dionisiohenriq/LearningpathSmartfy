#include "Aluno.h"
#include <iostream>

using namespace std;

void Aluno::apresentaDadosAluno()
{

	apresentaDadosPessoa(); // m�todo da classe Pessoa, da qual Aluno � filha
	cout << "De onde ele vem? " << ehGringo() << endl;
}