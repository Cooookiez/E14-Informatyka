#include <cstdlib>
#include <iostream>
#include <ctime>

using namespace std;

int main(int argc, char** argv) {
	
	srand(time(NULL));
	int i = rand () % 2 + 1 ;
	char imie;
	cout << " Ban na grupie = 1 / Brak bana = 2 " << endl;
	cout << " Podaj imie: " ;
	cin >> imie;
	if ( i = 1){
		int j = rand () % 3 + 1 ;
		cout << " Na ile? " << endl
			 << " 1 = tydzien " << endl
			 << " 2 = 2 tygodnie " << endl
			 << " 3 = na stale " << endl;
		cout << j;
	}
	else 
		cout << " Zostales ulaskawiony ; ) ";
	
	return 0;
}
