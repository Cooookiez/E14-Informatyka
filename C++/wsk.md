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