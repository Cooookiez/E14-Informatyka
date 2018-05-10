// Wskaźniki.cpp: Definiuje punkt wejścia dla aplikacji konsolowej.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>

using namespace std;

void co_czym_jest() {
	int zmienna = 10;
	int *zmienna_wsk;
	zmienna_wsk = &zmienna;
	cout << "zmienna: " << zmienna << endl;				//	10
	cout << "&zmienna: " << &zmienna << endl;			//	0x6ffdfc	(numer komurki ram)
	cout << "zmienna_wsk: " << zmienna_wsk << endl;		//	0x6ffdfc	(numer komurki ram)
	cout << "*zmienna_wsk: " << *zmienna_wsk << endl;	//	10
	cout << "*&zmienna: " << *&zmienna << endl;			//	10
}

void ZmianaVarByRam() {
	int zmienna = 10;
	int *zmienna_wsk = &zmienna;
	int *zmienna_wsk2 = zmienna_wsk;
	cout << zmienna << endl;		//10
	cout << zmienna_wsk2 << endl;	//0x6ffe04
	*zmienna_wsk2 = 16;
	cout << zmienna << endl;		//16
	cout << zmienna_wsk2 << endl;	//0x6ffe04
}

void zamianaLiczb(int &a, int &b) {
	int tmp = a;
	a = b;
	b = tmp;
}

void dajZero(int *i) {
	*i = 0;

}

void sortuj(int *tab, int ile) {

}

int main() {
	//pokazanie co ma jakie wartosci
	cout << "\n..::co_czym_jest()::..\n\n";
	co_czym_jest();

	//zmienianie wartosci innego var'a po lokalizacji komurki
	cout << "\n\n..::ZmianaVarByRam()::..\n";
	ZmianaVarByRam();

	//zwrucenie więcej niżjedna wartość
	cout << "\n\n..::zamianaLiczb()::..\n";
	int z_a = 11;
	int z_b = 29;
	cout << z_a << endl;	//11
	cout << z_b << endl;	//29
	zamianaLiczb(z_a, z_b);	
	cout << z_a << endl;	//29
	cout << z_b << endl;	//11

	//'Zwracanie' tablicy
	cout << "\n\n..::()::..\n";


	
	
	int *ile;
	ile = new int;
	*ile = 10;
	
	dajZero(ile);

	cout << *ile << endl;

	//ile = 10;
	//int *tablica = new int[10];
	//cout << ile;
	//for (int i = 0; i < ile; i++) cout << *(tablica + i) << ", "; cout << endl;
	//sortuj(tablica, 10);
	//for (int i = 0; i < ile; i++) cout << *(tablica + i) << ", "; cout << endl;
	
	
	int aaaaaaSydeniaaaaaaaaaa = 550;



	cin.get();
	return 0;
}
