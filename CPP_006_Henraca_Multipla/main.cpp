#include "Aluno.h"

using namespace std;

int main()
{
	Aluno aluno1;
	aluno1.setNome("Henrique");
	aluno1.setSobreNome("Dionisio");
	aluno1.setPais("Brasil");

	aluno1.apresentaDadosAluno();

	Aluno aluno2;
	aluno2.setNome("Eliel");
	aluno2.setSobreNome("Silva");
	aluno2.setPais("França");

	aluno2.apresentaDadosAluno();
}