#include <iostream>

using namespace std;

float max4(float a, float b, float c, float d){
	b = (a > b) ? a : b;
	c = (b > c) ? b : c;
	d = (c > d) ? c : d;
	return d;
}

unsigned short loByte(unsigned short liczba){
	return liczba%256;
}
unsigned short hiByte(unsigned short liczba){
	return liczba/256;
}

int main(){
	int liczba = 65535;
	cout << "loBy: " << loByte(liczba) << endl;
	cout << "hiBy: " << hiByte(liczba) << endl;
	return 0;
}
