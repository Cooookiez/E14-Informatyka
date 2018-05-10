#include <iostream>
#include <cstdlib>
#include <fstream>
#include <conio.h>
#include <ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
string mieszaj(string slowo)
{
	string mieszanka=" ";
	int pozycja;
	while (slowo.size()!=0)
	{
		pozycja=rand()%slowo.size();
		mieszanka+=slowo[pozycja];
		slowo.erase(pozycja,1);
	}
	return mieszanka;
}
int main(int argc, char** argv) {
	srand(time(NULL));
	string sekretneSlowo, pomieszaneSlowo, slowoUsera;
	cout <<"Podaj slowo: ";
	cin>>sekretneSlowo;
	system("cls");
	pomieszaneSlowo=mieszaj(sekretneSlowo);
	do{
		cout<<"Co to za slowo?- "<<pomieszaneSlowo<<endl;
		cout<<"Wpisz odpowiedz: ";
		cin>>slowoUsera;
		if (slowoUsera==sekretneSlowo)
			cout<<"Brawo! Odgadles";
		else
			cout<<"Sprobuj ponownie...";
			cout<<endl;
	}while(slowoUsera!=sekretneSlowo);
	return 0;
}
