#include<string>

using namespace std;

namespace cpp_003
{
	class Aluno
	{
	private:
		string Nome;
		string Sobrenome;

	public:

		Aluno();
		Aluno(string nome, string sobre);

		void tempo();
		~Aluno();


		string getNome() { return Nome ; }
		string getSobrenome() { return Sobrenome; }
		void setNome(string constr);
		void setSobrenome(string destr);
	};
}

//GETTERS AND SETTERS C++