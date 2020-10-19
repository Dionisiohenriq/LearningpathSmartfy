#include<string>
#include<iostream>
#include "ConstrDestr.h"
#include<time.h>


using namespace std;
// exemplo de método construtor e método destrutor, de acordo com o que aprendi
#pragma once
ConstrDestr::ConstrDestr()
{
}

ConstrDestr::ConstrDestr(string constr, string destr)
{
	this->setConstr(constr);
	this->setDestr(destr);
}

string ConstrDestr::getConstr()
{
	return this->constr;
}

string ConstrDestr::getDestr()
{
	return this->destr;
}

void ConstrDestr::setConstr(string constr)
{
	this->constr = constr;
}

void ConstrDestr::setDestr(string destr)
{
	this->destr = destr;
}

void ConstrDestr::tempo()
{
	// uma ideia que não foi pra frente, timer
}

ConstrDestr::~ConstrDestr()
{
	cout << "Objeto deletado" << endl;
}