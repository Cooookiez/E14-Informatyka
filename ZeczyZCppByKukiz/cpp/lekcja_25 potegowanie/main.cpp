#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int potegowanie(float wykladnik, float potega){

	float wynik = 1;
	for (int i = 0; i < potega; i++)
		wynik *= wykladnik;
	return wynik;
	/*
	return pow(wykladnik,potega); // Dodac biblioteke <cmath> !
	*/
}

long double silnia(int liczba){
	/*
	long long int wynik=1;
	for (int i = 0; i < liczba; i++)
		wynik *= i+1;
	return wynik;
	*/
	if(liczba < 1)
		return 1;
	else
		return liczba  * silnia(liczba-1);
}

int main()
{
	
	string koniec;
	do{
		/*
		float 	wykladnik;
		float	potega;
		
		cout << "Podaj wykladnik : ";
		cin >> wykladnik;
		cout << "Podaj potege : ";
		cin >> potega;
		
		cout << "wynik: " << potegowanie(wykladnik,potega) << endl;
		cout << "pierwiastek z tymi zeczmi : " << pow(wykladnik,(1.0/potega)) << endl; // Dodac biblioteke <cmath> !
	*/
		int liczba;
		cout << "silnia : ";
		cin >> liczba;
		cout << liczba << "! to : " << silnia(liczba) << endl; 
	
		cout << "czy zakonczyc program? (tak/nie) : ";
		cin >> koniec;
	}while(
		koniec == "nie"	||
		koniec == "Nie"	||
		koniec == "NIE"	||
		koniec == "n"	||
		koniec == "N"
	);
	
	return 0;
}
