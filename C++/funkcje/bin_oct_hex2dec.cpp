#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int bin2dec(string);
int oct2dec(string);
int hex2dec(string);

int main() {
	setlocale(LC_ALL, "");
	
	cout << "bin2dec(\"100001011001\"):\t" << bin2dec("100001011001") << endl;
	cout << "oct2dec(\"12345670\"):\t" << oct2dec("12345670") << endl;
	cout << "hex2dec(\"ff\"):\t" << hex2dec("ff") << endl;
	
	return 0;
}

int bin2dec(string bin){
	int dl = bin.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		if(bin[i] == '1'){
			dec += pow(2,lvl);
		}
		lvl++;
	}
	return dec;
}

int oct2dec(string oct){
	int dl = oct.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		switch(oct[i]){
			case '0':
				dec += 0;
				break;
			case '1':
				dec += 1*pow(8,lvl);
				break;
			case '2':
				dec += 2*pow(8,lvl);
				break;
			case '3':
				dec += 3*pow(8,lvl);
				break;
			case '4':
				dec += 4*pow(8,lvl);
				break;
			case '5':
				dec += 5*pow(8,lvl);
				break;
			case '6':
				dec += 6*pow(8,lvl);
				break;
			case '7':
				dec += 7*pow(8,lvl);
				break;
			default:
				dec = -1;
				break;
		}
		lvl++;
	}
	return dec;
}

int hex2dec(string hex){
	int dl = hex.length();
	int lvl = 0;
	int dec = 0;
	for (int i = dl-1; i >= 0; i--){
		switch(hex[i]){
			case '0':
				dec += 0;
				break;
			case '1':
				dec += 1*pow(16,lvl);
				break;
			case '2':
				dec += 2*pow(16,lvl);
				break;
			case '3':
				dec += 3*pow(16,lvl);
				break;
			case '4':
				dec += 4*pow(16,lvl);
				break;
			case '5':
				dec += 5*pow(16,lvl);
				break;
			case '6':
				dec += 6*pow(16,lvl);
				break;
			case '7':
				dec += 7*pow(16,lvl);
				break;
			case '8':
				dec += 8*pow(16,lvl);
				break;
			case '9':
				dec += 9*pow(16,lvl);
				break;
			case 'A':
			case 'a':
				dec += 10*pow(16,lvl);
				break;
			case 'B':
			case 'b':
				dec += 11*pow(16,lvl);
				break;
			case 'C':
			case 'c':
				dec += 12*pow(16,lvl);
				break;
			case 'D':
			case 'd':
				dec += 13*pow(16,lvl);
				break;
			case 'E':
			case 'e':
				dec += 14*pow(16,lvl);
				break;
			case 'F':
			case 'f':
				dec += 15*pow(16,lvl);
				break;
			default:
				dec = -1;
				break;
		}
		lvl++;
	}
	return dec;
}