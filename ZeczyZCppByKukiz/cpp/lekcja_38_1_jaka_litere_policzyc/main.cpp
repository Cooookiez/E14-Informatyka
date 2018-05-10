#include <iostream>
#include <fstream>
#include <cstdlib>

using namespace std;

int policz(char litera){
	
	int ile = 0;
	ifstream plik("text.txt",ios::in);
	if(plik.good()){
		string text;
		while(!plik.eof()){
			getline(plik,text);
			int dl = text.length();
			for(int i = 0; i < dl; i++){
				if(litera == text[i])
					ile++;
			}
		}
		plik.close();
	}else{
		return -1;
	}
	
	return ile;
	
}

int main(int argc, char** argv) {
	setlocale(LC_ALL,"");//ustawia polskie okonki
	/*
	char koniec = 'n';
	do{
		char litera;
		cout << "podaj literke do sprawdzenia: ";
		cin >> litera;
		cout << "Liczba liter '"<<litera<<"' to: " << policz(litera) << endl << endl;
		
		
		cout << "koniec? (t/n): ";
		cin >> koniec;
		cout << endl << endl << endl;
	}while(koniec != 't');*/
	
	string abc = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpRrSsTtUuWwXxYyZz";
	int abc_dl = abc.length();
	for(int i = 0; i < abc_dl; i++){
		cout << abc[i] << ":\t" << policz(abc[i]) << endl;
	}
	system("PAUSE");
	
	
	return 0;
}
