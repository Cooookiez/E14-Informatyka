# Menu
```cpp
#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	int opcja;
	
	do{
		cout << "1. Dodawanie" <<
		endl << "2. Odejmowanie" <<
		endl << "3. Mnozenie" <<
		endl << "4. Dzielenie" << 
		endl << "0. wyjdz z programu" <<
		endl << "- - - - - - - - - - -" <<
		endl << "Wybierz: ";
		cin >> opcja;
		
		cout << "- - - - - - - - - - -" << endl;
		switch(opcja)
		{
			case 0:
				break;
			case 1:
				cout << "wybrales opcje \"1\" (dodawanie)" << endl;
				break;
			case 2:
				cout << "wybrales opcje \"2\" (odejmowanie)" << endl;
				break;
			case 3:
				cout << "wybrales opcje \"3\" (mnozenie)" << endl;
				break;
			case 4:
				cout << "wybrales opcje \"4\" (dzielnie)" << endl;
				break;
			default:
				cout << "Error 404, sry" << endl;
				break;
					
		}
		if(opcja>=1&&opcja<=4)
			cout << "- - - - - - - - - - -" << endl;
		if(opcja>=1)
		{
			system("pause");
			system("cls");
		}
		
	}while(opcja!=0);
	return 0;
}
```