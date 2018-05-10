#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;


int main(int argc, char** argv) {
	
	
	ofstream doPliku("../tekst.txt", ios::out);
	if(doPliku){
		cout << "Jest k" << endl;
		for(int i = 10; i >=0; i-=2){
			doPliku << i << endl;
		}
	}else{
		cout << "Jakis error" << endl;
	}
	doPliku.close();
	
	return 0;
}
