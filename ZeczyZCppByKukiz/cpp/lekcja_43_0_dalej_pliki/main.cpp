#include <iostream>
#include <cstdlib>
#include <fstream>
#include <cmath>

using namespace std;

int main(){
	setlocale( LC_ALL, "" );
	//Id_k	Nazwisko	Imie	Wzrost	Nazwa_sieci	Wiek	Symbol_woj
	// 0	1			2		3		4			5		6
	
	int wiersze = 280;
	int kolumny = 7;
	string dane[wiersze][kolumny];
	
	int ile_zachodpom = 0;
	int wzrost_k = 0;
	int wzrost_m = 0;
	
	int najstarsza[2];
		najstarsza[0] = 0;
	int	najstarszy[2];
		najstarszy[0] = 0;
	
	//bobranie danych
	ifstream zPliku("dane_k.txt");
	if(zPliku.good()){
		for(int i = 0; i < wiersze; i++){
			for(int j = 0; j < kolumny; j++){
				zPliku >> dane[i][j];
			}
		}
		zPliku.close();
	}else{
		cout << "nie otworzono pliku" << endl;
	}
	
	
	//odczyt
	for(int i = 0; i < wiersze; i++){
		for(int j = 0; j < kolumny; j++){
			cout << dane[i][j] << "\t";
		}
		cout << endl;
		if(dane[i][6] == "Z") ile_zachodpom++;
	
		int wzrost = atoi( dane[i][3].c_str() );
		int wiek = atoi( dane[i][5].c_str() );
		
		/*k or m*/
		int dl = dane[i][2].length();
		if(dane[i][2][dl-1] == 'a'){
			wzrost_k += wzrost;
			if(wiek > najstarsza[0]){
				najstarsza[0] = wiek;
				najstarsza[1] = i;
			}
		}else{
			if(i == 8) cout << atoi( dane[i][5].c_str() ) << endl << endl;
			wzrost_m += wzrost;
			if(wiek > najstarszy[0]){
				najstarszy[0] = wiek;
				najstarszy[1] = i;
			}
		}
	}
	
	cout << endl;
	cout << "zachodnio pomorskie: " << ile_zachodpom << endl << endl;
	
	string kom_w = (wzrost_k > wzrost_m) ? "Kobiety wygraly!":"Mê¿czy¿ni wygrali!";
	cout << "laczna wysokosc:\t\t(" << kom_w << ")" << endl;
	cout << "\t-kobiet:\t" << wzrost_k << endl;
	cout << "\t-mê¿czyzna:\t" << wzrost_m << endl << endl;
	
	cout << "Najstarszy:" << endl;
	cout << "kobieta: "<<najstarsza[0]<<" - "<<dane[najstarsza[1]][1]<<" "<< dane[najstarsza[1]][2] << endl;
	cout << "mêrzczyzna: "<<najstarszy[0]<<" - "<<dane[najstarszy[1]][1]<<" "<< dane[najstarszy[1]][2] << endl;
	
	
	return 0;
}
