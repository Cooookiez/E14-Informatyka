# Tworzenie funkcji

## void
> nic nie zwraca
```cpp
void nicNIeZwraca(int wiek){
	cout << wiek;
}
```

## bool (zwraca true lub false)
```cpp
bool czyJestA(string str){
	int dl = str.length();	//długość napisu
	for(int i = 0; i < dl; i++){
		if(str[i] == 'a' || str[i] == 'A'){	
			return true;	// lub return 1
		}
	}
	return false; // lub return 0
}
```

## int
```cpp
int wiekZa10Lat(int wiek){
	return wiek + 10;
}
```

## float
```cpp
float dzielenie(float dzielna, int dzielnik){
	return dzielna / (float)dzielnik;
}
```

## funkcja rekurencyjna (funkcja wywołująca samom siebie)
```cpp
int silnia(int liczba){
	if(liczba <= 1){
		return 1;	
	}
	else{
		return liczba*silnia(liczba-1);
	}
}
```