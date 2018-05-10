#include <iostream>
#include <cstdlib>
#include <windows.h>

using namespace std;

void zad1(){
	system("cls");
	
	//pyta ie o liczbe
	cout << "Podaj liczbe: ";
	int liczba;
	
	//sprawdza poprawnosc wpisanych danych
	do{
		cin.clear();
		cin.sync();
		cin >> liczba;
		cin.good();
		if(cin.good() == false){
			cout << "sprobuj ponownie: ";
		}
	}while(cin.good() == false);
	
	//tworzy dablice i wypelnia ja liczba 13
	int tab[liczba];
	for(int i = 0; i < liczba; i++)
		tab[i] = 13;
	
	//wypisuje tablice
	cout << endl;
	for(int i = 0; i < liczba; i++){
		if (i)
			cout << " x ";
		cout << tab[i];
	}
	cout << endl;
	system("pause");
}
void zad2(){
	system("cls");
	
	//pobiera wyraz
	cout << "Podaj jakis wyraz: ";
	string wyraz;
	cin >> wyraz;
	
	int wyraz_dl = wyraz.length();	//patrzy dlugosc wyrazu
	
	//zamienia pierwsza i ostatnia na '.'
	for(int i = 0; i < wyraz_dl; i++){
		if(i == 0 || i == wyraz_dl-1){	//wypisuje '.'
			cout << '.';
		}else{
			cout << wyraz[i];			//wypisuje reszte wyrazu
		}
	}
	
	cout << endl;
	system("pause");
}
void zad3(){
	system("cls");
	cout << "Petla do while wykona sie zawsze conajmniej jeden raz, i na koniec sprawdzi warunek czy ma sie wykonaæraz nastêpny." << endl << endl;
	cout << "Przyklad petli do while, ktura wykona siê tylko raz:" << endl << endl;
	cout << "do{" << endl;
	cout << " cout << \"napis\";" << endl;
	cout << "}while(0);	//<- poniewaz wartosc false petal nie wykona siê ponownie" << endl;
	
	cout << endl;
	system("pause");
}

int main(int argc, char** argv) {
	
	bool run = true;
	int wyb;
	do{
		system("cls");
		cout << "1. zad z tablica" << endl;
		cout << "2. zad z wyrazem" << endl;
		cout << "3. opis do while" << endl;
		cout << "0. koniec" << endl;
		cout << "Wybierz: ";
		cin >> wyb;
		switch(wyb){
			case 1:
				zad1();
				break;
			case 2:
				zad2();
				break;
			case 3:
				zad3();
				break;
			case 0:
				run = false;
				break;
			default:
				cout << "error";
		}
	}while(run);
	
	return 0;
}
