#include <iostream>

using namespace std;
int main(int argc, char** argv) {
	
	//pobiera wyraz
	cout << "Podaj jakis wyraz: ";
	string wyraz;
	cin >> wyraz;
	
	int wyraz_dl = wyraz.length();	//patrzy dlugosc wyrazu
	
	//zamienia pierwsza i ostatnia na '.'
	for(int i = 0; i < wyraz_dl; i++){
		if(i == 0 || i == wyraz_dl-1){	//wypisuje '.'
			cout << '.';
		}else{
			cout << wyraz[i];			//wypisuje reszte wyrazu
		}
	}
	
	return 0;
}
