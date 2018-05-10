#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	char wybor;
	do{
		string wyraz;
		cout << "Podaj wyraz: ";
		cin >> wyraz;
		int dl_wyraz= wyraz.length();
		
		cout << "twoj wyraz na odwrut : ";
		for(int i=dl_wyraz-1; i>=0; i--)
		{
			cout << wyraz[i];
		}
			
		cout << endl;
		cout << "Zakonczyc (y/n) : ";
		cin >> wybor;
		system("cls");
	}while(wybor!='y');
	
	return 0;
}
