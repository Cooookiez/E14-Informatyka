# Operacje na plikach
Odczytywany plik: [informatycy.txt](informatycy.txt)
Wymagane biblioteki:
```c++
#include <iostream>
#include <fstream>
```

## Odczytywanie pliku
### Odczytywanie po spacji
```c++
    ifstream ifile;
    ifile.open("informatycy.txt");
    string tmp;

    while(ifile >> tmp){
        cout << tmp << endl;
    }

    ifile.close();
```
Wynik:
```cmd
Krzysztof
Kukiz
Kevin
borowski
Konrad
Wojda
```
### Odczyttywanie po linijce
```c++
    ifstream ifile;
    ifile.open("informatycy.txt");
    string tmp;

    while(!ifile.eof()){
        getline(ifile, tmp);
        cout << tmp << endl;
    }

    ifile.close();
```
Wynik:
```cmd
Krzysztof Kukiz
Kevin borowski
Konrad Wojda
```

## Zapis do pliku
### Nadpisywanie pliku (ios::out)
```c++
    ofstream ofile;
    ofile.open("nadpisywanie.txt", ios::out);
    if(ofile){
        cout << "Zapis START" << endl;
        for(int i = 0; i < 20; i++){
            ofile << i << ", ";
        }
        cout << "Zapis END" << endl;
        ofile.close();
    }else{
        cout << "coś nie pykło" << endl;
    }
```
### Nadpisywanie linijek w pliku (ios::in)
```c++
    ofstream ofile;
    ofile.open("nadpisywanie2.txt", ios::in);
    if(ofile){
        cout << "Zapis START" << endl;
        for(int i = 0; i < 20; i++){
            ofile << i << ", ";
        }
        cout << "Zapis END" << endl;
        ofile.close();
    }else{
        cout << "coś nie pykło" << endl;
    }
```
### Dopisywanie do pliku (ios::app)
```c++
    ofstream ofile;
    ofile.open("dopisywane.txt", ios::app);
    if(ofile){
        cout << "Zapis ŚTART" << endl;
        for(int i = 0; i < 20; i++){
            ofile << i << ", ";
        }
        cout << "Zapis END" << endl;
        ofile.close();
    }else{
        cout << "coś nie pykło" << endl;
    }
```