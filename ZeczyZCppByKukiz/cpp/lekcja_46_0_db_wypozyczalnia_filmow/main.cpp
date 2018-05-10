#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <fstream>
#include <string>

using namespace std;


int gui_start(){
	system("cls");
	cout << "..:: Filmowa baza danych by Kristof Kukiz ::.." << endl;
	cout << "- - - - - - - - - - - - - - - - - - - - - - - -" << endl;
	cout << " 1. Pokaz wszystko" << endl; 
	cout << " 2. Wyszukaj w bazie" << endl; 
	cout << " 3. Edytuj baze" << endl; 
	cout << " 4. Wstaw nowy rekord" << endl;
	cout << " 0. exit.exe" << endl;
	cout << "- - - - - - - - - - - - - - - - - - - - - - - -" << endl;
	cout << "Wybierz: ";
	int opc = 0;
	cin >> opc;
	if(!cin.good() || ( opc > 4 || opc < 0 ) ){
		opc = gui_start();
	}
	system("cls");
	return opc;
}

void wszystko(){
	string temp;
	ifstream zPliku("db.qdb");
	
	/*	ile rekordow	*/
	int ile_rek = 0;
	if(zPliku.good()){
		while(!zPliku.eof()){
			getline(zPliku, temp);
			cout << temp << "\t";
		}
		cout << endl;
		ile_rek--;
		zPliku.close();
	}else cout << "Cos posz³o nie tak" << endl; //ile rekordw END
	
	
	system("pause");
}

int main(){
    setlocale(LC_ALL,"");
	bool run = true;
	do{
		int opc = gui_start();
		switch(opc){
			case 1:
				wszystko();
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 0:
			default:
				run = false;
				break;
		}	
	}while(run);
	return 0;
}
