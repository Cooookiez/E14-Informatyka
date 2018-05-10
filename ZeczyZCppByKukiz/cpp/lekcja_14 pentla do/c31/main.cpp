#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

void menu(){
	system("cls");
	cout << "---------- MENU ----------" <<
	endl << "1. Pochalka" <<
	endl << "2. Zrybka" <<
	endl << "3. Obojetnosc" <<
	endl << "0. koniec" <<
	endl << "--------------------------" << 
	endl << "Wybierz: ";
}

int main()//by Qkiz
{
	menu();
	int wybor;
	do{
		cin.clear();
		cin.sync();
		cin >> wybor;
		cin.good();
		if(cin.good()==0||(wybor>3||wybor<0))
			menu();
	}while(cin.good()==0||(wybor>3||wybor<0));
	
	switch(wybor){
		case 1:
			system("cls");
			cout << 1 << endl;
			break;
		case 2:
			system("cls");
			cout << 2 << endl;
			break;
		case 3:
			system("cls");
			cout << 3 << endl;
			break;
		case 0:
			system("cls");
			cout << 0 << endl;
			break;
		default:
			break;
	}
	
	system("pause");
	system("cls");
	main();
	return 0;
}


