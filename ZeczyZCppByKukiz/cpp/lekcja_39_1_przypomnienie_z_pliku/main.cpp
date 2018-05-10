#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int main(){
	ifstream zPliku("losy.txt");
	int minusy = 0, plusy = 0, zero = 0;
	int temp;
	if(zPliku.good()){
		while(!zPliku.eof()){
			zPliku >> temp;
			if(temp < 0){
				minusy++;
			}else if(temp==0){
				zero++;
			}else{
				plusy++;
			}
		}
		zPliku.close();
	}else{
		cout << "Nie otwarto pliku";
	}
	cout << "Liczy dodadnie: " << plusy << endl;
	cout << "Liczy '0': " << zero << endl;
	cout << "Liczy ujemne: " << minusy << endl;
	return 0;
}
