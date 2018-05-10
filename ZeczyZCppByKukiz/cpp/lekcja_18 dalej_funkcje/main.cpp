#include <iostream>
#include <cstdlib>
#include <math.h>
#include <stdlib.h>
#include <windows.h>
#include <ctime>

using namespace std;

bool czy_pierwsza(int liczba)
{
	bool li_pierwsza = true;
	int do_ile = sqrt(liczba);
	
	for(int i = 2; i < do_ile+1; i++)
	{
		if (liczba%i == 0)
		{
			li_pierwsza = false;
			break;
		}
	}
	return li_pierwsza;
}

int main()
{
	srand(time(NULL));
	for (int i = 0; i < 100; i++)
	{
		int liczba;
		liczba = 1000+rand()%(100000-1000+1);
		if (czy_pierwsza(liczba))
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),4);
			cout << liczba << endl;
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),15);
			cout << liczba << endl;
		}
	}
	return 0;
}
