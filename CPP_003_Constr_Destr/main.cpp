#include "ConstrDestr.h"
#include<iostream>

using namespace std;


int main()
{
	
	ConstrDestr constr1;
	ConstrDestr constr2;
	string frase1;
	string frase2;

	cout << "Insira uma frase" << endl;
	cin >> frase1;
	
	cout << "Insira uma segunda frase" << endl;
	cin >> frase2;

	constr1.setConstr(frase1);
	constr2.setDestr(frase2);
	
	cout << "A primeira frase foi: " << constr1.getConstr() << endl;

	cout << "A segunda frase foi: " << constr2.getDestr() << endl;

	

}