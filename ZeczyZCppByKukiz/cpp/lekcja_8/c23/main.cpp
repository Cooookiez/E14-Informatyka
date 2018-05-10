#include <iostream>
#include <math.h>

using namespace std;

int main(int argc, char** argv)
{
	cout << "- - - - - - - - - - - - - - - - - -" << endl;
	cout << "1. Pole i obwod kola" << endl;
	cout << "2. Obietosc szeszcianu" << endl;
	cout << "3. Pole pow prostopadloscianu" << endl;
	cout << "4. Wartosc funkcji f(x)=3x^2+2x-1" << endl;
	cout << "- - - - - - - - - - - - - - - - - -" << endl;
	cout << "Wybierz : ";
	int dzialanie;
	cin >> dzialanie;
	cout << "- - - - - - - - - - - - - - - - - -" << endl;
	switch(dzialanie){
		case 1:
			cout << "Pole i obwod kola" << endl << endl;
			cout << "podaj \"r\" : ";
			int wartosc_r;
			cin >> wartosc_r;
			cout << endl;
			cout << "Pole:" << endl;
			cout << " 3.14* " << wartosc_r << "^2" << endl;
			cout << " pole = " << 3.14*pow(wartosc_r, 2) << endl;
			cout << "Obwot:" << endl;
			cout << " 2*3.14*" << wartosc_r << endl;
			cout << " obwot = " << 2*3.14*wartosc_r << endl;
			break;
		case 2:
			cout << "Obietosc szeszcianu" << endl << endl;
			cout << "podaj dlugosc boku : ";
			int bok_a;
			cin >> bok_a;
			cout << " obwut = " << bok_a << "^3" << endl;
			cout << " obwut = " <<  pow(bok_a, 3) << endl;
			break;
		case 3:
			cout << "Pole pow prostopadloscianu" << endl << endl;
			int wartosc_a, wartosc_b, wartosc_H;
			cout << "podaj bok \"a\" : ";
			cin >> wartosc_a;
			cout << "podaj bok \"b\" : ";
			cin >> wartosc_b;
			cout << "podaj wysokosc : ";
			cin >> wartosc_H;
			cout << endl;
			cout << "pole pow:" << endl;
			cout << " Pp=" << wartosc_a << "*" << wartosc_b << "*" << wartosc_H << endl;
			cout << " Pp=" << wartosc_a * wartosc_b * wartosc_H << endl;
			break;
		case 4:
			cout << "Wartosc funkcji f(x)=3x^2+2x-1" << endl << endl;
			cout << "Podaj \"x\" : ";
			int wartosc_x;
			cin >> wartosc_x;
			cout << "funkcja:" << endl;
			cout << " f(" << wartosc_x << ")=3*" << wartosc_x << "^2+2*" << wartosc_x << "-1" << endl;
			cout << " f(" << wartosc_x << ")=" << 3*pow(wartosc_x, 2)+2*wartosc_x-1 << endl;
			break;
		default:;
			cout << "lele zle dzialanie lel xd" << endl;
	}
	cout << "-----------------------------------" << endl << endl << endl ;
	main(argc, argv);
	return 0;
}
