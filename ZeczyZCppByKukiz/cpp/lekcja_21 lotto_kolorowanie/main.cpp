#include <iostream>
#include <cstdlib>
#include <ctime>
#include <windows.h>

using namespace std;
	HANDLE h = GetStdHandle( STD_OUTPUT_HANDLE);

void logo()
{SetConsoleTextAttribute(h, FOREGROUND_GREEN);
	cout << "=== LOTTO ===" << endl << endl;
}

int iMaxLiczba = 50;
int iIleLiczb = 6;

void parametry()
{
	system("cls");
	logo();
	cout << "podaj max liczbe: ";
	cin >> iMaxLiczba;
	cout << "podaj ile liczb: ";
	cin >> iIleLiczb;
}
	

void losuj()
{

	int aLiczba[iIleLiczb];
	bool bPowtarzaSie;
	
	srand(time(NULL));
	for (int i = 0; i < iIleLiczb;)
	{
		aLiczba[i] = rand()%iMaxLiczba+1;
		
		bPowtarzaSie = false;
		for (int j = 0; j < i; j++)
		{
			if (aLiczba[i] == aLiczba[j])
			{
				bPowtarzaSie = true;
				break;
			}
		}
		if (!bPowtarzaSie)
		{
			i++;
		}
	}
	
	
	system("cls");
	logo();
/*	for (int i = 0; i < iIleLiczb; i++)
		cout << "liczba nr " << i+1 << ": " << aLiczba[i] << endl;
*/
	bool bJestLiczba;
	int licznikLiczba = 0;
	HANDLE h = GetStdHandle( STD_OUTPUT_HANDLE);
	for (int i = 0; i < iMaxLiczba; i++)
	{
		bJestLiczba = false;
		//for (int j = 0; j < iMaxLiczba; j++)
		for ( int j = 0; j < iIleLiczb; j++)
			if ( i+1 == aLiczba[j])
				bJestLiczba = true;
		if(bJestLiczba)
		{
			SetConsoleTextAttribute(h, FOREGROUND_RED);
		}
		else
		{
			SetConsoleTextAttribute(h, FOREGROUND_GREEN);
		}
		
			cout << "\t" << i+1;
		if((i+1)%10==0)
			cout << endl;
		licznikLiczba++;
	}
}

int main()
{
	/*
	const int ILOSC_LICZB = 6;
	const int MAX_LICZBA = 6;
	
	int aLiczba[ILOSC_LICZB];
	bool bPowtarzaSie;
	
	srand(time(NULL));
	for (int i = 0; i < ILOSC_LICZB;)
	{
		aLiczba[i] = rand()%MAX_LICZBA+1;
		
		bPowtarzaSie = false;
		for (int j = 0; j < i; j++)
		{
			if (aLiczba[i] == aLiczba[j])
			{
				bPowtarzaSie = true;
				break;
			}
		}
		if (!bPowtarzaSie)
		{
			i++;
		}
	}
	for (int i = 0; i < ILOSC_LICZB; i++)
		cout << "liczba nr " << i+1 << ": " << aLiczba[i] << endl;
	*/
	
	logo();
	cout << "1. losuj 6 liczb 1-50" << endl;
	cout << "2. Wlsane parametry" << endl;
	cout << "- - - - - - - - - - - -" << endl;
	cout << "Wybor: ";
	int wybor;
	cin >> wybor;
	
	switch(wybor)
	{
		default:
		case 1:
			losuj();
			break;
		case 2:
			parametry();
			losuj();
			break;
	}
	
	
	return 0;
}
