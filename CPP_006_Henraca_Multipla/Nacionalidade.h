#pragma once
#include<string>

using namespace std;

class Nacionalidade
{
	private: 
		string Pais;

	public:
		void setPais(string pais) { Pais = pais; }
		string getPais() { return Pais; }
		string ehGringo();
};

