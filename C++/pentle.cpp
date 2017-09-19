#include <iostream>

using namespace std;

int main(int argc, char** argv) {
	
	/*
		Pętal for(){}
	*/
	for(int i = 0; i < 5; i++){
		cout << i << "\t";
	}
	cout << endl;
	//Wynik:	0	1	2	3	4
	
	
	/*
		Pętal while(){}
		Wykonuje się TYLKO jeżli parametr jest prawdziwy
	*/
	int index = 5;
	while(index > 2){
		cout << index << "\t";
		index--;
	}
	cout << endl;
	//wynik:	5	4	3
	
	
	/*
		do{}while()
		Wykona się ZAWSZE choć jeden raz, a dobiero sprawdza warunek i jeśli jest prawdziwy to się powtarza
	*/
	index = 5;
	do{
		cout << index << "\t";
		index--;
	}while(index > 8);
	cout << endl;
	//wynik:	5
	
	return 0;
}