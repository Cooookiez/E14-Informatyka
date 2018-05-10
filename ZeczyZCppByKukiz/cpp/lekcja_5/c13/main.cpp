#include <iostream>
#include <math.h>

using namespace std;

int main(int argc, char** argv)
{
	cout << "OBLICZANIE MIEJSC ZEROWE FUNKCJI" << endl;
	double wspulczynnik_a, wspulczynnik_b, wspulczynnik_c, delta;
	cout << "podaj a : ";
	cin >> wspulczynnik_a;
	cout << "podaj b : ";
	cin >> wspulczynnik_b;
	cout << "podaj c : ";
	cin >> wspulczynnik_c;
	delta=pow(wspulczynnik_b, 2)-(4*wspulczynnik_a*wspulczynnik_c);
	if(delta>0)
	{
		cout << "x1 = " << (-wspulczynnik_b-pow(delta, 1/2.))/(2*wspulczynnik_a) << endl;
		cout << "x = " << (-wspulczynnik_b+pow(delta, 1/2.))/(2*wspulczynnik_a) << endl;
	}
	else if(delta==0)
		cout << "x0 = " << (-wspulczynnik_b)/(2*wspulczynnik_a) << endl;
	else
		cout << "funkca nie ma miejsca zero" << endl;
		
	
	cout << endl << "----------------------------" << endl << endl;
	main(argc, argv);
	return 0;
}
