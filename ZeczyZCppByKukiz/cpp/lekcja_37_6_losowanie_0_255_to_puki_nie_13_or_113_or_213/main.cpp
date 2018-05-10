#include <iostream>
#include <cstdlib>
#include <fstream>
#include <ctime>

using namespace std;

int main(int argc, char** argv) {
	srand(time(NULL));
	
	int los;
	
	ofstream doPliku("losy.txt");
	if(doPliku.good()){
		
		do{
			los = rand()%256;
			doPliku << los << endl;
		}while(los != 13 && los != 113 && los != 213);
		
		doPliku.close();
	}
	
	
	return 0;
}
