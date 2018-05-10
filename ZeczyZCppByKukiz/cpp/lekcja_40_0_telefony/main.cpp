#include <iostream>
#include <cstdlib>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	int ile = 1000;
	unsigned int numer[ile];
	int a = 0,
		c = 0;;
	
	ifstream file("telefony.txt");
	if(file.good()){//otwarto plik
		int temp;
		for(int i = 0; i < ile; i++){
			file >> temp;
			numer[i] = temp;
			//a
			if(numer[i] == 504669045) a++;
			//b
			
			//c
			int temp2 = temp/1000000;
			if(temp2 == 511) c++;
			//d
			temp2 = temp;
			int suma = 0;
			for(int j = 0; j < 9; j++){
				if((temp2%10)%2 == 0){
					cout << temp2%10;
					suma += temp2%10;
				}
				temp2 /=10 ;
			}
			cout << endl;
			//e
			
			//f
			
			//g
			
			//h
			
		}
	}else
		cout << "nie otwarto pliku";
		
	cout << endl << "a)" << endl << "Z numeru 504 669 045 telefonowano " << a << " razy." << endl;
	cout << endl << "b)" << endl << "" << endl;
	cout << endl << "c)" << endl << "jest " << c << " numerow zaczynajacych sie na 511" << endl;
	cout << endl << "d)" << endl << "" << endl;
	cout << endl << "e)" << endl << "" << endl;
	cout << endl << "f)" << endl << "" << endl;
	cout << endl << "g)" << endl << "" << endl;
	cout << endl << "h)" << endl << "" << endl;

	
	return 0;
}
