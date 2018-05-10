#include <iostream>
#include <ctime>

using namespace std;

string pomieszaj(string haslo){
	srand(time(NULL));
	string pomieszane = "";
	while(int dl = haslo.size()){
		int los = rand()%dl;
		pomieszane += haslo[los];
		haslo.erase(los, 1);
	}
	return pomieszane;
}

int main(){
	string haslo = "maslo";
	string pomieszane = pomieszaj(haslo);
	string hasloUsr = "";
	int pruba = 0;
	
	do{
		system("cls");
		pruba++;
		cout << "Pruba: " << pruba << endl;
		cout << "Pomieszane haslo:\t" << pomieszane << endl << endl;
		cout << "Zgadniej:\t\t";
		getline(cin, hasloUsr);
		
	}while(haslo != hasloUsr);
	system("cls");
	cout << "Brawo!" <<
	endl << "Odgadles haslo: " << haslo <<
	endl << "Za " << pruba << " razem" << endl;
	
	
	return 0;
}
