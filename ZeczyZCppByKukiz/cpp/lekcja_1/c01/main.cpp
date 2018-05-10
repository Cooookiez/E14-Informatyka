#include <iostream>
#include <string>

using namespace std;


/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() 
{
	string imie;
	int liczba1, liczba2; //deklarujemy korzystanie z 2 zmiennych
	
	cout << "c++ uwaza ze krzysiek jest najlepszy" << endl;
	cout << "Krzysztof Kukiz" <<endl;
	cout << "Klasa IIi" << endl;
	cout << "Podaj Imie : ";
	cin >> imie;
	cout << endl << endl << "MEGA SUPER KALKULATOR" << endl << endl;
	cout << "Podaj pierwsza liczbe : ";
	cin >> liczba1;
	cout << "Podaj druga liczbe : ";
	cin >> liczba2;
	cout << liczba1 << " + " << liczba2 << " = " << liczba1+liczba2;
	
	cout << "\n\nCtr + C by zamknac"<<endl;
	cout << "--------------------------------------"<<endl;
	main();
	return 0;
}

