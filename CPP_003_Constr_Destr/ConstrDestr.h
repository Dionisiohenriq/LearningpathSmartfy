#include<string>

using namespace std;

class ConstrDestr
{
	private:

		string constr;
		string destr;

	public:
		
		ConstrDestr();
		ConstrDestr(string constr, string destr);
		string getConstr();
		string getDestr();
		void setConstr(string constr);
		void setDestr(string destr);
		void tempo();
		~ConstrDestr();
};