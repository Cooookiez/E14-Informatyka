#include <iostream>
#include <ctime>
#include <cstdlib>
#include <math.h>

using namespace std;

int main(int argc, char** argv)
{
	srand(time(NULL));
	float liczba[3];
	int max, mini;
	cout << "Losowanie liczb a, b, c i przypisanie ich to funkcji kwadratowej" << endl << endl;
	
	cout << "Podaj MAX liczbe do wylosowania : ";
	cin >> max;
	max*=5;
	cout << "Podaj MINI liczbe do wylosowania : ";
	cin >> mini;
	mini*=5;
	
	liczba[0]=mini+(rand()%(max-mini+1));
	liczba[1]=mini+(rand()%(max-mini+1));
	liczba[2]=mini+(rand()%(max-mini+1));
	
	liczba[0]/=5;
	liczba[1]/=5;
	liczba[2]/=5;
	
	cout << endl << "a = " << liczba[0] << endl;
	cout << "b = " << liczba[1] << endl;
	cout << "c = " << liczba[2] << endl << endl;
	
	float wartosc_x;
	
	cout << "y = ax^2 + bx + c" << endl;
	cout << "y = " << liczba[0] << "x^2 + " << liczba[1] << "x + " << liczba[2] << endl;
	cout << "Podaj \"x\" : ";
	cin >> wartosc_x;
	//y=ax^2+bx+c
	cout << endl << "f(" << wartosc_x << ") = " << liczba[0] << "*2^2 + " << liczba[1] << "*2 + " << liczba[2] << endl; 
	cout << "f(" << wartosc_x << ") = " << (liczba[0]*pow(wartosc_x, 2))+(liczba[1]*wartosc_x)+(liczba[2]) << endl;
	
	system("pause");
	system("cls");
	
	main(argc, argv);
	return 0;
}
