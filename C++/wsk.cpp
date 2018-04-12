#include <iostream>

using namespace std;

void coJestWZmiennych(){
	int zmienna = 10;
	int *wskaznik = &zmienna;
	*wskaznik = 13;
	cout << "zmienna: " << zmienna << endl;			//13
	cout << "&zmienna: " << &zmienna << endl;		//0x6ffe34
	cout << "wskaznik: " << wskaznik << endl;		//0x6ffe34
	cout << "*wskaznik: " << *wskaznik << endl;		//13
}



int main() {
	setlocale(LC_ALL, "");
	
	//	coJestWZmiennych();
	
	int tablica[5];
	for(int i = 0; i < 5; i++){
		tablica[i] = i;
	}
	int *wTab;
	//ponizej same inaczej sapisane
		//1.
		wTab = &tablica[3];
		//2.
		wTab = tablica+3;
	//poniej inne same inaczje zapisane	
		*wTab = 0;
		tablica[3] = 0;
		*(tablica+3) = 0;
	
	return 0;
}

