#include <iostream>
#include <windows.h>

using namespace std;

int main(int argc, char** argv) {
	int liczba_r, liczba_g, liczba_b;

	cout << "Przelicznik RGB z dziesietnego na binarny" << endl << endl;

	cout << "Podaj wartosc 'R' 0-255 : ";
	do {//sprawdza czy nie ma bledu w wpisie
		cin.clear();
		cin.sync();
		cin >> liczba_r;
		cin.good();
		if(cin.good()==0||liczba_r>255||liczba_r<0) {
			cout << "Podaj poprawna liczbe : ";
		}
	} while(cin.good()==0||liczba_r>255||liczba_r<0);

	cout << "Podaj wartosc 'G' 0-255 : ";
	do {//sprawdza czy nie ma bledu w wpisie
		cin.clear();
		cin.sync();
		cin >> liczba_g;
		cin.good();
		if(cin.good()==0||liczba_g>255||liczba_g<0) {
			cout << "Podaj poprawna liczbe : ";
		}
	} while(cin.good()==0||liczba_g>255||liczba_g<0);

	cout << "Podaj wartosc 'B' 0-255 : ";
	do {//sprawdza czy nie ma bledu w wpisie
		cin.clear();
		cin.sync();
		cin >> liczba_b;
		cin.good();
		if(cin.good()==0||liczba_b>255||liczba_b<0) {
			cout << "Podaj poprawna liczbe : ";
		}
	} while(cin.good()==0||liczba_b>255||liczba_b<0);
	/*
	cout << hex << liczba_r << endl;
	cout << hex << liczba_g << endl;
	cout << hex << liczba_b << endl;
	*/

	if(liczba_r<=15) { //przelicza wartosc z dec na hex dla 'R' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "Wartosc 'R' : " << "0" << hex << liczba_r << endl;
	} else {
		cout << "Wartosc 'R' : " << hex << liczba_r << endl;
	}

	if(liczba_g<=15) {//przelicza wartosc z dec na hex dla 'G' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "Wartosc 'G' : " << "0" << hex << liczba_g << endl;
	} else {
		cout << "Wartosc 'G' : " << hex << liczba_g << endl;
	}

	if(liczba_b<=15) {//przelicza wartosc z dec na hex dla 'B' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "Wartosc 'B' : " << "0" << hex << liczba_b << endl;
	} else {
		cout << "Wartosc 'B' : " << hex << liczba_b << endl;
	}

	
	//wszystkie 3 cyfry scala w jedna
	cout << endl << "RGB = ";
	if(liczba_r<=15) { //przelicza wartosc z dec na hex dla 'R' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "0" << hex << liczba_r;
	} else {
		cout << hex << liczba_r;
	}

	if(liczba_g<=15) {//przelicza wartosc z dec na hex dla 'G' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "0" << hex << liczba_g;
	} else {
		cout << hex << liczba_g;
	}

	if(liczba_b<=15) {//przelicza wartosc z dec na hex dla 'B' z uwzglednieniem czy todac '0' przed liczbe czy nie
		cout << "0" << hex << liczba_b << endl;
	} else {
		cout << hex << liczba_b << endl;
	}

































	//cout << "############################################" << endl << endl;
	cout << endl << endl;
	system("pause");
	system("cls");

	main(argc, argv);
	return 0;
}

