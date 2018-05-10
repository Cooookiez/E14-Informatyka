#include <iostream>
#include <cstdlib>
#include <fstream>
#include <ctime>

using namespace std;


int main(){
	srand(time(NULL));
	string out = "";
	
	ifstream zPliku("in.txt");
	if(zPliku.good()){
		char c_temp;
		while(!zPliku.eof()){
			c_temp = zPliku.get();
			if(rand()%2){
				out += toupper(c_temp);
			}else{
				out += tolower(c_temp);
			}
			
		}
		zPliku.close();
	}
	
	cout << out << endl;
	
	ofstream doPliku("out.txt", ios::out);
	if(doPliku){
		doPliku << out;
		doPliku.close();
	}
	
	return 0;
}
