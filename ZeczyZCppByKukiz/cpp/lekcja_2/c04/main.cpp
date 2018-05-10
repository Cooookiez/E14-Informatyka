#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char** argv) 
{
	int liczba;
	
	liczba = 0xa1c; // liczby hex maja w c++ przetrstek 0x
	cout << dec << liczba << endl; // szesnastkowy na dziesietny
	liczba = 2588;
	cout << hex << liczba << endl << endl; //dziesietny na sesnastkowy
	
	liczba = 070; // liczba  osemkowa bo 0 przed liczba
	cout << dec << liczba << endl; // osemkowy na dziesietny
	liczba = 56;
	cout << oct << liczba << endl<< endl; // dziesietny na osemkowy
	
	
	
	
	
	
	
	system("PAUSE");
	return 0;
}
