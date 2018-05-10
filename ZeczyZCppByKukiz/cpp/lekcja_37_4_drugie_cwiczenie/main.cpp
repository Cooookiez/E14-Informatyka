#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(int argc, char** argv) {
	
	ofstream doPliku("plik.txt", ios::app);
	if(doPliku){
		bool koniec = false;
		string napis;
		while(!koniec){
			getline(cin, napis);
			if(napis == "koniec"){
				doPliku << "- - - - - - - - -" << endl << endl;
				koniec = true;
			}else{
				doPliku << napis << endl;
			}
		}
		doPliku.close();
	}else{
		cout << "Jakis error" << endl;
	}
	
	return 0;
}
