#include<string>
#include "Pessoa.h"


using namespace std;
using namespace cpp_004;

class Aluno: public Pessoa
{
private:
	string Nome;
	string Sobrenome;
	int idade;

public:

	string dadosAluno();


};


