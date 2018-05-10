#include <iostream>
#include <cstdlib>
#include <ctime>
#include <windows.h>

using namespace std;

int main(int argc, char** argv)
{
	
	srand(time(NULL));
	

/*	while(1){
		for(int i=0;i<160;i++){
				cout << rand()%2;
			}
			Sleep(50);
			cout << endl;	
	}
	
	for(int i=0; i<10; i++){
		if(i==3)
			continue;
		cout << i << endl;
		if(i==7)
			break;
	}
	
	cout << "podaj jakies zdanie : ";
	string zdanie;
	getline(cin, zdanie);
	int ilosz_znakow=zdanie.length();
	cout << ilosz_znakow << endl;
	for(ilosz_znakow-1; ilosz_znakow>-1; ilosz_znakow--){
		cout << zdanie[ilosz_znakow];
	}
*/	
	cout << "podaj ilosc liczb do wylosowaniea: ";
	int ilosc;
	cin >> ilosc;
	cout << "- - - - - - - - - - - - - -" << endl << endl;
	for(ilosc; ilosc>0; ilosc--){
		cout << 100+rand()%(200-100+1) << endl;
		Sleep(25);
	}
	
	
	cout << endl << endl << "- - - - - - - - - - - - - -" << endl << endl;
	system("pause");
	system("cls");
	main(argc, argv);
	return 0;
}
