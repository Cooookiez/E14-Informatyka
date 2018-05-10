#include <iostream>
#include <ctime>
#include <cstdlib>

using namespace std;
/*
liczba 100-200
150*los -100 - 100
	ile minus, ile plus, ile 0
*/

int main(){
	
	srand(time(NULL));
	int liczba = 200;
	int plusy = 0, minusy = 0, zera = 0;
	for(int j = 0; j < 10000; j++){
		for(int i = 0; i < liczba; i++){
			int los = rand()%201 - 100;
			//cout << los << ", ";
			if(los > 0){
				plusy++;
			}else if(los < 0){
				minusy++;
			}else{
				zera++;
			}
		}
	}
	/*
	do{
		cout << "Podaj iczbe z przedzialu 100 do 200: ";
		cin >> liczba;
	}while(liczba > 200 || liczba < 100);*/
	cout << endl << endl;
	
	cout << "Wylosowane liczby dodadnie:\t" << plusy <<
	endl << "Wylosowane liczby ujemne:\t" << minusy <<
	endl << "Wylosowane liczby 0:\t\t" << zera << endl;
	
	
	//main();
	
	
	return 0;
}
