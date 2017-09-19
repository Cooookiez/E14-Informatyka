#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, char** argv) {
	
	srand(time(NULL));
	int liczbaMIN = 10;
	int liczbaMAX = 20;
	cout << rand()%10 << endl;	//liczby z zakresu 0-9
	cout << liczbaMIN+rand()%(liczbaMAX-liczbaMIN+1) << endl;	//liczby z zakresu liczbaMIN-liczbaMAX
	
	return 0;
}