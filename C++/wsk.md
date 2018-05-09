# Wskaźniki

## co jest w zmiennych
```c++
    nt zmienna = 10;
    int *wskaznik = &zmienna;
    *wskaznik = 13;
    cout << "zmienna: " << zmienna << endl;		//13
    cout << "&zmienna: " << &zmienna << endl;		//0x6ffe34
    cout << "wskaznik: " << wskaznik << endl;		//0x6ffe34
    cout << "*wskaznik: " << *wskaznik << endl;		//13
```

## tablice
```c++
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
```

## "zwracanie" tablic w funkcji
```c++
void zwracanieTablicy(int* wks, int ile){
	for(int i = 0; i < ile; i++){
		*(wks+i) = 2018;
	}
	// w tym momencie wszystkie miejsca są zaktualizowane
}
int main(){
    int tab2[10];
	for(int i = 0; i < 10; i++){
		tab2[i] = i;
	}
	for(int i = 0; i < 10; i++){
		cout << tab2[i] << endl;
	}
	int *wsk;
	wsk = tab2;
	zwracanieTablicy(wsk, 10);
	for(int i = 0; i < 10; i++){
		cout << tab2[i] << endl;
	}
    return 0;
}
```