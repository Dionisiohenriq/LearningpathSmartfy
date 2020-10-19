#include "Aluno.h"
#include<iostream>

using namespace std;
using namespace cpp_003;

int main()
{
	
	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;
	cout << "||||||||||||||||||||||| EXEMPLO CONSTRUTOR E DESTRUTOR |||||||||||||||||||||||" << endl;
	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;

	Aluno aluno1; //Construtor padrao nao define nome e etc...
	Aluno aluno2("Henrique","Dionisio"); //Construtor Ja defini as variaveis MAIS IMPORTANTES
	aluno1.setNome("Eliel");
	aluno1.setSobrenome("Silva");
	cout << "ALUNO 1 - " << aluno1.getNome() << endl;
	cout << "ALUNO 2 - " << aluno2.getSobrenome() << endl;
	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;


}