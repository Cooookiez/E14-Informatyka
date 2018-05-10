#include <iostream>
#include <cstdlib>
#include <ctime>
#include <cmath>
#include <windows.h>

using namespace std;

void load(int ile_kropek, int czas){
	for (int i = 0; i < ile_kropek; i++){
			cout << " .";
			Sleep(czas);
		}
}

void poleKwadrat(){
	system("cls");
	
	cout << "=== === === === === === === ===" << endl;
	cout << "Pole Kwadratu" << endl;
	cout << "=== === === === === === === ===" << endl << endl;
	int bok, pole;
	cout << "Podaj bok kwadratu: ";
	cin >> bok;
	
	pole = pow( bok, 2 );
	
	cout << endl << "Pole kwadratu to: " << pole << endl << endl;
	
	system("pause");
	system("cls");
}
void poleTrujkat(){
	system("cls");
	
	cout << "=== === === === === === === ===" << endl;
	cout << "Pole trujkata" << endl;
	cout << "=== === === === === === === ===" << endl << endl;
	double podstawa, wysokosc, pole;
	cout << "Podaj Podstawe trujkata: ";
	cin >> podstawa;
	cout << "Podaj wysokosc trujkata: ";
	cin >> wysokosc;
	pole = podstawa * wysokosc / 2;
	
	cout << endl << "Pole trujkata to: " << pole << endl << endl;
	
	system("pause");
	system("cls");
}
void polekolo(){
	system("cls");
	
	cout << "=== === === === === === === ===" << endl;
	cout << "Pole Kola" << endl;
	cout << "=== === === === === === === ===" << endl << endl;
	double promien, pole, pi=3.1415;
	cout << "Podaj promien: ";
	cin >> promien;
	pole = pi * pow(promien, 2);
	
	cout << endl << "Pole kola to: " << pole << endl << endl;
	
	system("pause");
	system("cls");
}
void podega(){
	system("cls");
	
	cout << "=== === === === === === === ===" << endl;
	cout << "Podega" << endl;
	cout << "=== === === === === === === ===" << endl << endl;
	
	double liczba, potega, wynik;
	
	cout << "Podaj liczbe potegowana: ";
	cin >> liczba;
	cout << "Podaj potege: ";
	cin >> potega;
	
	wynik = pow(liczba, potega);
	cout << endl << liczba << "^" << potega << "=" << wynik << endl;
	
	
	system("pause");
	system("cls");
}
void struny(){
	system("cls");
	
	cout << "=== === === === === === === ===" << endl;
	cout << "Rownanie teorii strun" << endl;
	cout << "=== === === === === === === ===" << endl << endl;
	cout << "Czekaj";
	load(4, 1000);
	cout << endl << endl;
	
	//system("cls");
	
	while(1){
		cout << "No RAM detected";
		load(3, 1000);
		cout << endl << endl;
	}
	
	
	
	
	
	system("pause");
	system("cls");
}

int main(){
	bool bEnd = false;
	do{
		int p = 0,
			wybor;
		cout << "=== === === === === === === ===" << endl;
		cout << ++p << ". Pole kwadratu" << endl;
		cout << ++p << ". Pole trojkata" << endl;
		cout << ++p << ". Pole kola" << endl;
		cout << ++p << ". Liczba do potegi" << endl;
		cout << ++p << ". Rownanie teorii strun" << endl;
		cout << 0 << ". Wyjdz" << endl;
		cout << "=== === === === === === === ===" << endl;
		cout << "Wybierz: ";
		cin >> wybor;
		
		switch(wybor){
			default:
			case 0:
				bEnd = true;
				break;
			case 1:
				poleKwadrat();
				break;
			case 2:
				poleTrujkat();
				break;
			case 3:
				polekolo();
				break;
			case 4:
				podega();
				break;
			case 5:
				struny();
				break;
		}
		
	}while(!bEnd);
	return 0;
}
