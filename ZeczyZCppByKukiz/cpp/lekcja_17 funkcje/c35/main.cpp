#include <iostream>

using namespace std;

bool czykobieta(string imie)
{
	char ostatnia = imie[imie.length()-1];
	bool kobieta;
	if (ostatnia == 'a')
		kobieta = true;
	else
		kobieta = false;
	
	return kobieta;
}

int main()
{
	
	char opcja;
	
	do{
		string imie;
		cout << "Podaj imie : ";
		cin >> imie;
		if (czykobieta(imie))
			cout << "imie jest kobiece" << endl;
		else
			cout << "imie jest meskie" << endl;
		
		
		cout << endl << "zakonczyc program? (y/n) : ";
		cin >> opcja;
		cout << endl;
	}while(opcja != 'y');
	return 0;
}
