#include <iostream>
#include <cstdlib>
#include <windows.h>

using namespace std;

bool czy_trujkat(float a, float b, float c){
	
	if (a +  b > c	&&
		a + c > b	&&
		c + b > a	){	//jest trujkat
		return true;
	}else{	//nie ma trujkata
		return false;
	}
}

string kreseczki(string wyraz){
	int wyraz_dl = wyraz.length(); 
	string wyraz_out = "";
	/*
	for (int i = 0; i < wyraz_dl; i++){
		wyraz_out += wyraz[i];
		if (i < wyraz_dl-1)
			wyraz_out += "_";
	}*/
	
	for (int i = 0; i < wyraz_dl; i++){	//zmienia wyraz na kreski
		wyraz_out += '-';
	}
	
	char literka;
	do{	//zamienia kreski na literki
		
		system("cls");
		cout << wyraz_out << endl;
		cout << "podaj jakas literka: ";
		cin >> literka;
		
		for(int i = 0; i < wyraz_dl; i++){
			if(literka == wyraz[i]){
				wyraz_out[i] = wyraz[i];
			}
		}
		
	}while(1);
	
	cout << endl;
	system("pause");
	return wyraz_out;
}

int main(){
	/*
	float a, b, c;
	cout << "podaj dlugosc boku a: ";
	cin >> a;
	cout << "podaj dlugosc boku b: ";
	cin >> b;
	cout << "podaj dlugosc boku c: ";
	cin >> c;
	
	if( czy_trujkat(a, b, c) ){
		cout << "Jest trujkat" << endl;
	}else{
		cout << "Ni ma trujakta" << endl;
	}
	*/
	
	string wyraz;
	cout << "Podaj jakis wyraz : ";
	cin >> wyraz;
	
	kreseczki(wyraz);
	
	//zapetla program
	cout << endl;
	system("pause");
	system("cls");
	main();
	return 0;
}
