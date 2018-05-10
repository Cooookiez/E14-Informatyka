#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	const int ILE=10;// iloc dat z dodana 3

	int lata[ILE];	
	cout << "Rok startowy : ";
	cin >> lata[0];
	for(int i=0; i<ILE; i++){// przypisanie liczb do tablicy
		lata[i+1]=lata[i]+3;
	}
	cout << endl;
	for(int i=0; i<ILE; i++){// wyswietlaeni wartosci tablicy
		cout << lata[i] << endl;
	}
	
	bool jest;
	int jakis_rok, taknie=0;
	cout << endl << "Podaj rok to sprawdzenia : ";
	cin >> jakis_rok;
	cout << endl;
	for(int i=0; i<ILE; i++){
		if(jakis_rok==lata[i]){
			jest=1;
			break;
		}
	}
	if(jest)
		cout <<  "ten rok wystepuje" << endl;
	else
		cout <<  "ten rok nie wystepuje" << endl;
	
	cout << endl;
	for(int i=0; i<ILE; i++){
		if(lata[i]%2){
			cout << "tablica " << i << ". 2015"<<endl;
		}
	}
	
	cout << endl << endl << "- - - - - - - - - - - - - - - - -" << endl;
	system("pause");
	system("cls");
	main();
	return 0;
}
