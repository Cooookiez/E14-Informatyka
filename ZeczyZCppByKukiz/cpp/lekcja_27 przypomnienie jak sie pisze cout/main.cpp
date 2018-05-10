#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	
	cout << "Napisz jakies zdaie : ";
	string zdanie;
	getline(cin, zdanie);	//pobiera cala line
	int ileZnaki = zdanie.length();	//patrzy ile znakow ma zmienna zdanie (liczy sppacje)
	
	/*
	* liczy ilosc zdan i spacji
	*/
	int ileWyraz = 0;
	string trzeciWyrazNaOdwrut = "";
	string trzeciWyrazNaOdwrut2 = "";
	for(int i = 0; i < ileZnaki; i++){
		if( zdanie[i] == ' ' ){//liczy ile spacji
			ileWyraz++;
		}else if(ileWyraz == 2){//tworzy nowy string z 3 wyrazu
			trzeciWyrazNaOdwrut += zdanie[i];
		}
	}
	ileWyraz++; //zmienia ile spacji na ile wyrazow
	
	/*
	* pisze 3ci string ma odwród
	*/
	int ile3wyraz = trzeciWyrazNaOdwrut.length();
	for(int i = ile3wyraz-1; i >= 0; i--)
		trzeciWyrazNaOdwrut2 += trzeciWyrazNaOdwrut[i]; // dodaje po koleji litery liczac od tyluostatnie litery liczadodaje ostatni 
	
	cout << endl << zdanie << " - ma " << ileZnaki << " znakow i " << ileWyraz << " wyrazow" << endl;
	cout << trzeciWyrazNaOdwrut << " - " << trzeciWyrazNaOdwrut2;
	
	return 0;
}
