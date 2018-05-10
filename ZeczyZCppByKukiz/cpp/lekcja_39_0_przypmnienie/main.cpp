#include <iostream>
#include <cstdlib>
#include <fstream>
#include <ctime>

using namespace std;

int main(){
	int max = 1000, min = -1000, ile = 10000;
	ofstream ifile("losy.txt", ios::app);
	if(ifile){
		srand(time(NULL));
		for(int i = 0; i<ile; i++){
			ifile << min+rand()%(max-min+1) << endl;
		}
		ifile << endl << "----------------------------" << endl << endl;
		ifile.close();
	}else{
		cout << "nie otwarto pliku" << endl;
	}
	
	return 0;
}
