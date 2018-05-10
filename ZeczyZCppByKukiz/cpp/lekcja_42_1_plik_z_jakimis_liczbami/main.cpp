#include <iostream>
#include <cstdlib>
#include <fstream>
#include <sstrime>

using namespace std;

int main(){
	bool pierwszyWyw = true;
	int suma = 0;	//suma globalna
	int plus = 0, minus = 0, zero = 0;	// ile liczb dodadnich / ujemnych / zer
	int sPlus = 0, sMinus = 0;	//sumy dodadnich or ujemnych
	int liczba;	//temp
	ifstream zPliku("text.txt");
	if(zPliku.good()){
		while(zPliku >> liczba){
			if(liczba > 0){
				plus++;
				sPlus += liczba;
			}else if(liczba < 0){
				minus++;
				sMinus += liczba;
			}else{
				zero++;
			}
			suma += liczba;
		}
		zPliku.close();
	}
	cout << "Ilosc liczb dodadnich:\t"	<< plus << endl;
	cout << "Ilosc liczb ujemncyh:\t"	<< minus << endl;
	cout << "Ilosc liczb '0':\t"		<< zero << endl;
	cout << endl;
	cout << "Suma plusow:\t"	<< sPlus << endl;
	cout << "Suma minusow:\t"	<< sMinus << endl;
	cout << "Suma globalna:\t"	<< suma << endl;
	return 0;
}
