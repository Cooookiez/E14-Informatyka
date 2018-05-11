#include <cstdlib>
#include <iostream>
#include <ctime>

using namespace std;
int main(){
	int a;
	int licznik = 0;
	while (1)
	{
		if(kbhit())
		{
			a = getch();
			if ( a == 27){ 
				cout << " Nacisnales ESC. Koniec Petli." << endl;
				break;
			}
			
			
			
		}
		
		system ("cls");
		cout << a << " - " << (char)a << " - " << licznik++ << endl;
		
		
		
	}





return 0;
}
