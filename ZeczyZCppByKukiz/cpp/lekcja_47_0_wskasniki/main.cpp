#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

void zeruj(int *tab, int ile){
	for(int i= 0; i < ile; i++){
		*(tab+i)=0;
	}
}
void losuj(int *wsk, int ile){
	for(int i = 0; i < ile; i++){
		*(wsk+i) = (rand()%10)+1;
	}
}
void zamien(int &a, int &b){
	b = a + b;
	a = b - a;
	b = b - a;
}
void sortuj(int *wsk, int ile){
	for(int i = 0; i < ile; i++){
		for(int j = 0; j < ile; j++){
			if( *(wsk+i) > *(wsk+j) ){
				zamien(*(wsk+i),*(wsk+j));
			}
		}
	}
}
void pokaz(int *wsk, int ile){
	for(int i = 0; i < ile; i++){
		cout << *(wsk+i) << ", ";
	}
}

int main(int argc, char** argv) {
	setlocale(LC_ALL, "");
	/*
	int zmienna = 10;
	int *wskaznik = &zmienna;
	*wskaznik = 13;
	cout << "zmienna: " << zmienna << endl;
	cout << "&zmienna: " << &zmienna << endl;
	cout << "wskaznik: " << wskaznik << endl;
	cout << "*wskaznik: " << *wskaznik << endl;
	*/
	
	/*
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
	*/
	
	/*
	int a = 3;
	float *wsk;
	wsk = new float;
	
	*wsk = 11 * a;
	cout << "*wsk:\t" << *wsk << endl;
	cout << "wsk:\t" << wsk << endl;
	delete wsk;
	cout << "po delete:" <<endl;
	cout << "*wsk:\t" << *wsk << endl;
	cout << "wsk:\t" << wsk << endl;
	*/
	
	/*
	int dl = 20;
	int *w13;
	w13 = new int[dl];
	for(int i = 0; i < dl; i++){
		*(w13+i) = i;
	}
	for(int i = 0; i < dl; i++) cout << *(w13+i) << ", "; cout << endl;
	system("pause");
	delete w13;
	for(int i = 0; i < dl; i++) cout << *(w13+i) << ", "; cout << endl;
	*/
	
	/*
	int ile;
	cout << "Podaj wieko tablicy: ";
	cin >> ile;
	
	int *wsk;
	wsk = new int[ile];
	for(int i = 0; i < ile; i++) cout << *(wsk+i) << ", "; cout << endl;
	zeruj(wsk, ile);
	for(int i = 0; i < ile; i++) cout << *(wsk+i) << ", "; cout << endl;
	*/
	
	
	srand(time(NULL));
	int ile;
	cout << "Podaj wieko tablicy: ";
	cin >> ile;
	system("cls");
	
	int *wsk;
	wsk = new int[ile];
	
	cout << "nie sortowane: "; 
	losuj(wsk, ile);
	pokaz(wsk, ile);
	
	cout << endl<< "    sortowane: "; 
	sortuj(wsk,ile);
	pokaz(wsk, ile);
	
	
	return 0;
}
