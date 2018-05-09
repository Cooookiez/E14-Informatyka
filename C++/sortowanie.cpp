#include <iostream>
#include <cstdlib>

using namespace std;

int main() {
	
	int liczby[10] = {5, 12, 6, 7, 8, 1, 4, 19, 45, 32};
	int ile = sizeof(liczby)/sizeof(liczby[0]);
	int tmp;
	
	for(int i = 0; i < ile; i++) cout << liczby[i] << ", ";
	cout << endl;
	
	for(int i = 0; i < ile; i++){
		for(int j = 0; j < ile; j++){
			if(liczby[j] > liczby[j+1]){
				tmp = liczby[j];
				liczby[j] = liczby[j+1];
				liczby[j+1] = tmp;
			}
		}
	}
	
	for(int i = 0; i < ile; i++) cout << liczby[i] << ", ";
	cout << endl;
	
	
	return 0;
}



