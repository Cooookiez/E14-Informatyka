#include <iostream>
#include <cstdlib>
#include <windows.h>

using namespace std;

const int ILE_LICZB = 4; // ilosc liczb to wpisania/wyswietlenia

int main(int argc, char** argv)
{
	int liczba[ILE_LICZB], suma=0;
	cout << " - podaj " << ILE_LICZB << " iczba -" << endl << endl;
	for(int i=0; i<ILE_LICZB; i++){
		cout << " podaj liczbe nr. " << i+1 << " : " ;
		cin >> liczba[i];
	}
	
	cout << endl << endl << " - suma liczb i srednia -" << endl << endl;
	for(int i=0; i<ILE_LICZB; i++){
		suma+=liczba[i];
	}
	cout << " suma : " << suma << endl;;
	cout << " srednia : " << (float)suma/ILE_LICZB << endl;
	
	cout << endl << "- - - - - - - - - - - - - - - - - - -" << endl;
	system("pause");
	system("cls");
	main(argc, argv);
	return 0;
}
