#include "Pessoa.h"
#include <iostream>

using namespace std;

void Pessoa::apresentaDadosPessoa()
{
	cout << "Nome completo: " << getNome() << " " << getSobreNome() << endl;
}