#include <iostream>
#include <cstdlib>
#include <ctime>
//By: Qkiz

using namespace std;

int main(){
	
	srand(time(NULL));
	
	int min = -100,
		max = 100,
		ileLos = 100,
		los[ileLos],
		najmiejsza = max,
		najwieksza = min,
		ileMinus = 0,
		ilePlus = 0,
		ileZer = 0,
		ciag[ileLos];
	
	for (int i = 0; i < ileLos; i++){
		los[i] = min+rand()%(max-min+1);
		cout << los[i] << endl;
	}
	

	for(int i = 0; i < ileLos; i++){
	//wyszukiwanie najmiejszej i najwiekszyc
		if (najmiejsza > los[i])
			najmiejsza = los[i];
		else if (najwieksza < los[i])
			najwieksza = los[i];
	//ile liczb dodadnich i ile ujemnych
		if (los[i] > 0)
			ileMinus++;
		else if (los[i] < 0)
			ilePlus++;
		else 
			ileZer++;
	}
	cout << endl << endl << "============" << endl;
	cout << "Najwieksza: " << najwieksza << endl;
	cout << "najmiejsza: " << najmiejsza << endl;
	cout << "============" << endl;
	cout << "Liczby na plusie : " << ilePlus << endl;
	cout << "Liczby na minusie: " << ileMinus << endl;
	cout << "Zera: " << ileZer << endl;
	cout << "============" << endl;
	
	if (los[0] <= los[1])
		ciag[0] = los[1];
	for (int i = 1; i < ileLos; i++){
		if (los[i-1] <= los[i]){
			ciag[i] = los[i];
		}
		else ciag[i] = 0;
	}
		cout << ciag[0] << ", ";
	for (int i = 1; i < ileLos; i++){
		if (ciag[i])
		cout << ciag[i] << ", ";
	}
	system("pause");
	return 0;
}
