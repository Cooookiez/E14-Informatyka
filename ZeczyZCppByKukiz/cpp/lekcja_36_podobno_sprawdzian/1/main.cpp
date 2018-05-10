#include <iostream>

using namespace std;

int main(int argc, char** argv){
	
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
	return 0;
}
