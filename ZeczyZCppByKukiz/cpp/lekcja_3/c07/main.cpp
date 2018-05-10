#include <iostream>
#include <math.h>
 
using namespace std;

//Napisz program obliczaj¹cy wartoœci pierwiastków stopni 2, 4 i 8 z nieujemnej liczby rzeczywistej

int main(int argc, char** argv)
{
	float liczba1, stopien_2, stopien_4, stopien_8;
	cout << "Program obliczajacy wartosc pierwiastka stopnia 2, 4, i 8" << endl;
	cout << "podaj liczbe : ";
	do {//sprawdza czy nie ma bledu w wpisie
		cin.clear();
		cin.sync();
		cin >> liczba1;
		cin.good();
		if(cin.good()==0){
			cout << "Podaj poprawna liczbe : ";
		}
		if(liczba1<0){
			cout << "Liczba nie mze byc ujemna!" << endl << "Podaj inna : ";
		}
	} while(cin.good()==0||liczba1<0);
	stopien_2=pow(liczba1, 1/2.);
	stopien_4=pow(liczba1, 1/4.);
	stopien_8=pow(liczba1, 1/8.);
	cout << liczba1 << "^(1/2)=" << stopien_2 << endl;
	cout << liczba1 << "^(1/4)=" << stopien_4 << endl;
	cout << liczba1 << "^(1/8)=" << stopien_8 << endl;
	cout << endl <<"###########################################" << endl << endl << endl;	
	main(argc, argv);
	return 0;
}
