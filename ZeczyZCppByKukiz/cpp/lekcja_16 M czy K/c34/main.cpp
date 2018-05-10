#include <iostream>
#include <cstdlib>
#include <windows.h>
#include <conio.h>
#include <ctime>

using namespace std;
/*
bool run = true;
const int height = 20, width = 30;

void setup()
{
}
void input()
{
}
void logic()
{
}
void draw()
{
	for(int i = 0; i < width+2; i++)
		cout << (char)219;
	cout << endl;
	
	for(int i = 0; i < height; i++)
	{
		for(int j = 0; j < width+2; j++)
		{
			if(j == 0 || j == width+1)
				cout << (char)219;
			else
				cout << " ";
		}
		cout << endl;
	}
	
	for(int i = 0; i < width+2; i++)
		cout << (char)219;
	cout << endl;
}
int main()
{
	setup();
	while(run)
	{
		input();
		logic();
		draw();
		Sleep(500);
		system("cls");
	}
	return 0;
}
*/


int main()
{
	char plec[5];
	for(int i = 0; i < 5; i++)
	{
		string imie;
		cout << i+1 << ". Podaj twoie imie : ";
		cin >> imie;
		plec[i] = imie[imie.length()-1] == 'a'? 'k':'m';
	}
	for(int i = 0; i < 25; i++)cout << '-';
	cout << endl;
	for(int i = 0; i < 5; i++)
		cout << plec[i] << " ";
	
	
	return 0;
}

