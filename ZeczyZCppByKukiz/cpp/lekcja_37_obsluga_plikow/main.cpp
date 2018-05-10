#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(int argc, char** argv) {
	string napis;
//zapisywanie pliku
	/*cout << "Napisz cos: ";
	getline(cin, napis);
	
	ofstream doPliku("tekst.txt", ios::out);
	if(doPliku){
		cout << "Otwarto plik tekst.txt..." << endl;
		doPliku << napis << endl;
		doPliku << "Koniec" << endl;
		cout << "Wpisano napis do pliku" << endl << endl;
	}
	doPliku.close();
	cout << endl;
	napis = "";
	*/
	
	
//wczytywanie pliku
	ifstream zPliku("tekst.txt");
	if(zPliku){
		getline(zPliku, napis);
		cout << napis << endl;
	}
	zPliku.close();
	
	return 0;
}
