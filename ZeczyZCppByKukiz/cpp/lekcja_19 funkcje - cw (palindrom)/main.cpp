#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;
/*
bool palindrom(string wyraz)
{
	int dl = wyraz.length();
	string wyraz2;
	//odwraca wyraz do drugiej zmiennej
	for (int i = 0; i < dl; i++)
		wyraz2 += wyraz[dl-1-i];
	
	return wyraz == wyraz2;
}
*/

int bin2dec(string liczba)
{
	int dec = 0;
	
	for (int i = 0; i < liczba.length(); i++)
	{
		if (liczba[i] == '1')
			dec = dec* 2 + 1;
		else
			dec = dec*2 + 0;
	}
	return dec;
}

string dec2bin(int liczba)
{
	char temp[255];
	itoa(liczba, temp, 2);
	return (string)temp;
}
int main()
{
	srand(time(NULL));
	char koniec = 'n';
	do{
		int wybor;
		cout << "1. dec to bin" << endl;
		cout << "2. bin to dec" << endl;
		cout << "3. losuj 20" << endl;
		cout << "wybor : ";
		cin >> wybor;
		system("cls");
		
		int dec;
		string bin;
		
		switch(wybor)
		{
			case 1:
				cout << "podaj liczbe: ";
				cin >> dec;
				cout << dec << " to " << dec2bin(dec);
				break;
			case 2:
				cout << "podaj liczbe: ";
				cin >> bin;
				cout << bin << " to " << bin2dec(bin);
				break;
			case 3:
				for (int i = 0; i < 20; i++)
				{
					int dec = rand()%1001;
					cout << dec << " dec \t";
					if (dec < 100)
						cout << "\t";
					cout << dec2bin(dec) << " bin" << endl;
				}
				break;
			default:
				break;
		}
		
		cout << endl << endl << "czy zakonczyc? (y/n) : ";
		cin >> koniec;
		system("cls");
	}while(koniec != 'y');
	
	return 0;
}
