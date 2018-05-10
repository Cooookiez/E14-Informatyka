#include <iostream>

using namespace std;

class PaczkaZapalek{
	private:
		int ile;
	public:
		PaczkaZapalek(int ileTmp = 40){
			 ile = ileTmp;
			 //->ile = ile;
		}
		void dodaj(int ile=1);
		void usun(int ile=1);
		int show(){
			return ile;
		}
};

int main(int argc, char** argv) {
	
	PaczkaZapalek ruskie(38);
	cout << "--" << endl;
	cout << ruskie.show() << endl;
	cout << "--" << endl;
	ruskie.dodaj(2);
	cout << ruskie.show() << endl;
	cout << "--" << endl;
	ruskie.usun();
	cout << ruskie.show() << endl;
	cout << "--" << endl;
	ruskie.usun(50);
	cout << ruskie.show() << endl;
	cout << "--" << endl;
	ruskie.dodaj(50);
	cout << ruskie.show() << endl;
	cout << "--" << endl;
	
	return 0;
}

void PaczkaZapalek::dodaj(int ileTmp){
	ile += ileTmp;
	if(ile >= 40) ile = 40;
}
void PaczkaZapalek::usun(int ileTmp){
	ile -= ileTmp;
	if(ile < 1) ile = 0;
}
