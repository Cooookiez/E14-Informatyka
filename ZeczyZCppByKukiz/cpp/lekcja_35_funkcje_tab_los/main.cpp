#include <iostream>
#include <cstdlib>
#include <ctime>
#include <math.h>

using namespace std;

int main(int argc, char** argv) {
	srand(time(NULL));
	
	int min_x = -10, max_x = 10;
	int min_abc = -20, max_abc = 20;
	int ile_f = 15;
	
	int ile_x = -1*min_x + max_x + 1;
	int funkcja[ile_f][3];
	int wynik[ile_f][ile_x];
	
	cout << "..::yo::.."<< endl;
	
	//daje parametry a, b, c do tablicy kazdej jednej funkcja
	for(int i = 0; i < ile_f; i++){
		for(int j = 0; j < 3; j++){
			funkcja[i][j] = min_abc + rand()%(max_abc - min_abc + 1);
		}
	}
	
	//oblicza funckje
	for(int i = 0; i < ile_f; i++){
		for(int k = 0; k < ile_x; k++){
			//y = ax^2 + bx + c
			int x = k-10;
			wynik[i][x] = funkcja[i][0]*x*x + funkcja[i][1]*x + funkcja[i][2];
		}
	}
	
	//wypisuje funckje
	for(int i = 0; i < ile_f; i++){
		cout << "===================================" << endl << endl;
		cout << "f = "<<funkcja[i][0]<<"x^2 + "<<funkcja[i][1]<<"x + "<<funkcja[i][2]<<" " << endl << endl;
		for(int k = 0; k < ile_x; k++){
			int x = k-10;
			//cout << "\tf = " << wynik[i][x] << "\t\t|\tDla x = " << x << endl;
			cout << "Dla x = " << x << "\tf = " << wynik[i][x] << endl;
			//cout << wynik[i][x] << "\t = " << funkcja[i][0] << "x^2 + " << funkcja[i][1] << "x + " << funkcja[i][2] << "\t dla x = " << x << endl;
		}
		cout << endl;
	}
	
	
	
	return 0;
}
