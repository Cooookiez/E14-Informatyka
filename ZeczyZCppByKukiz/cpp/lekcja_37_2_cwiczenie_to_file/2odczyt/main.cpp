#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(int argc, char** argv) {
	
	ifstream zPliku("../tekst.txt");
	if(zPliku){
		cout << "plik otwarto" << endl << endl;
		int liczba;
		for(int i = 0; i < 6; i++){
			zPliku >> liczba;
			if(i) cout << ", ";
			cout <<liczba;
		}
	}else{
		cout << "Jakis error" << endl;
	}
	zPliku.close();
	
	cout << endl;
	system("pause");
	
	
	return 0;
}
