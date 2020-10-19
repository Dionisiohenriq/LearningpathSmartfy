#include "Aluno.h"
#include<iostream>
#include "Pessoa.h"

using namespace std;
using namespace cpp_004;

int main()
{

	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;
	cout << "||||||||||||||||||||||| EXEMPLO CONSTRUTOR E DESTRUTOR |||||||||||||||||||||||" << endl;
	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;
	
	Aluno aluno1; //Construtor padrao nao define nome e etc...
	Aluno aluno2; //Construtor Ja defini as variaveis MAIS IMPORTANTES
	string nome;
	string sobreNome;
	int tempoDeEstudo;


	cout << "Insira seu nome" << endl;
	cin >> nome;

	cout << "Insira seu sobrenome" << endl;
	cin >> sobreNome;

	cout << "Quanto tempo você estuda por dia em horas? " << endl;
	cin >> tempoDeEstudo;

	aluno1.setNome(nome);
	aluno1.setSobrenome(sobreNome);
	aluno1.setTempoDeEstudo(tempoDeEstudo);

	cout << aluno1.dadosAluno() << endl;


	cout << "Insira seu nome" << endl;
	cin >> nome;

	cout << "Insira seu sobrenome" << endl;
	cin >> sobreNome;

	cout << "Quanto tempo você estuda por dia em horas? " << endl;
	cin >> tempoDeEstudo;

	
	aluno2.setNome(nome);
	aluno2.setSobrenome(sobreNome);
	aluno2.setTempoDeEstudo(tempoDeEstudo);

	


	cout << "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" << endl;


}