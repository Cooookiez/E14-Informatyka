#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) 
{
	int red, blue, green;
	cout << "RGB na notacje szesnastkowa" << endl << endl;
	cout << "podaj wartosc \"RED\" : ";
	cin >> red;
	cout << "podaj wartosc \"BLUE\" : ";
	cin >> blue;
	cout << "podaj wartosc \"GREEN\" : ";
	cin >> green;
	cout << "Wartosc dla \"RED\" w notacji szesnatkowej = " << hex << red << endl;
	cout << "Wartosc dla \"BLUE\" w notacji szesnatkowej = " << hex << blue << endl;
	cout << "Wartosc dla \"GREAN\" w notacji szesnatkowej = " << hex << green << endl;
	
	return 0;
}
