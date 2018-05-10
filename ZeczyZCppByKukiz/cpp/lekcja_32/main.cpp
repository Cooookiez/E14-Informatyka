#include <iostream>
#include <cstdlib>

using namespace std;
/*
user > liczba
liczba > dzielniki
*/

int main(){
	
	int liczba;
	char run = 't';
	do{
		system("cls");
		cout << "Podaj liczbe : ";
		cin >> liczba;
		cout << "dzielniki liczby "<<liczba<<": ";
		for(int i = 1; i <= liczba; i++){
			if(liczba%i == 0){
				cout << i << ", ";
			}
		}
		cout << endl << endl << "Kontynuowac? (t/n): ";
		cin >> run;
	}while(run == 't');
	
	return 0;
}
