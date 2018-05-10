#include <iostream>
#include <cstdlib>
#include <windows.h>
#include <ctime>

using namespace std;

const int ILOSC_LICZB=5, // ilosc liczb
MAX=150, // najwieksza liczba to wylosownia
MINI=100; // najmiejsza liczba to wylosownia

int main(int argc, char** argv)
{
	srand(time(NULL));
	int t[ILOSC_LICZB];
	for(int i=0; i<ILOSC_LICZB; i++){ //losowanie i przypisanie liczb to tablicy
		t[i]=100+rand()%(MAX-100+1);
	}
	
	cout << " - " << ILOSC_LICZB << " losowych liczb -" << endl << endl; // wypisanie liczb
	for(int i=0; i<ILOSC_LICZB; i++){
		cout << t[i] << ", ";
	}
	
	int najwieksza=MINI, najmiej=MAX;
	for(int i=0; i<ILOSC_LICZB; i++){//ktura licza jest najwieksza
		if(najwieksza<=t[i]){
			najwieksza=t[i];
		}
	}
	
	for(int i=0; i<ILOSC_LICZB; i++){//ktura liczba jest najmiejsza
		if(najmiej>=t[i]){
			najmiej=t[i];
		}
	}
	
	cout << endl << endl << "Najwieksza : " << najwieksza << endl;
	cout << "Najmiejsza : " << najmiej << endl;
	return 0;
}
