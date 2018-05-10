#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int policz(string zdanie){
	int str_dl = zdanie.length();
	int ile = 0;
	string ztext;
	ifstream file("text.txt", ios::in);
	if(file.good()){
		while(!file.eof()){
			getline(file,ztext);
			int text_dl = ztext.length();
			for(int i = 0; i < text_dl; i++){
				bool jest = true;
				for(int j = 0; j < str_dl; j++){
					if(zdanie[j] != ztext[i+j])
						jest = false;
				}
				if(jest)
					ile++;
			}
		}
		file.close();
	}else
		return -1;
	return ile;
}

int main() {
	setlocale(LC_ALL,"");//ustawia polskie okonki
	
	char koniec = 'n';
	do{
		string wyraz;
		cout << "podaj wyraz do sprawdzenia: ";
		cin >> wyraz;
		cout << "Liczba liter '"<<wyraz<<"' to: " << policz(wyraz) << endl << endl;
		
		
		cout << "koniec? (t/n): ";
		cin >> koniec;
		cout << endl << endl << endl;
	}while(koniec != 't');
	
	return 0;
}
