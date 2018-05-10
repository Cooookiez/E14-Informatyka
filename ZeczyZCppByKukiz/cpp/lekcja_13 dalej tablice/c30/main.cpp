#include <iostream>
#include <cstdlib>

using namespace std;

const int ILOSC=15;

int main()
{
	string imie[ILOSC]={"Krzysiek", "Przemek", "Waclaw", "Jacek", "Magda", "Patryk", "Dawid", "Mateusz", "Ola", "Klaudia", "Ewa", "Aika", "Tet", "Shiba", "Hori"};
	
	int ile_m=0, ile_d=0; // meskie, damskie
	for(int i=0; i<ILOSC; i++){
		if(imie[i][imie[i].length()-1]=='a'&&imie[i]!="Shiba"||imie[i]=="Hori")
			ile_d++;
	}
	
	ile_m=ILOSC-ile_d;
	cout << "Damsike : " << ile_d << endl;
	cout << "Meskie  : " << ile_m << endl;
	cout << endl;
	for(int i=0; i<ILOSC; i++){
		cout << imie[i][0];
		if(i+1<ILOSC) // jesli nie ma dalej imienia do nie wyswietla
			cout << "-";
	}
	cout << endl << endl;
	for(int i=0; i<ILOSC; i++){
		cout << imie[i] << " od tylu to : ";
		int dl_imie=imie[i].length();
		for(int il=dl_imie; il>=0; il--){
			cout <<imie[i][il];
		}
		cout << endl;
	}






	cout << endl << endl << "- - - - - - - - - - - - - - - - -" << endl;
	system("pause");
	system("cls");
	main();
	return 0;
}
