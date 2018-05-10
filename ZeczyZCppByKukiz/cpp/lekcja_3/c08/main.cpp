#include <iostream>
#include <math.h>

using namespace std;

/*Dane s¹ trzy nieujemne liczby rzeczywiste x, y i z.
Napisz program, który wydrukuje pierwiastek stopnia czwartego z sumy szeœcianów tych liczb.*/

int main(int argc, char** argv) 
{
	float liczba_x, liczba_y, liczba_z, wynik;
	cout << "Elo, bedziemy liczy c pierwiastek stopnia 4 z sumy szescianow paru liczb" << endl;
	cout << "Podaj \"x\" : ";
	cin >> liczba_x;
	cout << "Podaj \"y\" : ";
	cin >> liczba_y;
	cout << "Podaj \"z\" : ";
	cin >> liczba_z;
	//(x^3+y^3+z^3)^(1/4)
	wynik=pow(pow(liczba_x,3.)+pow(liczba_y,3.)+pow(liczba_z,3.),1/4.);
	cout << "(x^3+y^3+z^3)^(1/4)=" << wynik << endl; 
	cout << endl << "###############################" << endl << endl << endl;
	main(argc, argv);
	return 0;
}
