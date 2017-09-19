#include <iostream>

using namespace std;

//funkcja void (nic nie zwraca
void nicNIeZwraca(int wiek){
	cout << wiek;
}

//funkcja bool (zwraca prawde albo fałsz)
bool czyJestA(string str){
	int dl = str.length();	//długość napisu
	for(int i = 0; i < dl; i++){
		if(str[i] == 'a' || str[i] == 'A'){	
			return true;	// lub return 1
		}
	}
	return false; // lub return 0
}

int wiekZa10Lat(int wiek){
	return wiek + 10;
}

float dzielenie(float dzielna, int dzielnik){
	return dzielna / (float)dzielnik;
}

//funkcja rekurencyjna (funkcja wywołująca samom siebie)
int silnia(int liczba){
	if(liczba <= 1){
		return 1;	
	}
	else{
		return liczba*silnia(liczba-1);
	}
}



int main(int argc, char** argv) {
	
	bool jestA =  czyJestA("Witam Serdecznie");
	cout << "czyJestA(\"Witam Serdecznie\"):\t" << jestA << endl;
	//wynik:	1		(true)
	
	cout << "nicNIeZwraca(14):\t";
	nicNIeZwraca(14);
	cout << endl;
	//brak wyniku, poprostu napisze 14 (nie można dać to zmiennej)
	
	cout << "wiekZa10Lat(17):\t" << wiekZa10Lat(17) << endl;
	//wynik:	27
	
	cout << "dzielenie(14.5, 2):\t" << dzielenie(14.5, 2) << endl;
	//wynik:	7.25
	
	cout << "silnia(5):\t" << silnia(5) << endl;
	//wynik:	120		(5! = 1*2*3*4*5)
	
	
	return 0;
}