#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;


int main(int argc, char** argv) {
	setlocale(LC_ALL,"");//ustawia polskie okonki
	
	
	
	ifstream plik("text.txt",ios::in);
	if(plik.good()){
		int akp = 0, zdan = 0, wyr = 0;
		string napis;
		while(!plik.eof()){
			getline(plik,napis);
			cout << napis << endl;
			int dl = napis.length();
			for(int i =0; i < dl; i++){
				if(napis[i] == '.')
					zdan++;
				if(napis[i] == ' ')
					wyr++;
			}
			akp++;
		}
		plik.close();
		
		cout << "\n\nliczba akapitów: " << akp << endl;
		cout << "Liczba zdañ: " <<zdan<< endl;
		cout << "Liczba spacji: " <<wyr<< endl;
		wyr += akp;
		cout << "Liczba wyrazów: " <<wyr<< endl;
	}
	
	return 0;
}
