#include<string>

using namespace std;

namespace cpp_004
{
	class Pessoa
	{
	private:
		string Nome;
		string Sobrenome;
		int TempoDeEstudo;
	public:

		Pessoa();
		Pessoa(string nome, string sobre, int tempoDeEstudo);

		~Pessoa();


		string getNome() { return Nome; }
		string getSobrenome() { return Sobrenome; }
		int getTempoDeEstudo() { return TempoDeEstudo; }
		void setNome(string nome);
		void setSobrenome(string sobreNome);
		void setTempoDeEstudo(int tempoDeEstudo);
	};
}

