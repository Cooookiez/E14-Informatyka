#include <iostream>
#include <cstdlib>
#include <fstream>
#include <sstream>

using namespace std;

int main(){
	ifstream zPliku("text.txt");
	string wyrazy = "";
	if(zPliku.good()){
		string wyraz;
		while(zPliku >> wyraz){
			wyrazy = wyraz + " " + wyrazy;
		}
		zPliku.close();
	}
	cout << wyrazy;
	return 0;
}
