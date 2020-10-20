#pragma once
#include<string>

using namespace std;

class Pessoa
{
	private:
		string Nome;
		string SobreNome;
			
	public:
		// utilização do comando this para inserir e recuperar os dados do Aluno
		void setNome(string nome) { this->Nome = nome; }
		void setSobreNome(string sobreNome) { this->SobreNome = sobreNome; }
		string getNome() { return this->Nome; }
		string getSobreNome() { return this->SobreNome; }
		void apresentaDadosPessoa();
};	

