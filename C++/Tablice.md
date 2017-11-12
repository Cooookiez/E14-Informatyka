# tablice
```cpp
#include <iostream>
#include <string>

using namespace std;

int main(int argc, char** argv) {
	
	int tablica1[4];
	tablica1[0] = 4;
	tablica1[1] = 2;
	tablica1[2] = 7;
	tablica1[3] = 5;
	
	for(int i = 0; i < 4; i++){
		cout << tablica1[i] << endl;
	}
    
	/*
	Wynik:
		4
		2
		7
		5
	*/
	
	string tablica2[4][2] = {
		{"0.0", "0.1"},
		{"1.0", "1.1"},
		{"2.0", "2.1"},
		{"3.0", "3.1"}
	};
	
	for(int i = 0; i < 4; i++){
		cout << tablica2[i][0] << "\t" << tablica2[i][0] << endl;
	}
	/*
	Wynik:
		0.0 	0.1
		1.0 	1.1
		2.0 	2.1
		3.0 	3.1
	*/
	
	
	return 0;
}
``