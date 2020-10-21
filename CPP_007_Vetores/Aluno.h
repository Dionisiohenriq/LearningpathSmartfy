#pragma once
#include <string>
#include <vector>
#include <iostream>
using namespace std;

class Aluno
{
	private:
		string Nome;
		string SobreNome;
		vector<int>Notas;

	public:
		void setNome(string nome) { Nome = nome; }
		void setSobreNome(string sobreNome) { SobreNome = sobreNome; }
		string getNome() { return Nome; }
		string getSobreNome() { return SobreNome; }
		void setNotas(int notas);
		void getNotas();
};

