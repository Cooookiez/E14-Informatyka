#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(int argc, char** argv) {
	
	ifstream plik("plik.txt");
	string napis;
	if(plik.good()){
		while(!plik.eof()){
			getline(plik,napis);
			cout << napis << endl;
		}
		plik.close();
	}
	
	return 0;
}
