#include "Nacionalidade.h"
#include <iostream>

using namespace std;

string Nacionalidade::ehGringo()
{
	string pais = getPais();
	if (pais != "Brasil" ) 
	{
		return "Gringo";
	}
	else
	{
		return "Br";
	}
}