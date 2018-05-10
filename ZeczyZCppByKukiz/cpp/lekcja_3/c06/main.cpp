#include <iostream>

using namespace std;

int main(int argc, char** argv) 
{
	float warotsc_x=0, wartosc_y=0;
	cout << "********************************************" << endl;
	cout << "*Elo elo, podaj \"x\", a oblicze ci \"x/(x^2+1)\"" << endl;
	cout << "*x = ";
	do{
		cin.clear();
		cin.sync();
		cin >> warotsc_x;
		cin.good();
		if(cin.good()==0){
			cout << "*Podaj poprawna liczbe : ";
		}
	}while(cin.good()==0);
	//cin >> warotsc_x;
	wartosc_y=warotsc_x/(warotsc_x*warotsc_x+1);
	cout << "*wynik to : " << wartosc_y << endl << "*" << endl;
	//cout << "**********************" << endl;
	main(argc, argv);
	return 0;
}


