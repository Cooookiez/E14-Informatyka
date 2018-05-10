#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(int argc, char** argv) {
	
	ofstream doPliku("tekst.txt", ios::app);
	if(doPliku){
		
		string napis;
		cout << "Napisz cos: ";
		getline(cin, napis);
		
		doPliku << napis << endl;
		
		doPliku.close();
	}
	
	
	return 0;
}
