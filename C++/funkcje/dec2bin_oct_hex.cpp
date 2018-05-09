#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

string dec2bin(int);
string dec2oct(int);
string dec2hex(int);


int main() {
	setlocale(LC_ALL, "");
    
	cout << "dec2bin(2137):\t" << dec2bin(2137) << endl;
	cout << "dec2oct(2137):\t" << dec2oct(2137) << endl;
	cout << "dec2hex(123457910):\t" << dec2hex(123457910) << endl;
	
	return 0;
}

string dec2bin(int dec){
	string bin = "";
    while(dec!=0){
    	bin = (dec%2==0 ? "0":"1") + bin;
    	dec/=2;
	}
    return bin;
}

string dec2oct(int dec){
	string oct;
	while(dec!=0){
		switch(dec%8){
			case 0: oct = "0"+oct; break;
			case 1: oct = "1"+oct; break;
			case 2: oct = "2"+oct; break;
			case 3: oct = "3"+oct; break;
			case 4: oct = "4"+oct; break;
			case 5: oct = "5"+oct; break;
			case 6: oct = "6"+oct; break;
			case 7: oct = "7"+oct; break;
			default: oct = "-1"; break;
		}
		dec/=8;
	}
	return oct;
}

string dec2hex(int dec){
	string hex;
	while(dec!=0){
		switch(dec%16){
			case 0: hex = "0"+hex; break;
			case 1: hex = "1"+hex; break;
			case 2: hex = "2"+hex; break;
			case 3: hex = "3"+hex; break;
			case 4: hex = "4"+hex; break;
			case 5: hex = "5"+hex; break;
			case 6: hex = "6"+hex; break;
			case 7: hex = "7"+hex; break;
			case 8: hex = "8"+hex; break;
			case 9: hex = "9"+hex; break;
			case 10: hex = "A"+hex; break;
			case 11: hex = "B"+hex; break;
			case 12: hex = "C"+hex; break;
			case 13: hex = "D"+hex; break;
			case 14: hex = "E"+hex; break;
			case 15: hex = "F"+hex; break;
			default: hex = "-1"; break;
		}
		dec/=16;
	}
	return hex;
}